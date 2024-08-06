use HeartyHearthDB
go

create or alter proc dbo.RecipeSummaryGet(@message varchar(500) = '' output)
as 
begin

	select r.RecipeID, r.RecipeName, r.RecipeStatus, UserName = concat(u.FirstName, ' ', u.LastName), r.Calories, NumOfIng = COUNT(ir.IngredientID)
	from Recipe r
	join Users u
	on u.UsersID = r.UsersID
	left join IngredientRecipe ir
	on ir.RecipeID = r.RecipeID
	group by r.RecipeID, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories
	order by r.RecipeStatus desc, r.RecipeName

end
go



--select *
--from Recipe r
--join IngredientRecipe i
--on i.RecipeID = r.RecipeID
--where r.RecipeName = 'Grilled Chicken'