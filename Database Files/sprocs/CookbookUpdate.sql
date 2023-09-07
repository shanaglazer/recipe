use HeartyHearthDB
go

create or alter procedure dbo.CookbookUpdate(
		@CookbookId int =0 output,
		@UserName varchar (30) = '',
		--@UsersId int = 0,
		@Active bit = 0,
		@BookName varchar(80) = '',
		@price decimal = 0,
		--@DateCreated date,-- = '',
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0), @UserName = isnull(@UserName, ''), @Active = isnull(@Active, 0), @BookName = isnull(@BookName, ''), @price = isnull(@price, 0)--, @DateCreated = nullif(@DateCreated, '')
	
	--select @CookbookPicture =  concat('Cookbook-', replace(@BookName, ' ', '-' ), '.jpg')

	if @CookbookId = 0
	begin
		insert cookbook(UsersID, Active, BookName, Price, DateCreated)
		values((select UsersId from Users where username = @UserName), @Active, @BookName, @price, getdate())

		select @CookbookId= scope_identity()
	end
	else
	begin
		update Cookbook
		set
			UsersID = (select UsersID from Users  where UserName = @UserName),
			Active = @Active,
			BookName = @bookName,
			Price  = @price
		where CookbookID = @CookbookId
	end
	
	return @return
end
go

exec CookbookUpdate
--@CookbookId = 4,
@UserName = 'LibfroindE',
@Active = 1,
@BookName = 'hihihihi',
@price = 42.00,
@Message = null
select * from Users

