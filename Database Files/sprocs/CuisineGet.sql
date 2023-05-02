create or alter procedure dbo.CuisineGet(@All bit = 0, @CuisineId int = 0, @CuisineType varchar(50) = '')
as
begin
    select @CuisineType = nullif(@CuisineType, '')

	select c.CuisineID, c.CuisineType
	from Cuisine c
    where @All = 1
    or c.CuisineType like '%' + @CuisineType + '%'
    or c.CuisineID = @CuisineId
	order by c.CuisineType
end
go

/*
exec CuisineGet

exec CuisineGet @CuisineType = ''
exec CuisineGet @CuisineType = 'a'

exec CuisineGet @All = 1

declare @CuisineId int
select top 1 @CuisineId = r.Cuisineid from Cuisine r
exec CuisineGet @CuisineId = @CuisineId
*/