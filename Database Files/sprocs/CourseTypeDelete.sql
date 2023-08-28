create or alter procedure dbo.CourseTypeDelete(
	@CourseTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseTypeId = isnull(@CourseTypeId,0)

	delete c 
	from CourseType c
	where c.CourseTypeID = @CourseTypeId

	return @return
end
go
