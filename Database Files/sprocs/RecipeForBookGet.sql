use HeartyHearthDB
go

create or alter proc dbo.RecipeForBookGet(
	--@CookbookId int = 0,
	@BookName varchar(80),
	@message varchar(500) = '' output)
as 
begin

	declare @return int = 0

		--isnull

		select r.RecipeName, b.BookSequence
		from Cookbook c
		join BookRecipe b
		on b.CookBookID = c.CookbookID
		join Recipe r
		on r.RecipeID = b.RecipeID
		where c.BookName = @BookName
		order by b.BookSequence

	return @return

end
go