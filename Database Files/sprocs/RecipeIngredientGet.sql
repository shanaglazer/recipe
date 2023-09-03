use HeartyHearthDB
go

create or alter proc dbo.IngredientRecipeGet(
	@IngredientRecipeId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
	)
as
begin

	declare @return int = 0

	select @IngredientRecipeId = isnull(@IngredientRecipeId, 0), @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0)

	select 
		ir.IngredientRecipeID, 
		ir.RecipeID, 
		ir.IngredientID, 
		ir.MeasurementTypeID, 
		ir.Amount,  
		ir.IngSequence
	from IngredientRecipe ir
	where ir.RecipeID = @RecipeId
	or ir.ingredientRecipeId = @IngredientRecipeId
	or @All = 1

	return @return

end
go
exec IngredientRecipeGet

