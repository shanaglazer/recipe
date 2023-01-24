/*

User
    UserID int not null PK
    FirstName varchar(30) not null NB
    LastName varchar(30) not null NB
    UserNum int not null unique
  
Cuisine
    CuisineID int not null PK
    CuisineType varchar(30) not null unique NB

Recipe
    RecipeID int not null PK
    UserID int not null FK
    CuisineID int not null FK
    RecipeName varchar(50) not null unique NB
    Calories int not null >0 
    DateCreated date not null
    DatePublished date null
    DateArchived date null
    DateCreated > DatArchived
    DateCreated > DatetPublished 
    RecipeStatus computed column

 
IngredientName
    IngredientNameID int not null pk
    IngredientType varchar(25) not null NB

MeasurementType
    MeasurementTypeID int not null PK
    MeasuringType varchar(10) not null NB


Ingredient
    IngredientID int not null PK
    RecipeID int not nul FK
    IngredientNameID int not null FK
    MeasurementTypeID FK 
    Amount int not null >0 
    IngSequence int not null unique > 0 
    Name + RecipeID = unique

Instruction
    InstructionID int not null PK
    RecipeID int not null FK
    InstructionStep varchar(150) not null NB
    InstructionSequence int not null 
    RecipeID + InstructionStep = unique
    InstructionSequence + RecipeID = unique

Cookbook 
    CookbookID int not null PK
    UserID int not null FK
    Active bit not null 
    BookName varchar(30) not null unique NB
    Price decimal(6,2) not null > 0 

BookRecipe
    BookRecipeID int not null PK
    CookBookID int not null FK
    RecipeID int not null FK
    BookSequence int not null unique
    CookBookID + RecipeID = unique

Meal
    MealID int not null PK
    UserID int not null FK
    Active bit not null
    DateCreated date not null
    MealName varchar(30) unique NB
    MealPicture Meal-MealName.jpg

CourseType
    CourseTypeID int not null PK
    CourseName varchar(15) not null NB unique

Course
    CourseID int not null PK
    MealID int not null FK
    CourseTypeID int not null FK
    CourseSequence int not null unique
    MealID + CourseTypeID = unique

RecipeCourse
    RecipeCourseID int not null PK
    CourseID int not null FK
    RecipeID int not null FK
    MainDish bit null 
    CourseID + RecipeID = unique

*/