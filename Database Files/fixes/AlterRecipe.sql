--alter table recipe drop constraint DF__Recipe__Vegan__44A0E595

--alter table recipe drop column vegan

alter table Recipe add Vegan bit  null 
go

select * from recipe
