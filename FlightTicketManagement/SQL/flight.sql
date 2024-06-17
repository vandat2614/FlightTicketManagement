use quanlybanvemaybay

create table flight(
	code nvarchar(10) primary key,
	start nvarchar(10) foreign key references airport(code),
	dest nvarchar(10) foreign key references airport(code),
	date varchar(20) not null,
	time varchar(20) not null,
	duration varchar(10) not null,
	price int not null,
	seat1 int not null,
	seat2 int not null,
)

go
create proc add_flight
@code nvarchar(10), @start nvarchar(10), @dest nvarchar(10), @date varchar(20), @time varchar(20), @duration varchar(10), @price int, @seat1 int, @seat2 int
as
begin
	insert into flight(code, start, dest, date, time, duration, price, seat1, seat2) 
	values(@code, @start, @dest, @date, @time, @duration, @price, @seat1, @seat2)
end
go


go
create proc check_flight
@code nvarchar(10)
as
begin
	select * from flight where code = @code
end
go


select * from airport

INSERT INTO flight (code, start, dest, datetime, time, price, seat1, seat2)
VALUES ('FL001', 'A21', 'RT432', '2024-06-17 08:00:00', 2.5, 1200000, 100, 150);

select * from flight

