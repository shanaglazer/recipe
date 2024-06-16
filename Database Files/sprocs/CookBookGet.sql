--for cookbook list
use HeartyHearthDB
go

create or alter proc dbo.CookbookGet(@All bit = 0, @CookbookId int = 0, @IncludeBlank bit = 0, @message varchar(500) = '' output)
as 
begin

	declare @return int = 0

		;with x as(
    SELECT NumOfRecipes = COUNT(br.RecipeID), br.CookBookID
    FROM BookRecipe br
    group by br.CookBookID
	)
	SELECT u.UsersID, u.UserName, c.Active, c.cookbookid, c.DateCreated, c.BookName, Author = concat(u.firstname, ' ', u.lastname), x.NumOfRecipes, c.Price
	FROM Cookbook c
	join users u
	on u.usersid = c.usersid
	left join x 
	on x.CookBookID = c.CookBookID
	--WHERE c.Active = 1
	where @All = 1
	or c.CookbookID = @CookbookId
	union  select 0,'',0,0,'','','',0,0
	where @IncludeBlank =1
	order by c.BookName

	return @return

end
go

exec CookbookGet @All = 1