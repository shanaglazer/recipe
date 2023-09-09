--for cookbook list
use HeartyHearthDB
go

create or alter proc dbo.CookbookGet(@message varchar(500) = '' output)
as 
begin

	declare @return int = 0

		;with x as(
    SELECT NumOfRecipes = COUNT(br.RecipeID), br.CookBookID
    FROM BookRecipe br
    group by br.CookBookID
	)
	SELECT c.cookbookid, c.BookName, Author = concat(u.firstname, ' ', u.lastname), x.NumOfRecipes, c.Price
	FROM Cookbook c
	join users u
	on u.usersid = c.usersid
	left join x 
	on x.CookBookID = c.CookBookID
	--WHERE c.Active = 1
	order by c.BookName

	return @return

end
go

exec CookbookGet