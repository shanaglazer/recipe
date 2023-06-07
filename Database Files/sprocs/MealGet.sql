use HeartyHearthDB
go

create or alter proc dbo.MealGet(@message varchar(500) = '' output)
as 
begin

	declare @return int = 0

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
		on u.UsersID = m.UsersID
		join z 
		on z.MealID = m.MealID
		WHERE m.Active = 1
		order by m.MealName

	return @return

end
go

exec MealGet