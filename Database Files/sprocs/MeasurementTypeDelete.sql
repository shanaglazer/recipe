create or alter procedure dbo.MeasurementTypeDelete(
	@MeasurementTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId,0)

	delete m 
	from MeasurementType m
	where m.MeasurementTypeID = @MeasurementTypeId

	return @return
end
go
