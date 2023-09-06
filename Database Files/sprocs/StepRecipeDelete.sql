use HeartyHearthDB 
go

create or alter procedure dbo.StepRecipeDelete(
	@InstructionId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @InstructionId = isnull(@InstructionId,0)

	delete Instruction where InstructionId = @InstructionId

	return @return
end
go
