use HeartyHearthDB
go

create or alter procedure dbo.CookbookInfoGet(
	@All bit = 0, 
	@CookbookId int = 0, 
	@BookName varchar(50) = '', 
	@IncludeBlank bit = 0)
as
begin
    select @BookName = nullif(@BookName, '')

	select c.CookbookID, c.UsersID, c.Active, c.BookName, c.Price, c.DateCreated, c.CookbookPicture
	from Cookbook c
    where @All = 1
    or c.CookbookID = @CookbookId
	union  select 0,0,0,'',0,'',''
	where @IncludeBlank =1
	order by c.BookName
end
go