/*
Home Page
    One resultset with number of recipes, meals, and cookbooks
*/
;with 
x as(
SELECT Recipes = COUNT(*)
FROM Recipe r
),
y as(
    SELECT Meals = COUNT(*)
    FROM Meal m
),
z as(
    SELECT Cookbooks = COUNT(*)
    FROM Cookbook c
)
SELECT *
from x
cross join y
cross join z

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
*/
;with x as(
    SELECT NumOfIng = COUNT(ir.IngredientID), r.RecipeID
    from IngredientRecipe ir
    join Recipe r
    on r.RecipeID = ir.RecipeID
    group by r.RecipeID
)
SELECT RecipeName = case
when r.RecipeStatus = 'Archive' then CONCAT('<span style="color:gray">', r.RecipeName, '</span>')
else r.RecipeName
end, 
r.RecipeStatus, DatePublished = isnull(convert(VARCHAR, r.DatePublished), ''), DateArchived = isnull(convert(varchar, r.DateArchived), ''), u.UserName, r.Calories, x.NumOfIng
from Recipe r
join Users u
on u.UserID = r.UserID
join x
on x.RecipeID = r.RecipeID
WHERE r.RecipeStatus in('Archive', 'on site')
order by r.RecipeStatus desc

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a
;with x as(
    SELECT NumOfIng = COUNT(ir.IngredientID), r.RecipeID
    from IngredientRecipe ir
    join Recipe r
    on r.RecipeID = ir.RecipeID
    group by r.RecipeID
),
y as(
    SELECT NumOfSteps = COUNT(i.InstructionID), r.RecipeID
    from Instruction i
    join Recipe r
    on r.RecipeID = i.RecipeID
    group by r.RecipeID 
)
SELECT r.RecipeName, r.Calories, x.NumOfIng, x.NumOfIng, y.NumOfSteps, Picture = concat('Recipe-', REPLACE(r.RecipeName, ' ', '-'), '.jpg')
from Recipe r
join Users u
on u.UserID = r.UserID
join x
on x.RecipeID = r.RecipeID
join y
on y.RecipeID = r.RecipeID
WHERE r.RecipeName = 'Chocolate Chip Cookies'
--b 
SELECT Ingredients = concat(ir.Amount, ' ', mt.MeasuringType,' ', i.IngredientType), Picture = concat('Ingredient-', REPLACE(i.IngredientType, ' ', '-'), '.jpg')
FROM IngredientRecipe ir
join Ingredient I
on i.IngredientID = ir.IngredientID
join Recipe r
on r.RecipeID = ir.RecipeID
join MeasurementType mt
on mt.MeasurementTypeID = ir.MeasurementTypeID
WHERE r.RecipeName = 'Chocolate Chip Cookies'
order by ir.IngSequence
--c
SELECT i.InstructionStep
from Instruction i
join Recipe r
on r.RecipeID = i.RecipeID
WHERE r.RecipeName = 'Chocolate Chip Cookies'
order by i.InstructionSequence
/*
Meal list page:
    All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
;with x as(
    SELECT Calories = SUM(r.Calories), m.MealID
    from Recipe r
    join RecipeCourse rc
    on rc.RecipeID = r.RecipeID
    join Course c
    on c.CourseID = rc.CourseID
    join meal m
    on m.MealID = c.MealID
    WHERE m.Active = 1
    group by m.MealID
),
y as(
    SELECT NumOfCourses = COUNT(c.CourseID), m.MealID
    FROM Course c
    join meal m
    on m.MealID = c.MealID
    group by m.MealID
),
z as(
    SELECT NumOfRecipes = COUNT(rc.RecipeID), m.MealID
    from RecipeCourse rc
    join Course c
    on c.CourseID = rc.CourseID
    join meal m
    on m.MealID = c.MealID
    WHERE m.Active = 1
    group by m.MealID
)
SELECT m.MealName, u.UserName, x.Calories, y.NumOfCourses, z.NumOfRecipes
FROM x
join Meal m
on x.MealID = m.MealID
join y
on y.MealID = m.MealID
join Users u
on u.UserID = m.UserID
join z 
on z.MealID = m.MealID
WHERE m.Active = 1
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes. 
            Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/

SELECT m.MealName, u.UserName, m.DateCreated, Picture = concat('Meal-', REPLACE(m.MealName, ' ', '-'), '.jpg')
FROM Meal m
join Users u
on u.UserID = m.UserID
WHERE m.MealName = 'Breakfast bash'

;with x as(
    SELECT Dish =
    case rc.MainDish
    when 1 then 'Main dish'
    else 'Side dish'
    end, 
    rc.RecipeCourseID
    FROM RecipeCourse rc
)
SELECT 
Recipes = 
case x.dish
when 'Main dish' then CONCAT('<b>',ct.CourseName, ': ', x.dish, ' - ', r.RecipeName, '.','</b>')
else CONCAT(ct.CourseName, ': ', x.dish, ' - ', r.RecipeName, '.')
end,
Picture = concat('Recipe-', REPLACE(r.RecipeName, ' ', '-'), '.jpg')
FROM Recipe r
join RecipeCourse rc
on rc.RecipeID = r.RecipeID
join Course c
on c.CourseID = rc.CourseID
join CourseType ct
on ct.CourseTypeID = c.CourseTypeID
join Meal m
on m.MealID = c.MealID
join x
on x.RecipeCourseID = rc.RecipeCourseID
WHERE m.MealName = 'Breakfast bash'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/

;with x as(
    SELECT NumOfRecipes = COUNT(br.RecipeID), br.CookBookID
    FROM BookRecipe br
    group by br.CookBookID
)
SELECT c.BookName, Author = concat(u.firstname, ' ', u.lastname), x.NumOfRecipes
FROM Cookbook c
join users u
on u.userid = c.userid
join x 
on x.CookBookID = c.CookBookID
WHERE c.Active = 1
order by c.BookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.
*/

;with x as(
    SELECT NumOfRecipes = COUNT(br.RecipeID), br.CookBookID
    FROM BookRecipe br
    join Cookbook c
    on c.CookBookID = br.CookBookID
    WHERE c.BookName = 'Cook a Storm'
    group by br.CookBookID
)
SELECT c.BookName, u.UserName, c.DateCreated, c.Price, x.NumOfRecipes
FROM Cookbook c
join users u
on u.userid = c.userid
join x 
on x.CookBookID = c.CookBookID
WHERE c.BookName = 'Cook a Storm'

;with x as(
    SELECT NumOfIng = COUNT(i.IngredientID), ir.recipeid
    FROM ingredient i
    join IngredientRecipe ir
    on i.IngredientID = ir.IngredientID
    group by ir.recipeid
),
y as(
    SELECT NumOfSteps = COUNT(i.InstructionStep), r.RecipeID
    FROM Instruction i
    join Recipe r
    on i.RecipeID = r.RecipeID
    group by r.recipeid
)
SELECT r.RecipeName, c.CuisineType, x.NumOfIng, y.NumOfSteps
FROM recipe r
join Cuisine c 
on c.Cuisineid = r.Cuisineid
join BookRecipe br
on br.recipeid = r.recipeid
join Cookbook cb
on cb.Cookbookid = br.Cookbookid
join x 
on x.recipeid = r.recipeid
join y 
on y.RecipeID = r.RecipeID
WHERE cb.BookName = 'Cook a Storm'
order by br.BookSequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
    b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system
*/

SELECT RecipeName =  concat(substring(upper(reverse(r.RecipeName)),1 ,1), substring(lower(reverse(r.RecipeName)),2 ,1000)), 
Picture = CONCAT('Recipe-', replace(concat(substring(upper(reverse(r.RecipeName)),1 ,1), substring(lower(reverse(r.RecipeName)),2 ,1000)), ' ', '-'), '.jpg')
FROM recipe r
join BookRecipe br
on br.RecipeID = r.RecipeID

;with x as(
    SELECT InstructionSequence = MAX(InstructionSequence), i.RecipeID
    FROM Instruction i
    group by i.RecipeID
)
SELECT i.IngredientType, ic.InstructionStep
FROM Ingredient i
join IngredientRecipe ir
on i.Ingredientid = ir.Ingredientid
join Instruction ic
on ic.RecipeID = ir.RecipeID
join x
on x.RecipeID = ic.RecipeID
and x.InstructionSequence = ic.InstructionSequence
WHERE ir.IngSequence = 1

/*
For site administration page:
--5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if none
	b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) List of how many meals each user created and whether they're active or inactive. Show 0 if none
    d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a
SELECT u.UserName, AmountOfRecipes = COUNT(r.RecipeID), r.RecipeStatus
FROM users u
left join recipe r
on u.userid = r.userid
GROUP BY u.UserName, r.RecipeStatus
order by u.UserName
--b
SELECT u.UserName, AmountOfRecipes = COUNT(r.RecipeID), AvgDaysForPub = avg(datediff(day, r.DateCreated, r.DatePublished))
FROM users u
left join recipe r
on u.userid = r.userid
GROUP BY u.UserName
order by u.UserName
--c
SELECT u.UserName, AmountOfMeals = COUNT(m.MealID), m.active
FROM users u
left join Meal m
on u.userid = m.userid
GROUP BY u.UserName, m.active
order by u.UserName
--d
SELECT u.UserName, AmountOfCookbooks = COUNT(c.CookbookID), c.active
FROM users u
left join Cookbook c
on u.userid = c.userid
GROUP BY u.UserName, c.active
order by u.UserName
--e 
SELECT r.RecipeName, DaysTookToArchive = DATEDIFF(day, r.DateCreated, r.DateArchived)
FROM recipe r
WHERE r.DatePublished is null and r.DateArchived is not null
/*
For user dashboard page:
    a) Show number of the user's recipes, meals and cookbooks. 
    b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
    c) Count of their recipes per cuisine. Show 0 for none.
*/

SELECT u.UserName, Recipes = COUNT(r.RecipeID), Meals = COUNT(m.MealID), Cookbook = COUNT(c.CookbookID)
FROM users u
left join recipe r
on r.userid = u.userid
left join meal m
on m.userid = u.userid
left join cookbook c
on c.userid = u.userid
group by u.UserName
order by u.UserName

SELECT u.UserName, r.RecipeName, r.RecipeStatus, HoursInStatus = case 
    when r.RecipeStatus = 'Draft' then null 
    when r.RecipeStatus = 'on site' then DATEDIFF(hour, r.DateCreated, r.DatePublished)
    when r.RecipeStatus = 'Archive' then DATEDIFF(hour, isnull(r.DatePublished, r.DateCreated), r.DateArchived)
    end
FROM users u
left join recipe r
on r.userid = u.userid
order by u.UserName

SELECT u.userid, NumOfRecipes = COUNT(r.RecipeID), c.CuisineType
FROM users u
left join recipe r
on u.userid = r.userid
left join cuisine c
on c.CuisineID = r.CuisineID
group by c.CuisineType, u.userid