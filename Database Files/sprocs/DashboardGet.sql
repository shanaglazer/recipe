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
		SELECT ItemType = 'recipes', CountItem = x.Recipes from x cross join y cross join z
		union select ItemType = 'meals', CountItem = y.Meals from x cross join y cross join z
		union select ItemType = 'cookbooks', CountItem = z.Cookbooks from x  cross join y cross join z

	return @return
end
go

--exec DashboardGet

