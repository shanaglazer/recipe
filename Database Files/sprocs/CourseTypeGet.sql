create or alter procedure dbo.CourseTypeGet(@All bit = 0, @CourseTypeID int = 0, @CourseName varchar(50) = '')
as
begin
    select @CourseName = nullif(@CourseName, '')

	select c.CourseTypeID, c.CourseName, c.CourseSequence
	from CourseType c
    where @All = 1
    or c.CourseName like '%' + @CourseName + '%'
    or c.CourseTypeID = @CourseTypeID
	order by c.CourseName
end
go