create or alter procedure dbo.CuisineUpdate(
		@CuisineId int  output,
		@CuisineType varchar (100),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0), @CuisineType = isnull(@CuisineType, '')
	
	if @CuisineId = 0
	begin
		insert Cuisine(CuisineID, CuisineType)
		values(@CuisineId, @CuisineType)

		select @CuisineId= scope_identity()
	end
	
	else
	begin
		update Cuisine
		set 
			CuisineType = @CuisineType
		where CuisineID = @CuisineId
	end
	
	return @return
end
go
