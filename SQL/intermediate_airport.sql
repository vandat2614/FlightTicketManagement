use QuanLyBanVeMayBay

create table intermediate_airport(
	code int identity(1,1) primary key,
	flight_code nvarchar(10) foreign key references flight(code),
	airport_code nvarchar(10) foreign key references airport(code),
	duration varchar(10) not null,
	note nvarchar(1000),
)

go
create proc get_intermediate_info
@code int
as
begin
	select * from intermediate_airport where code = @code
end
go

go
create proc get_list_intermediate
@flight_code nvarchar(10)
as
begin
	select * from intermediate_airport where flight_code = @flight_code
end
go

go
create proc add_intermediate_airport
@flight_code nvarchar(10), @airport_code nvarchar(10), @duration varchar(10), @note nvarchar(1000)
as
begin
	insert into intermediate_airport(flight_code, airport_code, duration, note) values(@flight_code, @airport_code, @duration, @note)
end
go

go
create proc update_intermediate_airport
@code int, @airport_code nvarchar(10), @duration varchar(10), @note nvarchar(1000)
as
begin
	update intermediate_airport set airport_code = @airport_code, duration = @duration, note = @note where code = @code
end
go


go 
create proc delete_intermediate_airport
@code int
as
begin
	delete from intermediate_airport where code = @code
end
go



insert into intermediate_airport
values('ABC', 'A21', 20, N'Dừng Lại để tiếp nhiên liệu, đồng thời sữa chữa động cơ')

select * from intermediate_airport

drop table intermediate_airport

select * from account