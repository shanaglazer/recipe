use HeartyHearthDB
go

create or alter procedure dbo.RecipeGet(
	@All bit = 0, 
	@RecipeId int = 0, 
	@RecipeName varchar(50) = '', 
	@IncludeBlank bit = 0)
as
begin
    select @RecipeName = nullif(@RecipeName, '')

	select r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus, RecipeNameForImage = lower(REPLACE(r.RecipeName,' ', ''))
	from recipe r
    where @All = 1
    or r.RecipeName like '%' + @RecipeName + '%'
    or r.RecipeID = @RecipeId
	union  select 0,0,0,'',0,'','','','', ''
	where @IncludeBlank =1
	order by r.recipename
end
go

/*
exec RecipeGet @Includeblank = 1

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'a'

exec RecipeGet @All = 1

declare @RecipeId int
select top 1 @RecipeId = r.Recipeid from Recipe r
exec RecipeGet @RecipeId = @RecipeId
*/