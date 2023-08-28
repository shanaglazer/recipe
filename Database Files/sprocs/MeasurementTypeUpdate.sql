create or alter procedure dbo.MeasurementTypeUpdate(
		@MeasurementTypeId int  output,
		@MeasuringType varchar (100),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId,0), @MeasuringType = isnull(@MeasuringType, '')
	
	if @MeasurementTypeId = 0
	begin
		insert MeasurementType(MeasuringType)
		values(@MeasuringType)

		select @MeasurementTypeId= scope_identity()
	end
	else
	begin
		update MeasurementType
		set
			MeasuringType = @MeasuringType
		where MeasurementTypeID = @MeasurementTypeId
	end
	
	return @return
end
go
