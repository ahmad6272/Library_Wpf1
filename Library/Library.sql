create database Library
use Library

create table Users(
	ID int primary key identity,
	[User_Name] nvarchar(50)not null,
	User_Surname nvarchar(100)not null,
	User_Birsday date not null,
	User_Email varchar(200) unique not null,
	User_Password nvarchar(250) not null,
	Is_Admin bit default 0 not null,
	Is_Activated bit default 0 not null,
	Is_Worker bit default 0 not null,
	Is_User bit default 1 not null,
	Is_Deleted bit default 0 not null
)