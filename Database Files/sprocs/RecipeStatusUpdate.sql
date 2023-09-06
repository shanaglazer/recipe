use HeartyHearthDB
go

create or alter procedure dbo.RecipeStatusUpdate(
		@RecipeId int  output,
		@ColumnToChange varchar(15),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	--select @DatePublished = isnull(@DatePublished,0), @DateArchived = isnull(@DateArchived, ''), @DateCreated = isnull(@DateCreated, '')
	
		update Recipe
		set DateCreated = 
		case 
		when @ColumnToChange = DateCreated then getdate()
		else
		DateCreated
			end,
		    DatePublished = 
		case 
		when @ColumnToChange = DatePublished then getdate()
		else
		DatePublished
			end,
			DateArchived = 
		case 
		when @ColumnToChange = DateArchived then getdate()
		else
		DateArchived
			end
		where RecipeID = @RecipeId
	
	return @return
end
go

exec RecipeStatusUpdate
@RecipeId = 4,
@ColumnToChange = 'DatePublished'