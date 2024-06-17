use QuanLyBanVeMayBay

create table account(
	Id int identity(1,1) primary key,
	Email varchar(50) not null,
	PassWord varchar(30) not null,
	Type varchar(10) default('admin'),
	FullName varchar(50),
	PhoneNumber varchar(15),
)


go
create proc account_login
@email varchar(50), @password varchar(30)
as
begin
	select * from dbo.account where email = @email and password = @password
end
go

go
create proc check_email
@email varchar(50)
as
begin
	select * from dbo.account where email = @email
end
go


go
create proc add_account
@email varchar(50), @password varchar(30)
as
begin
	insert into account(Email, PassWord) values(@email, @password)
end
go

go
create proc add_account_full
@email varchar(50), @password varchar(30), @name varchar(50), @type varchar(10), @phone varchar(15)
as
begin
	insert into account(Email, PassWord, Type, FullName, PhoneNumber) values(@email, @password, @type, @name, @phone)
end
go

go
create proc update_account
@id int, @email varchar(50), @password varchar(30), @name varchar(50), @type varchar(10), @phone varchar(15)
as
begin
	update account set Email = @email, PassWord = @password, FullName = @name, Type = @type, PhoneNumber = @phone where Id = @id
end
go

go
create proc delete_account
@id int
as
begin
	delete from account where Id = @id
end
go


exec check_email  '22520207@gm.uit.edu.vn'




insert into account(Email, PassWord, Type)
values('22520207@gm.uit.edu.vn', '123456', 'admin')

insert into account(Email, PassWord, Type)
values('vd', '12', 'admin')

select * from account

