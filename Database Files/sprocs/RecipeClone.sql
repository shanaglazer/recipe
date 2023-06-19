use HeartyHearthDB 
go

create or alter proc dbo.RecipeClone(
	@RecipeName varchar(100) = '' output,
	@Message varchar(500) = ''  output)
as
begin

	declare @return int = 0

	select @RecipeName = isnull(@RecipeName, '')

	insert Recipe(UsersID, CuisineID, RecipeName, Calories, DateCreated, DatePublished, DateArchived)
	select r.UsersID, r.CuisineID, CONCAT(r.RecipeName, ' - clone'), r.Calories, GETDATE(), null, null FROM Recipe r WHERE r.RecipeName = @RecipeName
	
	insert IngredientRecipe(RecipeID, IngredientID, MeasurementTypeID, Amount, IngSequence)
	select (select r.recipeid from Recipe r where r.RecipeName = concat(@RecipeName, ' - clone')), ir.IngredientID, ir.MeasurementTypeID, ir.amount, ir.IngSequence 
	FROM IngredientRecipe ir 
	join Recipe r
	on r.RecipeID = ir.RecipeID
	WHERE r.RecipeName = @RecipeName
	
	insert Instruction(RecipeID, InstructionStep, InstructionSequence)
	select (select r.recipeid from Recipe r where r.RecipeName = concat(@RecipeName, ' - clone')), i.InstructionStep, i.InstructionSequence
	from Instruction i
	join Recipe r
	on r.RecipeID = i.RecipeID
	WHERE r.RecipeName = @RecipeName

	return @return

end
go
