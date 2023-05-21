use HeartyHearthDB
go

create or alter procedure dbo.RecipeDelete(@RecipeId int, @message varchar(500) = '' output)
as
begin
declare @return int = 0
	if exists(select * from recipe r where r.recipeid = @RecipeId and (r.recipestatus = 'Draft' or (r.recipestatus = 'Archive' and getdate() > dateadd(day, 30, r.datearchived))))
	begin
	select @return = 1, @message = 'Cannot delete recipes with status draft or archived for over 30 days.'
	goto finished

	end
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

	finished:
	return @return

end
go