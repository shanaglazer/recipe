
use heartyhearthDB
go 

delete RecipeCourse
delete Course
delete CourseType
delete Meal
delete BookRecipe
delete Cookbook
delete Instruction
delete IngredientRecipe
delete MeasurementType
delete Ingredient
delete Recipe
delete users 
delete cuisine

insert users(FirstName, LastName, UserName)
select 'Eden', 'Harary', 'EdenHa'
union select 'Shir', 'Perel', 'sp123'
union select 'Efrat', 'Libfroind', 'LibfroindE'
union select 'Adina', 'First', 'FA'
union select 'Michal', 'Hofman', 'MichalHofman'

insert Cuisine(CuisineType)
select 'American'
union select 'Israeli'
union select 'French'
union select 'English'
union select 'Asian'
union select 'Chinese'

insert Recipe(UsersID, CuisineID, RecipeName, Calories, DateCreated, DatePublished, DateArchived)
select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'American'), 'Chocolate Chip Cookies', 390, '05-09-2017', '05-28-2017', null FROM Users u WHERE u.UserName = 'sp123'
union select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'French'), 'Apple Yogurt Smoothie', 165, '12-12-2020', null, null FROM Users u WHERE u.UserName = 'EdenHa'
union select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'English'), 'Cheese Bread', 99, '07-13-21', null, '08-24-21' FROM Users u WHERE u.UserName = 'MichalHofman'
union select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'American'), 'Butter Muffins', 240, '05-09-2017', '05-28-2017', null FROM Users u WHERE u.UserName = 'LibfroindE'
union select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'Asian'), 'Grilled Chicken', 50, '11-14-2018', '11-28-2018', '04-13-2020' FROM Users u WHERE u.UserName = 'FA'
union select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'Israeli'), 'Shawarma', 120, '07-26-2020', '08-15-2020', null FROM Users u WHERE u.UserName = 'FA'
union select u.UsersID, (select c.CuisineID from Cuisine c where c.CuisineType = 'Chinese'), 'Rice with Chili sauce', 180, '05-09-2017', '05-28-2017', null FROM Users u WHERE u.UserName = 'EdenHa'

insert Ingredient(IngredientType)
select 'Flour'
union select 'Sugar'
union select 'Salt'
union select 'black pepper'
union select 'oil'
union select 'egg'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apple'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic (crushed)'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'Chicken'
union select 'Shawarma Meat'
union select 'Paprika'
union select 'turmeric'
union select 'Rice'
union select 'chili sauce'
union select 'garlic powder'
union select 'onion'
union select 'sliced almonds'
union select 'sesemi seeds'
union select 'water'

insert MeasurementType(MeasuringType)
select 'cup'
union select 'tsp'
union select 'tbsp'
union select 'club'
union select 'oz'
union select 'cloves'
union select 'pinch'
union select 'stick'
union select 'kilo'
union select 'gram'

;with x as(
    SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'sugar', MeasurementType = 'cup', amount = 1, IngSequence = 1
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'oil', MeasurementType = 'cup', 0.5, 2
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'egg', MeasurementType = 'cup', 3, 3
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'Flour', MeasurementType = 'cup', 2, 4
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'vanilla sugar', MeasurementType = 'tsp', 1, 5
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'baking powder', MeasurementType = 'tsp', 2, 6
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'baking soda', MeasurementType = 'tsp', 0.5, 7
    union SELECT Recipe = 'Chocolate Chip Cookies', Ingredient = 'chocolate chips', MeasurementType = 'cup', 1, 8
    union SELECT Recipe = 'Apple Yogurt Smoothie', Ingredient = 'granny smith apple', MeasurementType = '', 3, 1
    union SELECT Recipe = 'Apple Yogurt Smoothie', Ingredient = 'vanilla yogurt', MeasurementType = 'cup', 2, 2
    union SELECT Recipe = 'Apple Yogurt Smoothie', Ingredient = 'sugar', MeasurementType = 'tsp', 2, 3
    union SELECT Recipe = 'Apple Yogurt Smoothie', Ingredient = 'orange juice', MeasurementType = 'cup', 0.5, 4
    union SELECT Recipe = 'Apple Yogurt Smoothie', Ingredient = 'honey', MeasurementType = 'tbsp', 2, 5
    union SELECT Recipe = 'Apple Yogurt Smoothie', Ingredient = 'ice cubes', MeasurementType = '', 5, 6
    union SELECT Recipe = 'Cheese Bread', Ingredient = 'bread', MeasurementType = 'club', 1, 1
    union SELECT Recipe = 'Cheese Bread', Ingredient = 'butter', MeasurementType = 'oz', 4, 2
    union SELECT Recipe = 'Cheese Bread', Ingredient = 'shredded cheese', MeasurementType = 'oz', 8, 3
    union SELECT Recipe = 'Cheese Bread', Ingredient = 'garlic (crushed)', MeasurementType = 'cloves', 2, 4
    union SELECT Recipe = 'Cheese Bread', Ingredient = 'black pepper', MeasurementType = 'tsp', 0.25, 5
    union SELECT Recipe = 'Cheese Bread', Ingredient = 'salt', MeasurementType = 'pinch', 1, 6
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'butter', MeasurementType = 'stick', 1, 1
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'sugar', MeasurementType = 'cup', 3, 2
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'vanilla pudding', MeasurementType = 'tsp', 2, 3
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'egg', MeasurementType = '', 4, 4
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'whipped cream cheese', MeasurementType = 'oz', 8, 5
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'sour cream cheese', MeasurementType = 'oz', 8, 6
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'flour', MeasurementType = 'cup', 1, 7
    union SELECT Recipe = 'Butter Muffins', Ingredient = 'baking powder', MeasurementType = 'tsp', 2, 8
    union SELECT Recipe = 'Grilled Chicken', Ingredient = 'chicken', MeasurementType = 'kilo', 1, 1
    union SELECT Recipe = 'Grilled Chicken', Ingredient = 'salt', MeasurementType = 'tsp', 0.75, 2
    union SELECT Recipe = 'Grilled Chicken', Ingredient = 'black pepper', MeasurementType = 'tsp', 0.125, 3
    union SELECT Recipe = 'Grilled Chicken', Ingredient = 'Paprika', MeasurementType = 'tsp', 1, 4
    union SELECT Recipe = 'Grilled Chicken', Ingredient = 'garlic powder', MeasurementType = 'tsp', 1, 5
    union SELECT Recipe = 'Shawarma', Ingredient = 'Shawarma Meat', MeasurementType = 'gram', 500, 1
    union SELECT Recipe = 'Shawarma', Ingredient = 'onion', MeasurementType = '', 1, 2
    union SELECT Recipe = 'Shawarma', Ingredient = 'turmeric', MeasurementType = 'tsp', 1, 3
    union SELECT Recipe = 'Shawarma', Ingredient = 'salt', MeasurementType = 'tsp', 0.5, 4
    union SELECT Recipe = 'Rice with Chili sauce', Ingredient = 'rice', MeasurementType = 'cup', 1, 1
    union SELECT Recipe = 'Rice with Chili sauce', Ingredient = 'water', MeasurementType = 'cup', 2, 2
    union SELECT Recipe = 'Rice with Chili sauce', Ingredient = 'salt', MeasurementType = 'tsp', 0.5, 3
    union SELECT Recipe = 'Rice with Chili sauce', Ingredient = 'chili sauce', MeasurementType = 'tbsp', 1, 4
    union SELECT Recipe = 'Rice with Chili sauce', Ingredient = 'sliced almonds', MeasurementType = 'tbsp', 1, 5
    union SELECT Recipe = 'Rice with Chili sauce', Ingredient = 'sesemi seeds', MeasurementType = 'tsp', 1, 6
)
insert IngredientRecipe(RecipeID, IngredientID, MeasurementTypeID, Amount, IngSequence)
select r.recipeid, i.IngredientID, m.MeasurementTypeID, x.amount, x.IngSequence
from x
join Recipe r
on r.RecipeName = x.Recipe
join Ingredient i
on i.IngredientType = x.Ingredient
join MeasurementType m
on m.MeasuringType = x.MeasurementType

;with y as(
select Recipe = 'Chocolate Chip Cookies', Step = 'First combine sugar, oil and eggs in a bow', Seq = 1
union select 'Chocolate Chip Cookies', 'mix well', 2
union select 'Chocolate Chip Cookies', 'add flour, vanilla sugar, baking powder and baking soda', 3
union select 'Chocolate Chip Cookies', 'beat for 5 minutes', 4
union select 'Chocolate Chip Cookies', 'add chocolate chips', 5
union select 'Chocolate Chip Cookies', 'freeze for 1-2 hours', 6
union select 'Chocolate Chip Cookies', 'roll into balls and place spread out on a cookie sheet', 7
union select 'Chocolate Chip Cookies', 'bake on 350 for 10 min', 8
union select 'Apple Yogurt Smoothie', 'Peel the apples and dice', 1
union select 'Apple Yogurt Smoothie', 'Combine all ingredients in bowl except for apples and ice cubes', 2
union select 'Apple Yogurt Smoothie', 'mix until smooth', 3
union select 'Apple Yogurt Smoothie', 'add apples and ice cubes', 4
union select 'Apple Yogurt Smoothie', 'pour into glasses', 5
union select 'Cheese Bread', 'Slit bread every 3/4 inch', 1
union select 'Cheese Bread', 'Combine all ingredients in bowl', 2
union select 'Cheese Bread', 'fill slits with cheese mixture', 3
union select 'Cheese Bread', 'wrap bread into a foil and bake for 30 minutes', 4
union select 'Butter Muffins', 'Cream butter with sugars', 1
union select 'Butter Muffins', 'Add eggs and mix well', 2
union select 'Butter Muffins', 'Slowly add rest of ingredients and mix well', 3
union select 'Butter Muffins', 'fill muffin pans 3/4 full and bake for 30 minutes', 4
union select 'Grilled Chicken', 'Clean the chicken', 1
union select 'Grilled Chicken', 'Sprinkle the spices over the chicken', 2
union select 'Grilled Chicken', 'Bake in the oven on grill mode for 30 minutes', 3
union select 'Shawarma', 'Fry the onion until golden', 1
union select 'Shawarma', 'Add the meat and wait until it looks cooked', 2
union select 'Shawarma', 'add spices mix and keep on the flame for 5 more minutes', 3
union select 'Rice with Chili sauce', 'Put rice, water, salt and chilli in a pan', 1
union select 'Rice with Chili sauce', 'Mix well', 2
union select 'Rice with Chili sauce', 'Put in the oven at 180 Celsius for an hour', 3
union select 'Rice with Chili sauce', 'Sprinkle sesame seeds and almonds over the rice', 4
)
insert Instruction(RecipeID, InstructionStep, InstructionSequence)
select r.RecipeID, y.Step, y.Seq
from y
join Recipe r
on r.RecipeName = y.Recipe 

;with z as(
    select UserName = 'EdenHa', Active = 1, BName = 'Treats for two', Price = 30.00, DateCreated = '07-20-21'
    union select 'LibfroindE', 0, 'Mom''s Kitchen', 61.00, '3-14-22'
    union select 'FA', 1, 'Cook a Storm', 25.99, '09-25-21'
    union select 'MichalHofman', 1, 'In the pot', 42.00, '05-21-22'
)
INSERT Cookbook(UsersID, Active, BookName, Price, DateCreated)
select u.UsersID, z.Active, z.BName, z.Price, z.DateCreated
FROM z
join Users u
on u.UserName = z.UserName

;with x as(
    SELECT Cookbook = 'Treats for two', Recipe = 'Chocolate Chip Cookies', BookSequence = 1
    UNION SELECT 'Treats for two', 'Apple Yogurt Smoothie', 2
    UNION SELECT 'Treats for two', 'Cheese Bread', 3
    UNION SELECT 'Mom''s Kitchen', 'Grilled Chicken', 1
    UNION SELECT 'Mom''s Kitchen', 'Rice with Chili sauce', 2
    UNION SELECT 'Cook a Storm', 'Shawarma', 1
    UNION SELECT 'In the pot', 'Butter Muffins', 1
)
insert BookRecipe(CookBookID, RecipeID, BookSequence)
SELECT c.CookbookID, r.RecipeID, x.BookSequence
FROM x
join Cookbook c
on c.BookName = x.Cookbook
join Recipe r
on r.RecipeName = x.Recipe

;with x as(
    select UserN = 'sp123', Active = 1, DateCreated = '10-10-21', MealName = 'Breakfast bash'
    union select 'EdenHa', 1, '06-28-21', 'Best Supper'
    union select 'FA', 0, '12-5-20', 'Best Brunch'
    union select 'LibfroindE', 0, '04-07-19', 'Easy Lunch'
)
insert Meal(UsersID, Active, DateCreated, MealName)
SELECT u.UsersID, x.Active, x.DateCreated, x.MealName
FROM x
join Users u
on u.UserName = x.UserN

insert CourseType(CourseName, CourseSequence)
select 'Main course', 3
union select 'Appetizer', 1
union select 'First Course', 2
union select 'Dessert', 4

;with x as(
    SELECT Meal = 'Breakfast bash', Course = 'Main course'
    UNION SELECT 'Breakfast bash', 'Appetizer'
    UNION SELECT 'Best Supper', 'Main course'
    UNION SELECT 'Best Supper', 'Dessert'
    UNION SELECT 'Best Brunch', 'Appetizer'
    UNION SELECT 'Best Brunch', 'Main course'
    UNION SELECT 'Best Brunch', 'Dessert'
    UNION SELECT 'Easy Lunch', 'Main course'
)
insert Course(MealID, CourseTypeID)
select m.MealID, c.CourseTypeID
from x
join Meal m
on m.MealName = x.Meal
join CourseType c
on c.CourseName = x.Course

;with x as(
    select MealName = 'Breakfast bash', CourseType = 'Main course', RecipeName = 'Cheese Bread', Main = 1
    union select 'Breakfast bash', 'Main course', 'Butter Muffins', 0
    union select 'Breakfast bash', 'Appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Best Supper', 'Main course', 'Grilled Chicken', 1
    union select 'Best Supper', 'Main course', 'Rice with Chili sauce', 0
    union select 'Best Supper', 'Dessert', 'Chocolate Chip Cookies', 0
    union select 'Best Brunch', 'Appetizer', 'Butter Muffins', 0
    union select 'Best Brunch', 'Main course', 'Cheese Bread', 1
    union select 'Best Brunch', 'Dessert', 'Apple Yogurt Smoothie', 0
    UNION SELECT 'Easy Lunch', 'Main course', 'Shawarma', 1
)
insert RecipeCourse(CourseID, RecipeID, MainDish)
select c.CourseID, r.RecipeID, x.Main
FROM x
join recipe r
on r.RecipeName = x.RecipeName
join CourseType ct
on ct.CourseName = x.CourseType
join Course c
on c.CourseTypeID = ct.CourseTypeID
join Meal m
on m.MealID = c.MealID
and m.MealName = x.MealName