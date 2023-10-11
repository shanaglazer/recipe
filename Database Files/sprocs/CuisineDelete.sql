create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0)

	delete b 
	from RecipeCourse b
	join Recipe r
	on r.RecipeID = b.RecipeID
	where CuisineID = @CuisineId

	delete b 
	from BookRecipe b
	join Recipe r
	on r.RecipeID = b.RecipeID
	where CuisineID = @CuisineId

	delete i 
	from Instruction i
	join Recipe r
	on r.RecipeID = i.RecipeID
	where CuisineID = @CuisineId

	delete i 
	from IngredientRecipe i
	join Recipe r
	on r.RecipeID = i.RecipeID
	where CuisineID = @CuisineId
	
	delete Recipe where CuisineID = @CuisineId
	delete Cuisine where CuisineID = @CuisineId

	return @return
end
go
