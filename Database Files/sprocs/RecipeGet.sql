create or alter procedure dbo.RecipeGet(@All bit = 0, @RecipeId int = 0, @RecipeName varchar(50) = '')
as
begin
    select @RecipeName = nullif(@RecipeName, '')

	select r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus
	from recipe r
    where @All = 1
    or r.RecipeName like '%' + @RecipeName + '%'
    or r.RecipeID = @RecipeId
	order by r.recipename
end
go

/*
exec RecipeGet

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'a'

exec RecipeGet @All = 1

declare @RecipeId int
select top 1 @RecipeId = r.Recipeid from Recipe r
exec RecipeGet @RecipeId = @RecipeId
*/