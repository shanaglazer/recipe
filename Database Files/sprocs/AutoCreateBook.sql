use HeartyHearthDB 
go

create or alter proc dbo.AutoCreateBook(
	@UserName varchar(100),
	--@BookName varchar(150) = '' output,
	@Message varchar(500) = ''  output)
as
begin

	declare @return int = 0

	select @UserName = isnull(@UserName, '')

		;with x as(
			SELECT NumOfRecipes = COUNT(r.RecipeID), u.UsersID
			FROM Recipe r
			join Users u
			on u.UsersID = r.UsersID
			WHERE u.UserName = @UserName
			group by u.UsersID
		)
		INSERT Cookbook(UsersID, Active, BookName, Price, DateCreated)
		select u.UsersID, 1, CONCAT('Recipes by ',u.FirstName, ' ', u.LastName), x.NumOfRecipes * 1.33, GETDATE()
		from Users u 
		join x
		on x.UsersID = u.UsersID
		WHERE u.UserName = @UserName
		
		insert BookRecipe(CookBookID, RecipeID, BookSequence)
		SELECT c.CookbookID, r.RecipeID, ROW_NUMBER() over (order by r.RecipeName)
		from Users u 
		join Cookbook c
		on c.UsersID = u.UsersID
		join Recipe r
		on r.UsersID = u.UsersID
		WHERE u.UserName = @UserName
		and c.BookName = CONCAT('Recipes by ',u.FirstName, ' ', u.LastName)
		order by r.RecipeName

		SELECT @return = c.CookbookID 
		from Cookbook c 
		join Users u
		on u.UsersID  = c.UsersID
		where c.BookName = CONCAT('Recipes by ',u.FirstName, ' ', u.LastName)

return @return

end
go
