use HeartyHearthDB
go

create or alter procedure dbo.CookbookUpdate(
		@CookbookId int =0 output,
		@UserName varchar (30) = '',
		@Active bit = 0,
		@BookName varchar(80) = '',
		@price decimal = 0,
		@DateCreated datetime2 = '',
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
			DateCreated = @DateCreated
		where CookbookID = @CookbookId
	end
	
	return @return
end
go
