use Library

create table Clients(
	ID int primary key identity,
	Client_Name nvarchar(50),
	Client_Surname nvarchar(100),
	CLient_Patronymic nvarchar(50),	
	Client_Email nvarchar(100) unique,
)

create table Sellers(
	ID int primary key identity,
	Seller_Name nvarchar(50) not null,
	Seller_Surname nvarchar(100) not null,
	Seller_Patronymic nvarchar(50) not null,
	Seller_Email nvarchar(100) unique,
	Seller_Password nvarchar(255),
	Is_Admin bit default 0 not null,
	Is_Activated bit default 0 not null,
	Is_Deleted bit default 0 not null,
)

create table Book_Genres(
	ID int primary key identity,
	Genre_Name nvarchar(100),
	Is_Deleted bit default 0,
)
create table Books(
	ID int primary key identity,
	Book_Name nvarchar(100),
	Book_Amount int,
	Book_Price decimal (5,2),
	Book_Deposit decimal (10,2),
	Genre_Id int references Book_Genres(ID),
)

create table Authors(
	ID int primary key identity,
	Author_Name nvarchar(50),
	Author_Surname nvarchar(100),
	Author_Patronymic nvarchar(100),
)

create table Collected_Works(
	ID int primary key identity,
	Book_ID int references Books(ID),
	Author_ID int references Authors(ID),
)

create table Orders(
	ID int primary key identity,
	Client_ID int references Clients(ID),
	Seller_ID int references Sellers(ID),
	Order_Date date,
	Return_Date date,
	Total_Price decimal(10,2),
	Deposit_Sum decimal(10,2),
	Seller_Comment text,
)

create table Inquires(
	ID int primary key identity,
	Book_ID int references Books(ID),
	Order_ID int references Orders(ID),
)

create view Info_Inquires
as
select Client_Name, Client_Email, Book_Name, Book_Deposit, Order_Date, Return_Date, Total_Price, Seller_Name  from Inquires
join Books B on B.ID= Inquires.Book_ID
join Orders O on O.ID= Inquires.Order_ID
join Clients C on C.ID= O.Client_ID
join Sellers S on S.ID = O.Seller_ID

select * from Info_Inquires