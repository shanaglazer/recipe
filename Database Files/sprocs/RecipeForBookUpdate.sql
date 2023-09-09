use HeartyHearthDB
go

create or alter procedure dbo.RecipeForBookUpdate(
	@BookRecipeId int  output,
	@CookbookId int ,
	@RecipeId int ,
	@BookSequence int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @BookRecipeId = isnull(@BookRecipeId,0)

	if @BookRecipeId = 0
	begin
		insert BookRecipe(CookbookId, RecipeID, BookSequence)
		values(@CookbookId, @RecipeId, @BookSequence)

		select @BookRecipeId= scope_identity()
	end
	else
	begin
		update BookRecipe
		set
			CookBookID = @CookbookId,
			recipeid = @RecipeId, 
			BookSequence = @BookSequence
		where BookRecipeId = @BookRecipeId
	end

	return @return
end
go
--select * from BookRecipe
