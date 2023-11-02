use HeartyHearthDB
go

create or alter procedure dbo.CourseTypeDelete(
	@CourseTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseTypeId = isnull(@CourseTypeId,0)

	delete r 
	from RecipeCourse r
	join Course c
	on c.courseid = r.courseid
	where c.CourseTypeID = @CourseTypeId
	
	delete Course where CourseTypeID = @CourseTypeId
	
	delete CourseType where CourseTypeID = @CourseTypeId

	return @return
end
go
--select * from RecipeCourse

/*
use HeartyHearthDB
go
exec CourseTypeDelete
@CourseTypeId = 12,
@Message = null
*/
