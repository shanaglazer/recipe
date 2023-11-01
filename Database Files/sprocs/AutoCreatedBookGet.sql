use HeartyHearthDB 
go

create or alter proc dbo.AutoCreatedBookGet(
	@UserName varchar(100) = '',
	@Message varchar(500) = ''  output)
as
begin

	declare @return int = 0, @FirstName varchar(30), @LastName varchar(30), @NewBookName varchar(100)

	select @UserName = isnull(@UserName, '')

	set @FirstName = (select u.FirstName from Users u where u.UserName = @UserName)
	set @LastName = (select u.LastName from Users u where u.UserName = @UserName)
	set @NewBookName = 'Recipes by ' + @FirstName + ' ' + @LastName

	select *
	from Cookbook
	where BookName = @NewBookName

	return @return

end
go

--select * from users

EXEC AutoCreatedBookGet @UserName = 'LibfroindE'