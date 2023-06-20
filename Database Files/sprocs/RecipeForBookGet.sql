use HeartyHearthDB
go

create or alter proc dbo.CookbookGet(@message varchar(500) = '' output)
as 
begin

	declare @return int = 0

		select r.RecipeName, b.BookSequence
		from Cookbook c
		join BookRecipe b
		on b.CookBookID = c.CookbookID
		join Recipe r
		on r.RecipeID = b.RecipeID
		where c.BookName = 'Mom''s Kitchen'
		order by b.BookSequence

	return @return

end
go