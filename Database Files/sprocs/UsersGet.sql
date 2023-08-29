create or alter procedure dbo.UsersGet(
	@All bit = 0, 
	@UsersId int = 0, 
	@UserName varchar(50) = '',
	@IncludeBlank bit = 0)
as
begin
    select @UserName = nullif(@UserName, '')

	select *
	from Users u
    where @All = 1
    or u.UserName like '%' + @UserName + '%'
    or u.UsersID = @UsersId
	union select 0, '', '', ''
	where @IncludeBlank = 1
	order by u.LastName, u.FirstName, u.UserName
end
go

/*
exec UsersGet

exec UsersGet @UserName = ''
exec UsersGet @UserName = 'a'

exec UsersGet @All = 1

declare @UsersId int
select top 1 @UsersId = u.Usersid from Users u
exec UsersGet @UsersId = @UsersId
*/