create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0)

	delete c
	from Cuisine c
	where c.CuisineID = @CuisineId

	return @return
end
go
