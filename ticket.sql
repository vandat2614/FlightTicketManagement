use quanlybanvemaybay

create table ticket(
	code int identity(1,1) primary key,
	flight_code nvarchar(10) foreign key references flight(code),
	name nvarchar(100),
	cmnd varchar(20),
	phone varchar(15),
	seat_type int,
	price int,
	ticket_type varchar(10),
)

go
create proc add_ticket
@flight_code nvarchar(10), @name nvarchar(100), @cmnd varchar(20), @phone varchar(15), @seat_type int, @price int, @ticket_type varchar(10)
as
begin
	insert into ticket(flight_code, name, cmnd, phone, seat_type, price, ticket_type) 
	values(@flight_code, @name, @cmnd, @phone, @seat_type, @price, @ticket_type)
end
go

drop proc update_ticket
go
create proc update_ticket
@code int, @name nvarchar(100), @cmnd varchar(20), @phone varchar(15), @seat_type int, @price int, @ticket_type varchar(10)
as
begin
	update ticket set name = @name, cmnd = @cmnd, phone = @phone, seat_type = @seat_type, price = @price, ticket_type = @ticket_type where code = @code
end
go


go 
create proc delete_ticket
@code int
as
begin
	delete from ticket where code = @code
end
go


go
create proc search_ticket
@flight_code nvarchar(10)
as
begin
	select * from ticket where flight_code = @flight_code
end
go


select * from ticket
select * from flight

