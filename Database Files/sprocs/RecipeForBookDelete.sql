use HeartyHearthDB 
go

create or alter procedure dbo.BookRecipeDelete(
	@BookRecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @BookRecipeId = isnull(@BookRecipeId,0)

	delete BookRecipe where BookRecipeID = @BookRecipeId

	return @return
end
go
