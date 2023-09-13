create or alter procedure dbo.CourseTypeDelete(
	@CourseTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseTypeId = isnull(@CourseTypeId,0)

	delete Course where CourseTypeID = @CourseTypeId
	delete CourseType where CourseTypeID = @CourseTypeId
	delete CourseType where CourseTypeID = @CourseTypeId

	return @return
end
go
