use HeartyHearthDB
go

create or alter procedure dbo.CookbookUpdate(
		@CookbookId int =0 output,
		@UserName varchar (30) = '',
		@Active bit = 0,
		@BookName varchar(80) = '',
		@price decimal = 0,
		@DateCreated date,-- = '',
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0), @UserName = isnull(@UserName, ''), @Active = isnull(@Active, 0), @BookName = isnull(@BookName, ''), @price = isnull(@price, 0), @DateCreated = isnull(@UserName, '')
	
	--select @CookbookPicture =  concat('Cookbook-', replace(@BookName, ' ', '-' ), '.jpg')

	if @CookbookId = 0
	begin
		insert cookbook(UsersID, Active, BookName, Price, DateCreated)
		values((select UsersID from Users  where UserName = @UserName), @Active, @BookName, @price, @DateCreated)

		select @CookbookId= scope_identity()
	end
	else
	begin
		update Cookbook
		set
			UsersID = (select UsersID from Users  where UserName = @UserName),
			Active = @Active,
			BookName = @bookName,
			Price  = @price,
			DateCreated = CAST(@DateCreated AS DATETIME2)
		where CookbookID = @CookbookId
	end
	
	return @return
end
go

exec CookbookUpdate
@CookbookId = 4,
@UserName = 'MichalHofman',
@Active = 1,
@BookName = 'In the potyyyy',
@price = 42.00,
@DateCreated = '2023-09-05',
@Message = null

select getdate()

select * from Cookbook
update Cookbook set datecreated = '2023-09-05' where cookbookid = 4