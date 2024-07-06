use quanlybanvemaybay

create table flight(
	code nvarchar(10) primary key,
	depature nvarchar(10) foreign key references airport(code),
	arrival nvarchar(10) foreign key references airport(code),
	date varchar(20) not null,
	time varchar(20) not null,
	duration varchar(10) not null,
	price int not null,
	seat1 int not null,
	seat2 int not null,
)

go
create proc add_flight
@code nvarchar(10), @depature nvarchar(10), @arrival nvarchar(10), @date varchar(20), @time varchar(20), @duration varchar(10), @price int, @seat1 int, @seat2 int
as
begin
	insert into flight(code, depature, arrival, date, time, duration, price, seat1, seat2) 
	values(@code, @depature, @arrival, @date, @time, @duration, @price, @seat1, @seat2)
end
go

drop proc update_flight
go
create proc update_flight
@newcode nvarchar(10), @oldcode nvarchar(10), @date varchar(20), @time varchar(20), @duration varchar(10), @price int, @seat1 int, @seat2 int
as
begin
	update flight set code = @newcode, date = @date, time = @time, duration = @duration, price = @price, seat1 = @seat1, seat2 = @seat2 where code = @oldcode
end
go


go 
create proc delete_flight
@code nvarchar(10)
as
begin
	delete from flight where code = @code
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

go
create proc search_flight
@depature nvarchar(50), @arrival nvarchar(50), @date varchar(20)
as
begin
	select flight.code from flight inner join airport as dep_airport on flight.depature = dep_airport.code inner join airport as arr_airport on flight.arrival = arr_airport.code
	and dep_airport.name = @depature and arr_airport.name = arrival and flight.date = date
end
go


insert into flight values('R1', 'R124', 'T1', '2', '2', '3.5', 1, 1, 1)
select * from airport
select * from flight


select * from account