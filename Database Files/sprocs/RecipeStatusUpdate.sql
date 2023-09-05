use HeartyHearthDB
go

create or alter procedure dbo.RecipeStatusUpdate(
		@RecipeId int  output,
		--@DatePublished datetime,
		--@DateArchived datetime,
		--@DateCreated datetime,
		--@DateForChange datetime,
		@ColumnToChange varchar(15),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	--select @DatePublished = isnull(@DatePublished,0), @DateArchived = isnull(@DateArchived, ''), @DateCreated = isnull(@DateCreated, '')
	
		update Recipe
		set
		--lehosif case
		@ColumnToChange = getdate()
			--DateCreated = @DateCreated, 
			--DatePublished = @DatePublished,
			--DateArchived = @DateArchived
		where RecipeID = @RecipeId
	
	return @return
end
go

exec RecipeStatusUpdate
@RecipeId = 4,
@ColumnToChange = DatePublished,
@Message = null