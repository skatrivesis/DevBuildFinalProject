create database CardKnight
go
use CardKnight
go
create table Character (
	Id int identity(1,1) primary key not null,
	CharName nvarchar(20) not null,
	Hp int not null,
	Ap int not null,
	Progress int not null,
	Player bit not null
);
go
create table Card (
	Id int identity(1,1) primary key not null,
	CardName varchar(20) not null,
	Cost int not null,
	Info varchar(120) not null,
	Modifier int not null,
	CardType varchar(20) not null
);
go
create table Deck (
	Id int identity(1,1) primary key not null,
	CharId int foreign key references Character(Id),
	CardId int foreign key references Card(Id)
);
go
create table Equipment (
	Id int identity(1,1) primary key not null,
	EquipName varchar(30) not null,
	Info varchar(120) not null,
	Modifier int not null,
	EquipType varchar(20) not null
);