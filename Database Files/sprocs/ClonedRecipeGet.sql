use HeartyHearthDB 
go

create or alter proc dbo.ClonedRecipeGet(
	@RecipeName varchar(100) = '',
	@Message varchar(500) = ''  output)
as
begin

	declare @return int = 0, @NewRecipeName varchar(108)

	select @RecipeName = isnull(@RecipeName, '')

	select @NewRecipeName = @RecipeName + ' - clone'

	select *
	from recipe
	where RecipeName = @NewRecipeName

	return @return

end
go

