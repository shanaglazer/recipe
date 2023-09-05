use HeartyHearthDB
go

create or alter procedure dbo.IngredientUpdate(
		@IngredientId int  output,
		@IngredientType varchar (100),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0), @IngredientType = isnull(@IngredientType, '')
	
	if @IngredientId = 0
	begin
		insert Ingredient(IngredientType)
		values(@IngredientType)

		select @IngredientId= scope_identity()
	end
	else
	begin
		update Ingredient
		set
			IngredientType = @IngredientType
		where IngredientID = @IngredientId
	end
	
	return @return
end
go
