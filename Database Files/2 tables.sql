
use heartyhearthDB
go 

drop table if exists RecipeCourse
drop table if exists Course
drop table if exists CourseType
drop table if exists Meal
drop table if exists BookRecipe
drop table if exists Cookbook
drop table if exists Instruction
drop table if exists IngredientRecipe
drop table if exists MeasurementType
drop table if exists Ingredient
drop table if exists Recipe
drop table if exists Cuisine
drop table if exists Users 
go

create table dbo.Users(
    UsersID int not null IDENTITY primary key,
    FirstName varchar(30) not null 
        CONSTRAINT ck_Users_FirstName_cannnot_be_blank check(FirstName <> ''),
    LastName varchar(30) not null
        CONSTRAINT ck_Users_LastName_cannnot_be_blank check(LastName <> ''),
    UserName varchar(20) not null 
        constraint u_Users_userName unique
        CONSTRAINT ck_Users_UserName_not_blank check(UserName <> '')
)
go 

create table dbo.Cuisine(
    CuisineID int not null IDENTITY PRIMARY KEY,
    CuisineType varchar(30) not null 
        constraint u_Cuisine_CuisineType unique
        CONSTRAINT ck_Cuisine_CuisineType_cannot_be_blank CHECK(CuisineType <> '')
)
go 

create table dbo.Recipe(
    RecipeID int not null IDENTITY PRIMARY KEY,
    UsersID int not null 
        constraint f_Users_Recipe FOREIGN KEY REFERENCES Users(UsersID),
    CuisineID int not null 
        constraint f_Cuisine_Recipe FOREIGN KEY REFERENCES Cuisine(CuisineID),
    RecipeName varchar(50) not null 
        constraint u_Recipe_RecipeName unique
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> ''),
    Calories int not null 
        constraint ck_Recipe_Calories_not_negative check(Calories > 0),
    DateCreated DATETIME not null default getdate(),
    DatePublished DATETIME null,
    DateArchived DATETIME null,
    RecipeStatus as 
            CASE 
               when (DatePublished is null) and (DateArchived is null) then 'Draft'
               when (DatePublished is not null) and (DateArchived is null) then 'On site'
               when (DateArchived is not null) then 'Archive'
            end,
    CONSTRAINT ck_Recipe_DateCreated_before_DatePublished CHECK(DateCreated < DatePublished),
    CONSTRAINT ck_Recipe_DateCreated_before_DateArchived CHECK(DateCreated < DateArchived)
)
go 

create table dbo.Ingredient(
    IngredientID int not null IDENTITY PRIMARY KEY,
    IngredientType varchar(25) not null
        CONSTRAINT ck_Ingredient_Ingredientype_cannot_be_blank CHECK(IngredientType <> '')
        constraint u_Ingredient_IngredientType UNIQUE
)
go 

create table dbo.MeasurementType(
    MeasurementTypeID int not null IDENTITY PRIMARY KEY,
    MeasuringType varchar(10) not null 
       
)
go 

create table dbo.IngredientRecipe(
    IngredientRecipeID int not null IDENTITY PRIMARY KEY,
    RecipeID int not null 
        CONSTRAINT f_Recipe_IngredientRecipe FOREIGN KEY REFERENCES Recipe(RecipeID),
    IngredientID int not null 
        CONSTRAINT f_IngredientName_IngredientRecipe FOREIGN KEY REFERENCES Ingredient(IngredientID),
    MeasurementTypeID int not null 
        CONSTRAINT f_MeasurementType_IngredientRecipe FOREIGN KEY REFERENCES MeasurementType(MeasurementTypeID),
    Amount decimal(6,3) not null 
        CONSTRAINT ck_IngredientRecipe_Amount_not_negative CHECK(Amount > 0),
    IngSequence int not null  
        constraint ck_IngredientRecipe_IngSequence_not_negative CHECK(IngSequence > 0),
    CONSTRAINT u_IngredientID_RecipeID unique(IngredientID, RecipeID),
    constraint u_IngredientRecipe_IngSequence_RecipeID unique(RecipeID, IngSequence)
)
go

create table dbo.Instruction(
    InstructionID int not null IDENTITY PRIMARY KEY,
    RecipeID int not null 
        CONSTRAINT f_Recipe_Instruction FOREIGN KEY REFERENCES Recipe(RecipeID),
    InstructionStep varchar(150) not null
        CONSTRAINT ck_Instruction_InstructionStep_cannot_be_blank CHECK(InstructionStep <> ''),
    InstructionSequence int not null
        constraint ck_Instruction_InstructionSequence_cannot_be_negative check(InstructionSequence > 0),
    CONSTRAINT u_Instruction_RecipeID_InstructionStep unique(InstructionStep, RecipeID),
    CONSTRAINT u_Instruction_InstructionSequence_RecipeID unique(InstructionSequence, RecipeID)
)
go 

create table dbo.Cookbook(
    CookbookID int not null IDENTITY PRIMARY KEY,
    UsersID int not null 
        CONSTRAINT f_Users_Cookbook FOREIGN KEY REFERENCES Users(UsersID),
    Active bit not null,
    BookName varchar(30) not null 
        constraint u_Cookbook_BookName unique 
        CONSTRAINT ck_Cookbook_BookName_not_blank CHECK(BookName <> ''),
    Price decimal(6,2) not null 
        CONSTRAINT ck_Cookbook_Price_not_negative CHECK(Price > 0),
    DateCreated date not null 
        CONSTRAINT ck_Cookbook_DateCreated_not_in_future CHECK(DateCreated <= getdate()),
    CookbookPicture as concat('Cookbook-', replace(BookName, ' ', '-' ), '.jpg') PERSISTED
)
go 

create table dbo.BookRecipe(
    BookRecipeID int not null IDENTITY PRIMARY KEY,
    CookBookID int not null 
        CONSTRAINT f_Cookbook_BookRecipe FOREIGN KEY REFERENCES Cookbook(CookbookID),
    RecipeID int not null 
        CONSTRAINT f_Recipe_BookRecipe FOREIGN KEY REFERENCES Recipe(RecipeID),
    BookSequence int not null
        constraint ck_BookRecipe_BookSequence_not_negative CHECK(BookSequence > 0),
    CONSTRAINT u_BookRecipe_CookbookID_RecipeID unique(CookbookID, RecipeID)
)
go 

create table dbo.Meal(
    MealID int not null IDENTITY PRIMARY KEY,
    UsersID int not null
        CONSTRAINT f_User_Meal FOREIGN KEY REFERENCES users(UsersID),
    Active bit not null,
    DateCreated date not null,
    MealName varchar(30) unique 
        CONSTRAINT ck_Meal_MealName_not_blank CHECK(MealName <> ''),
    MealPicture as concat('Meal-', replace(MealName, ' ', '-' ), '.jpg') PERSISTED
)
go 
alter table Meal add MealDesc varchar(500) not null default ''
go

create table dbo.CourseType(
    CourseTypeID int not null IDENTITY PRIMARY KEY,
    CourseName varchar(15) not null
        CONSTRAINT u_CourseType_CourseName unique
        CONSTRAINT ck_CourseType_CourseName_not_blank CHECK(CourseName <> ''),
    CourseSequence int not null
        CONSTRAINT u_CourseType_CourseSequence UNIQUE
        CONSTRAINT ck_CourseType_CourseSequence_not_negative CHECK(CourseSequence > 0)
)
go 

create table dbo.Course(
    CourseID int not null IDENTITY PRIMARY KEY,
    MealID int not null 
        CONSTRAINT f_Meal_Course FOREIGN KEY REFERENCES Meal(MealID),
    CourseTypeID int not null
        CONSTRAINT f_CourseType_Course FOREIGN KEY REFERENCES CourseType(CourseTypeID),
    CONSTRAINT u_Course_MealID_CourseTypeID unique(CourseTypeID, MealID)
)
go 

create table dbo.RecipeCourse(
    RecipeCourseID int not null IDENTITY PRIMARY KEY,
    CourseID int not null 
        CONSTRAINT f_Course_RecipeCourse FOREIGN KEY REFERENCES Course(CourseID),
    RecipeID int not null 
        CONSTRAINT f_Recipe_RecipeCourse FOREIGN KEY REFERENCES Recipe(RecipeID),
    MainDish bit not null,
    CONSTRAINT u_RecipeCourse_CourseID_RecipeID unique(CourseID, RecipeID)
)
go 