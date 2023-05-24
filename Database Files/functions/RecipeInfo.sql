use HeartyHearthDB
go

create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(150)
as
begin

	declare @value varchar(150) = ''

			;with x as(
		    SELECT NumOfIng = COUNT(ir.IngredientID), r.RecipeID
		    from IngredientRecipe ir
		    join Recipe r
		    on r.RecipeID = ir.RecipeID
		    group by r.RecipeID
		),
		y as(
		    SELECT NumOfSteps = COUNT(i.InstructionID), r.RecipeID
		    from Instruction i
		    join Recipe r
		    on r.RecipeID = i.RecipeID
		    group by r.RecipeID 
		)
		SELECT @value = concat(r.RecipeName, ' (', c.CuisineType, ') has ', x.NumOfIng,  ' ingredients and ', y.NumOfSteps, ' steps.')
		from Recipe r
		join x
		on x.RecipeID = r.RecipeID
		join y
		on y.RecipeID = r.RecipeID
		join Cuisine c
		on c.CuisineID = r.CuisineID
		WHERE r.RecipeID = @RecipeId

	return @value

end
go

select dbo.RecipeInfo(r.RecipeID),*
from recipe r