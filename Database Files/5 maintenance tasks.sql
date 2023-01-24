
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

DELETE rc
--SELECT *
FROM Users u
join Meal m
on m.UserID = u.UserID
join Course c
on m.MealID = c.MealID
join RecipeCourse rc
on rc.CourseID = c.CourseID
where u.UserName = 'EdenHa'

DELETE c
--SELECT *
FROM Users u
join Meal m
on m.UserID = u.UserID
join Course c
on m.MealID = c.MealID
where u.UserName = 'EdenHa'

DELETE m
--SELECT *
FROM Users u
join Meal m
on m.UserID = u.UserID
where u.UserName = 'EdenHa'

DELETE br
--SELECT *
FROM Users u
join Cookbook c
on c.UserID = u.UserID
join BookRecipe br
on br.CookBookID = c.CookbookID
where u.UserName = 'EdenHa'

DELETE c
--SELECT *
FROM Users u
join Cookbook c
on c.UserID = u.UserID
where u.UserName = 'EdenHa'

DELETE i
--SELECT *
FROM Users u
join Recipe r
on r.UserID = u.UserID
join Instruction i
on i.RecipeID = r.RecipeID
where u.UserName = 'EdenHa'

DELETE ir
--SELECT *
FROM Users u
join Recipe r
on r.UserID = u.UserID
join IngredientRecipe ir
on ir.RecipeID = r.RecipeID
where u.UserName = 'EdenHa'

DELETE rc
--SELECT *
FROM Users u
join Recipe r
on r.UserID = u.UserID
join RecipeCourse rc
on rc.RecipeID = r.RecipeID
where u.UserName = 'EdenHa'

DELETE br
--SELECT *
FROM Users u
join Recipe r
on r.UserID = u.UserID
join BookRecipe br
on br.RecipeID = r.RecipeID
where u.UserName = 'EdenHa'

DELETE r
--SELECT *
FROM Users u
join Recipe r
on r.UserID = u.UserID
where u.UserName = 'EdenHa'

DELETE u
--SELECT *
FROM Users u
where u.UserName = 'EdenHa'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.

insert Recipe(UserID, CuisineID, RecipeName, Calories, DateCreated, DatePublished, DateArchived)
select r.UserID, r.CuisineID, CONCAT(r.RecipeName, ' - clone'), 390, GETDATE(), null, null FROM Recipe r WHERE r.RecipeName = 'Chocolate Chip Cookies'

insert IngredientRecipe(RecipeID, IngredientID, MeasurementTypeID, Amount, IngSequence)
select (select r.recipeid from Recipe r where r.RecipeName = 'Chocolate Chip Cookies - clone'), ir.IngredientID, ir.MeasurementTypeID, ir.amount, ir.IngSequence 
FROM IngredientRecipe ir 
join Recipe r
on r.RecipeID = ir.RecipeID
WHERE r.RecipeName = 'Chocolate Chip Cookies'

insert Instruction(RecipeID, InstructionStep, InstructionSequence)
select (select r.recipeid from Recipe r where r.RecipeName = 'Chocolate Chip Cookies - clone'), i.InstructionStep, i.InstructionSequence
from Instruction i
join Recipe r
on r.RecipeID = i.RecipeID
WHERE r.RecipeName = 'Chocolate Chip Cookies'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;with x as(
	SELECT NumOfRecipes = COUNT(r.RecipeID), u.UserID
	FROM Recipe r
	join Users u
	on u.UserID = r.UserID
	WHERE u.UserName = 'FA'
	group by u.UserID
)
INSERT Cookbook(UserID, Active, BookName, Price, DateCreated)
select u.UserID, 1, CONCAT('Recipes by ',u.FirstName, ' ', u.LastName), x.NumOfRecipes * 1.33, GETDATE()
from Users u 
join x
on x.UserID = u.UserID
WHERE u.UserName = 'FA'

insert BookRecipe(CookBookID, RecipeID, BookSequence)
SELECT c.CookbookID, r.RecipeID, ROW_NUMBER() over (order by r.RecipeName)
from Users u 
join Cookbook c
on c.UserID = u.UserID
join Recipe r
on r.UserID = u.UserID
WHERE u.UserName = 'FA'
and c.BookName = CONCAT('Recipes by ',u.FirstName, ' ', u.LastName)
order by r.RecipeName

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/

;with x as(
	select Ingredient = 'butter', AmountChangedPerOne = -2, MeasurementType = 'oz'
	union select 'butter', -10, 'stick'
)
UPDATE r
set r.Calories = r.Calories + x.AmountChangedPerOne * ir.Amount
--SELECT *
from recipe r
join IngredientRecipe Ir
on ir.recipeid = r.RecipeID
join Ingredient i
on i.IngredientID =ir.IngredientID
join MeasurementType mt
on mt.MeasurementTypeID = ir.MeasurementTypeID
join x 
on x.Ingredient = i.IngredientType
and x.MeasurementType = mt.MeasuringType
where i.IngredientType = 'butter'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/

;with y as(
	SELECT u.UserName, r.RecipeName, HoursInDratf = DATEDIFF(hour, r.DateCreated, GETDATE())
	FROM Users u
	join Recipe r
	on r.UserID = u.UserID
	WHERE r.RecipeStatus = 'draft'
),
x as(
	SELECT  AvgTimeToPublish = AVG(DATEDIFF(hour, r.DateCreated, r.DatePublished))
	FROM Recipe r
)
SELECT 
u.FirstName, 
u.LastName, 
EmailAdd = CONCAT(SUBSTRING(u.FirstName, 1, 1), u.LastName, '@heartyhearth.com'), 
Alert = CONCAT('Your recipe ', y.RecipeName,' is sitting in draft for ', y.HoursInDratf,' hours. That is ', y.HoursInDratf - x.AvgTimeToPublish,' hours more than the average ', x.AvgTimeToPublish,' hours all other recipes took to be published.')
FROM Users u
join y
on y.UserName = u.UserName
CROSS JOIN x

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/

;with x as(
	SELECT AmountOfBooks = COUNT(*), AvgPrice = AVG(c.Price), PriceForAll = SUM(c.Price) * 0.75
	FROM Cookbook c
)
SELECT EmailBody = CONCAT('Order cookbooks from HeartyHearth.com! We have ',x.AmountOfBooks,' books for sale, average price is ',x.AvgPrice,'. You can order them all and recieve a 25% discount, for a total of ',x.PriceForAll,'. 
Click <a href = "www.heartyhearth.com/order/', newid() ,'">here</a> to order.')
FROM x
