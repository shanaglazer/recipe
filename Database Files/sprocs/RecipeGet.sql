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


	;with x as(
    SELECT NumOfIng = COUNT(ir.IngredientID), r.RecipeID
    from IngredientRecipe ir
    join Recipe r
    on r.RecipeID = ir.RecipeID
    group by r.RecipeID
	)
	select r.RecipeID, r.RecipeName, r.RecipeStatus, r.UsersID, u.UserName, r.CuisineID, c.CuisineType, r.Calories, NumIngredient = isnull(x.NumOfIng, 0), r.DateCreated, r.DatePublished, r.DateArchived, RecipeNameForImage = lower(REPLACE(r.RecipeName,' ', ''))
	from recipe r
	left join Users u
	on u.UsersID = r.UsersID
	left join Cuisine c
	on c.CuisineID = r.CuisineID
	left join x
	on x.RecipeID = r.RecipeID
    where @All = 1
    or r.RecipeName like '%' + @RecipeName + '%'
    or r.RecipeID = @RecipeId
	union  select 0,'','',0,'',0,'',0,0,'','','',''
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