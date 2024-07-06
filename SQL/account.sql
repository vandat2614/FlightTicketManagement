use QuanLyBanVeMayBay

create table account(
	email varchar(50) primary key,
	pass varchar(30) not null,
	type varchar(10) default('customer'),
	name nvarchar(100),
	phone varchar(15),
)


go
create proc check_account
@email varchar(50), @pass varchar(30)
as
begin
	select * from dbo.account where email = @email and pass = @pass
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
create proc register_account
@email varchar(50), @pass varchar(30), @type varchar(10), @name nvarchar(100), @phone varchar(15)
as
begin
	insert into account(email, pass, type, name, phone) values(@email, @pass, @type, @name, @phone)
end
go

go
create proc update_account
@newemail varchar(50), @oldemail varchar(50), @pass varchar(30), @name nvarchar(100), @type varchar(10), @phone varchar(15)
as
begin
	update account set email = @newemail, pass = @pass, type = @type, name = @name, phone = @phone where email = @oldemail
end
go

go
create proc delete_account
@email varchar(50)
as
begin
	delete from account where email = @email
end
go


insert into account(email, pass, type)
values('dat@gm.com', '123', 'admin')


select * from account

