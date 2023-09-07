--recipe grid in the cookbook page
use HeartyHearthDB
go

create or alter proc dbo.RecipeForBookGet(
	@CookbookId int = 0,
	--@BookName varchar(80),
	@All bit = 0,
	@IncludeBlank  bit = 0,
	@message varchar(500) = '' output)
as 
begin

	declare @return int = 0

		--isnull

		select r.RecipeID, r.RecipeName, b.BookSequence
		from BookRecipe b
		join Recipe r 
		on b.RecipeID = r.RecipeID
		where b.CookBookID = @CookbookId
		union select 0, '', 0
		where @IncludeBlank = 1
		order by b.BookSequence

	return @return

end
go