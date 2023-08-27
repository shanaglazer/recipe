create or alter procedure dbo.MeasurementTypeGet(@All bit = 0, @MeasurementTypeId int = 0, @MeasuringType varchar(50) = '')
as
begin
    select @MeasuringType = nullif(@MeasuringType, '')

	select m.MeasurementTypeID, m.MeasuringType
	from MeasurementType m
    where @All = 1
    or m.MeasuringType like '%' + @MeasuringType + '%'
    or m.MeasurementTypeID = @MeasurementTypeID
	order by m.MeasuringType
end
go