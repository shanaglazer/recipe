create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)

	DELETE rc
		--SELECT *
		FROM Users u
		join Meal m
		on m.UsersID = u.UsersID
		join Course c
		on m.MealID = c.MealID
		join RecipeCourse rc
		on rc.CourseID = c.CourseID
		where u.UsersID = @UsersId
		
		DELETE c
		--SELECT *
		FROM Users u
		join Meal m
		on m.UsersID = u.UsersID
		join Course c
		on m.MealID = c.MealID
		where u.UsersID = @UsersId
		
		DELETE m
		--SELECT *
		FROM Users u
		join Meal m
		on m.UsersID = u.UsersID
		where u.UsersID = @UsersId
		
		DELETE br
		--SELECT *
		FROM Users u
		join Cookbook c
		on c.UsersID = u.UsersID
		join BookRecipe br
		on br.CookBookID = c.CookbookID
		where u.UsersID = @UsersId
		
		DELETE c
		--SELECT *
		FROM Users u
		join Cookbook c
		on c.UsersID = u.UsersID
		where u.UsersID = @UsersId
		
		DELETE i
		--SELECT *
		FROM Users u
		join Recipe r
		on r.UsersID = u.UsersID
		join Instruction i
		on i.RecipeID = r.RecipeID
		where u.UsersID = @UsersId
		
		DELETE ir
		--SELECT *
		FROM Users u
		join Recipe r
		on r.UsersID = u.UsersID
		join IngredientRecipe ir
		on ir.RecipeID = r.RecipeID
		where u.UsersID = @UsersId
		
		DELETE rc
		--SELECT *
		FROM Users u
		join Recipe r
		on r.UsersID = u.UsersID
		join RecipeCourse rc
		on rc.RecipeID = r.RecipeID
		where u.UsersID = @UsersId
		
		DELETE br
		--SELECT *
		FROM Users u
		join Recipe r
		on r.UsersID = u.UsersID
		join BookRecipe br
		on br.RecipeID = r.RecipeID
		where u.UsersID = @UsersId
		
		DELETE r
		--SELECT *
		FROM Users u
		join Recipe r
		on r.UsersID = u.UsersID
		where u.UsersID = @UsersId
		
		DELETE u
		--SELECT *
		FROM Users u
		where u.UsersID = @UsersId

	return @return
end
go
