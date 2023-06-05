use HeartyHearthDB
go

create or alter proc dbo.DashboardGet(@message varchar(500) = '' output)
as
begin
	declare @return int = 0


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
		SELECT RecipesNumber = x.Recipes, MealsNumber = y.Meals, CookbooksNumber = z.Cookbooks
		from x
		cross join y
		cross join z

	return @return
end
go

exec DashboardGet

