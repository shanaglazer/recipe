create or alter procedure dbo.IngredientRecipeUpdate(
	@IngredientRecipeId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@MeasuringType varchar(30),
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
		values(@RecipeId, @IngredientId, (select MeasurementTypeId from MeasurementType where MeasuringType = @MeasuringType), @Amount, @IngSequence)

		select @IngredientRecipeId= scope_identity()
	end
	else
	begin
		update IngredientRecipe
		set
			recipeid = @RecipeId, 
			IngredientID =  @IngredientId,
			MeasurementTypeID = (select MeasurementTypeId from MeasurementType where MeasuringType = @MeasuringType),
			Amount = @Amount,
			IngSequence = @IngSequence
		where IngredientRecipeId = @IngredientRecipeId
	end

	return @return
end
go

