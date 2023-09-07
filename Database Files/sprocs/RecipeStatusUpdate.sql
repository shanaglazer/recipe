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

	select @ColumnToChange = isnull(@ColumnToChange,'')
	
		
		if(@ColumnToChange = 'DateCreated')
		begin
		update Recipe 
		set DateCreated = getdate(), 
			DatePublished = null, 
			DateArchived = null 
		where RecipeID = @RecipeId
		end
		if(@ColumnToChange = 'DatePublished')
		begin
		update Recipe 
		set DatePublished = getdate(),
		    DateArchived = null
		where RecipeID = @RecipeId
		end
		if(@ColumnToChange = 'DateArchived')
		begin
		update Recipe 
		set DateArchived = getdate()
		where RecipeID = @RecipeId
		end
	
	return @return
end
go

--exec RecipeStatusUpdate
--@RecipeId = 4,
--@ColumnToChange = 'DatePublished'