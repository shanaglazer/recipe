use HeartyHearthDB
go

create or alter proc dbo.RecipeIngredientGet(
	@IngredientRecipeId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
	)
as
begin

	declare @return int = 0

	select *
	from IngredientRecipe ir

	return @return

end
go
exec RecipeIngredientGet

select * from IngredientRecipe