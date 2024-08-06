--recipe grid in the cookbook page
use HeartyHearthDB
go

create or alter proc dbo.RecipeForBookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@IncludeBlank  bit = 0,
	@message varchar(500) = '' output)
as 
begin

	declare @return int = 0

		--isnull

		select b.BookRecipeID, b.CookBookID, r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateArchived, r.DateCreated, r.DatePublished, r.RecipeStatus, b.BookSequence, c.CuisineType, u.UserName
		from BookRecipe b
		join Recipe r 
		on b.RecipeID = r.RecipeID
		join Users u
		on u.UsersID = r.usersid
		join Cuisine c
		on c.CuisineID = r.CuisineID
		where b.CookBookID = @CookbookId
		union select 0, 0, 0, 0, 0, '', 0, '', '', '', '', 0, '', ''
		where @IncludeBlank = 1
		order by b.BookSequence

	return @return

end
go

exec RecipeForBookGet @CookbookId = 1