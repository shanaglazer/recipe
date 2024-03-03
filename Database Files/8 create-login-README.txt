script to create login and user is excuded from this repo.
Create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the following to that fil - 

use master
go

create login [loginname] with password  = '[password]'

use HeartyHearthDB
go

create user [username] from login [login name]