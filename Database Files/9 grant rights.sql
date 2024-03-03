use HeartyHearthDB
go

/*
select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
from INFORMATION_SCHEMA.ROUTINES r
where r.ROUTINE_NAME not like '%gener%'
and r.ROUTINE_NAME not like '%colna%'
*/

grant execute on CourseTypeGet to approle
grant execute on DashboardGet to approle
grant execute on RecipeSummaryGet to approle
grant execute on RecipeClone to approle
grant execute on StepRecipeUpdate to approle
grant execute on StepRecipeDelete to approle
grant execute on UsersDelete to approle
grant execute on UsersUpdate to approle
grant execute on CuisineDelete to approle
grant execute on CuisineUpdate to approle
grant execute on IngredientDelete to approle
grant execute on AutoCreatedBookGet to approle
grant execute on IngredientUpdate to approle
grant execute on MeasurementTypeDelete to approle
grant execute on MeasurementTypeUpdate to approle
grant execute on CourseTypeUpdate to approle
grant execute on CourseTypeDelete to approle
grant execute on CookbookGet to approle
grant execute on CookbookInfoGet to approle
grant execute on BookRecipeDelete to approle
grant execute on AutoCreateBook to approle
grant execute on RecipeDelete to approle
grant execute on CookbookPicture to approle
grant execute on CookbookUpdate to approle
grant execute on RecipeUpdate to approle
grant execute on CookbookDelete to approle
grant execute on RecipeIngredientGet to approle
grant execute on RecipeGet to approle
grant execute on CuisineGet to approle
grant execute on UsersGet to approle
grant execute on TotalCaloriesForMeal to approle
grant execute on IngredientRecipeDelete to approle
grant execute on IngredientRecipeUpdate to approle
grant execute on IngredientGet to approle
grant execute on IngredientRecipeGet to approle
grant execute on MealGet to approle
grant execute on RecipeForBookGet to approle
grant execute on RecipeForBookUpdate to approle
grant execute on RecipeInfo to approle
grant execute on InstructionGet to approle
grant execute on ClonedRecipeGet to approle
grant execute on RecipeStatusUpdate to approle
grant execute on MeasurementTypeGet to approle