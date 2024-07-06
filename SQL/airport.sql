use QuanLyBanVeMayBay


create table airport(
	code nvarchar(10) primary key,
	name nvarchar(50) not null,
	city nvarchar(50) not null,
	status varchar(20) not null,
	note nvarchar(1000)
)
 
go
create proc add_airport
@code nvarchar(10), @name nvarchar(50), @city nvarchar(50), @status varchar(20), @note nvarchar(1000)
as
begin
	insert into airport(code, name, city, status, note) values(@code, @name, @city, @status, @note)
end
go

go
create proc update_airport
@newcode nvarchar(10), @oldcode nvarchar(10), @name nvarchar(50), @city nvarchar(50), @status varchar(20), @note nvarchar(1000)
as
begin
	update airport set code = @newcode, name = @name, city = @city, status = @status, note = @note where code = @oldcode
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


select * from airport