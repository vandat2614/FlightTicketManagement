use QuanLyBanVeMayBay

create table airport(
	code nvarchar(10) primary key,
	name nvarchar(50) not null,
	city nvarchar(50) not null,
)
 
go
create proc add_airport
@code nvarchar(10), @name nvarchar(50), @city nvarchar(50)
as
begin
	insert into airport(code, name, city) values(@code, @name, @city)
end
go

go
create proc update_airport
@code nvarchar(10), @name nvarchar(50), @city nvarchar(50)
as
begin
	update airport set code = @code, name = @name, city = @city where code = @code
end
go


go
create proc delete_airport
@code nvarchar(10)
as
begin
	delete from airport where code = @code
end
go

go
create proc check_airport
@code nvarchar(10)
as
begin
	select * from airport where code = @code
end
go
