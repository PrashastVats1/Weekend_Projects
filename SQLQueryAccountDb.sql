create database AccountsDb

use AccountsDb

create table Account
(Id int primary key identity(1,1),
EmpId as 'EmpId'+cast(Id as nvarchar(20)) persisted,
UserName nvarchar(50) not null,
Email nvarchar(50) not null,
Password as left(UserName,4)+'&'+cast(Id as nvarchar(20))+right(UserName,2),
City nvarchar(20))

create proc signup(@uName nvarchar(50),@email nvarchar(50),@city nvarchar(20))
as
begin
insert into Account values(@uName,@email,@city)
end

insert into Account values('Prahast','prahast@gmail.com','Bengaluru')
select * from Account