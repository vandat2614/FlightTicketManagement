use QuanLyBanVeMayBay

create table setting(
	id int primary key,
	min_flight_duration int,
	max_intermediate_airport int,
	min_stop_time_intermediate_airport int,
	max_stop_time_intermediate_airport int,
	latest_time_book_ticket int,
	ticket_cancel_time int
)

insert into setting values(2601, 30, 2, 10, 20, 1, 1)

go
create proc update_setting
@min_flight_duration int, @max_intermediate_airport int, @min_stop_time_intermediate_airport int, @max_stop_time_intermediate_airport int, @latest_time_book_ticket int, @ticket_cancel_time int
as
begin
	update setting set min_flight_duration = @min_flight_duration, max_intermediate_airport = @max_intermediate_airport, min_stop_time_intermediate_airport = @min_stop_time_intermediate_airport, 
	max_stop_time_intermediate_airport = @max_stop_time_intermediate_airport, latest_time_book_ticket = @latest_time_book_ticket, ticket_cancel_time = @ticket_cancel_time
	where id = 2601
end
go


select * from setting