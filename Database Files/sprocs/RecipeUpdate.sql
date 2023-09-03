use HeartyHearthDB
go

create or alter proc dbo.RecipeUpdate(
	@RecipeID int output,
	@UsersID int,
	@CuisineID int,
	@RecipeName varchar (50),
	@Calories int,
	@message varchar(500) = '' output 
)
as 
begin
	declare @return int = 0
	
	select @RecipeID = isnull(@RecipeID, 0)

	if @RecipeID = 0
	begin
		insert Recipe(UsersID, CuisineID, RecipeName, Calories, DatePublished, DateArchived)
		values(@UsersID, @CuisineID, @RecipeName, @Calories, null, null)
	
		--select @RecipeID = SCOPE_IDENTITY()
	end
	
	else 
	begin
		update Recipe
		set 
			UsersID = @UsersID, 
			CuisineID = @CuisineID, 
			RecipeName = @RecipeName, 
			Calories = @Calories
		where RecipeID = @RecipeID
	end
	
	return @return
end
go
