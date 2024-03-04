use master
go

create login appadmin with password  = 'admin123' --azure = + !

use  HeartyHearthDB
go

create user appadmin_user from login appadmin