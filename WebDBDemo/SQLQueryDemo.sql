create table Blah
(
	Field1 int primary key,
	Field2 int
)
go

alter procedure GetData
	@key int
as
	select  Field1, Field2
	from	yli121.dbo.Blah
	where	Field1 <= @key
go

insert into yli121.dbo.Blah
values (1,1), (2,2), (3,3)
go

create procedure InsertData
	@value1 int,
	@value2 int
as
	insert into yli121.dbo.Blah
	values (@value1, @value2)
go

select * from Blah