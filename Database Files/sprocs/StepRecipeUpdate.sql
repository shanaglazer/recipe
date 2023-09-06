use HeartyHearthDB
go

create or alter procedure dbo.StepRecipeUpdate(
	@InstructionId int  output,
	@RecipeId int ,
	@InstructionStep varchar(100),
	@InstructionSequence int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @InstructionId = isnull(@InstructionId,0), @RecipeId = isnull(@RecipeId, ''), @InstructionStep = isnull(@InstructionStep, ''), @InstructionSequence = isnull(@InstructionSequence, '')

	if @InstructionId = 0
	begin
		insert Instruction(RecipeID, InstructionStep, InstructionSequence)
		values(@RecipeId, @InstructionStep, @InstructionSequence)

		select @InstructionId= scope_identity()
	end
	else
	begin
		update Instruction
		set
			recipeid = @RecipeId, 
			InstructionStep = @InstructionStep,
			InstructionSequence = @InstructionSequence
		where InstructionID = @InstructionId
	end

	return @return
end
go
--select * from instruction
