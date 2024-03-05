create table Clients
(
	Id serial primary key,
	Name varchar,
	Balance decimal
);

create table Transactions
(
	Id serial primary key,
	Data int,
	Summa decimal,
	SenderId int references Clients(Id),
	TakerId int references Clients(Id)
		
);

select * from Transactions
drop table Clients