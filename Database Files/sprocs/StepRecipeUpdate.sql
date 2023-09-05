use HeartyHearthDB
go

create or alter procedure dbo.StepRecipeUpdate(
	@IngredientRecipeId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@MeasurementTypeId varchar(30),
	@Amount decimal,
	@IngSequence int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientRecipeId = isnull(@IngredientRecipeId,0)

	if @IngredientRecipeId = 0
	begin
		insert IngredientRecipe(RecipeID, IngredientID, MeasurementTypeID, Amount, IngSequence)
		values(@RecipeId, @IngredientId, @MeasurementTypeId, @Amount, @IngSequence)

		select @IngredientRecipeId= scope_identity()
	end
	else
	begin
		update IngredientRecipe
		set
			recipeid = @RecipeId, 
			IngredientID =  @IngredientId,
			MeasurementTypeID = @MeasurementTypeId,
			Amount = @Amount,
			IngSequence = @IngSequence
		where IngredientRecipeId = @IngredientRecipeId
	end

	return @return
end
go
--select * from IngredientRecipe
