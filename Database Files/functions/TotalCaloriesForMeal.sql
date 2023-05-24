use HeartyHearthDB
go

create or alter function dbo.TotalCaloriesForMeal(@MealId int)
returns int
as 
begin
	
	declare @return int = 0

	SELECT @return = SUM(r.Calories)
    from Recipe r
    join RecipeCourse rc
    on rc.RecipeID = r.RecipeID
    join Course c
    on c.CourseID = rc.CourseID
    join meal m
    on m.MealID = c.MealID
    WHERE m.MealID = @MealId
	
	return @return

end
go

select dbo.TotalCaloriesForMeal(m.MealID), * from Meal m
