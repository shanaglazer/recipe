
create or alter proc dbo.DashboardApiGet(@message varchar(500) = '' output, @All bit = 0, @IncludeBlank bit = 0)
as
begin
	declare @return int = 0

	select DashboardType = 'recipe', DashboardText = concat('View ', count(*), ' Recipes')from Recipe
	union select DashboardType = 'meal', DashboardText = concat('View ', count(*), ' Meals')from meal
	union select DashboardType = 'cookbook', DashboardText = concat('View ', count(*), ' Cookbooks')from cookbook

	return @return
end
go

exec DashboardApiGet