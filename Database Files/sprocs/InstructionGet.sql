use HeartyHearthDB
go

create or alter proc dbo.InstructionGet(
	@InstructionId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
	)
as
begin

	declare @return int = 0

	select @InstructionId = isnull(@InstructionId, 0), @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0)

	select i.InstructionID, i.RecipeID, i.InstructionStep, i.InstructionSequence
	from Instruction i
	where i.RecipeID = @RecipeId
	or i.InstructionID = @InstructionId
	or @All = 1
	order by i.InstructionSequence

	return @return

end
go
--exec InstructionGet @all = 1
