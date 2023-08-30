create or alter procedure dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0)

	delete b
	from BookRecipe b
	where b.CookBookID = @CookbookId

	delete c
	from Cookbook c
	where c.CookbookID = @CookbookId

	return @return
end
go
