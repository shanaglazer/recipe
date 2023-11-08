use HeartyHearthDB
go

create or alter proc dbo.IngredientGet(
	@IngredientId int =  0,
	@IngredientType varchar(30) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output)
as
begin


	declare @return int = 0

	select @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0)

	select i.IngredientID, i.IngredientType
	from Ingredient i
	where i.IngredientID = @IngredientId
	or @All = 1
	or i.IngredientType like '%' + @IngredientType + '%'
	union select 0, ''
	where @IncludeBlank = 1
	order by i.IngredientType

	return @return

end
go

--exec IngredientGet