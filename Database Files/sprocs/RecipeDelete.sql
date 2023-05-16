use HeartyHearthDB
go

create or alter procedure dbo.RecipeDelete(@RecipeId int)
as
begin

	begin try
		begin tran
			delete IngredientRecipe where RecipeID = @RecipeId
			delete Instruction where RecipeID = @RecipeId
			delete Recipe where RecipeID = @RecipeId
			commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go