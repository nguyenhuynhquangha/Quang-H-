create database ttnd
go
use ttnd
go
--account
--nong san
--category
--bill
--billinfo
--
create table account
(
	id int IDENTITY PRIMARY KEY,
	firstname nvarchar(50),
	lastname nvarchar(50),
	email nvarchar(50),
	username nvarchar(50) NOT NULL,
	password nvarchar(50) NOT NULL,
)
go
create table cart
(
	id int IDENTITY PRIMARY KEY,
	name nvarchar(50) NOT NULL
)
go
create table category
(
	id int IDENTITY PRIMARY KEY,
	name nvarchar(50) NOT NULL
)
go
create table nongsan
(
	id int IDENTITY PRIMARY KEY,
	name nvarchar(50) NOT NULL,
	idCategory INT NOT NULL,
	price float not null
	foreign key(idCategory) REFERENCES dbo.category(id)
)
go
create table bill
(
	id int IDENTITY PRIMARY KEY,
	DateCheckIn date default getdate(),
	DateCheckOut date ,
	idCart int not null,
	status int not null,
	totalprice float
	foreign key (idCart) REFERENCES dbo.cart(id)
)
go
create table billinfo
(
	id int IDENTITY PRIMARY KEY,
	idBill int not null,
	idNongSan int not null,
	Count INT not null default 0
	foreign key(idBill) REFERENCES dbo.Bill(id),
	foreign key (idNongSan) REFERENCES dbo.nongsan(id)
)
go
--them cart
insert dbo.cart
		(name)
VALUES (N'User 1')
insert dbo.cart
		(name)
VALUES (N'User 2')
insert dbo.cart
		(name)
VALUES (N'User 3')
insert dbo.cart
		(name)
VALUES (N'User 4')
insert dbo.cart
		(name)
VALUES (N'User 5')
insert dbo.cart
		(name)
VALUES (N'User 6')
create PROC getcartlist
as select * from dbo.cart
go
EXEC dbo.getcartlist
--thêm category
insert dbo.category
		(name)
VALUES (N'Rau, củ, quả')
insert dbo.category
		(name)
VALUES (N'Thịt gia súc, gia cầm')
insert dbo.category
		(name)
VALUES (N'Ngũ cốc, gia vị')
insert dbo.category
		(name)
VALUES (N'đồ uống, dược liệu')
--thêm nong san
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Bưởi da xanh',1,50000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Cải bó xôi',1,40000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Xà lách mỡ',1,38000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Cải bẹ xanh',1,35000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Cà chua',1,20000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Dưa Hấu',1,25000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Cà Rốt',1,40000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Khoai tây',1,40000)

insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Gà ta',2,70000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Trứng gà',2,28000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Thịt ba rọi',2,130000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Sườn heo',2,95000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Lạp Xưởng',2,250000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Thịt vịt',2,90000)

insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Nước mắm',3,100000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Gạo Thơm Đài Loan',3,20000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Đậu nành',3,70000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Dầu Olive',3,250000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Nước tương',3,50000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Tương ớt',3,25000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Tương đen',3,20000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Đường trắng',3,15000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Giấm gạo',3,16000)

insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Bia Sài Gòn',4,230000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Cà phê',4,80000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Trà xanh',4,65000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Sữa đậu nành',4,25000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Nước ép',4,40000)
insert dbo.nongsan
		(name,idCategory,price)
VALUES (N'Pepsi',4,10000)
--thêm bill
insert dbo.bill
		(DateCheckIn,DateCheckOut,idCart,status )
VALUES (GETDATE(),Null,1,0)
insert dbo.bill
		(DateCheckIn,DateCheckOut,idCart,status )
VALUES (GETDATE(),GETDATE(),2,1)
--thêm billinfo
insert dbo.billinfo
		(idBill, idNongSan,COUNT )
VALUES (1,3,2)
insert dbo.billinfo
		(idBill, idNongSan,COUNT )
VALUES (2,1,4)
CREATE PROC Insertbill
@idCart int
as
begin
	insert dbo.bill
		(DateCheckIn,DateCheckOut,idCart,status)
	values (GETDATE(),null,@idCart,0)
end
go
Create PROC InsertBillInfo
@idBill int,@idNongSan int,@COUNT  int
as
begin
	declare @isExitBillInfo int
	declare @nscount int=1
	select @isExitBillInfo=id,@nscount=b.count 
	from dbo.billinfo as b  
	where id=@idBill AND idNongSan=@idNongSan
	if(@isExitBillInfo>0)
	begin
		declare @newCount int=@nscount+@count
		if(@newCount>0)
			update dbo.billinfo set count=@nscount+@count where idNongSan=@idNongSan
		else
			delete dbo.billinfo where idBill=@idBill and idNongSan=@idNongSan
	end
	else
	begin
		insert dbo.billinfo
			(idBill,idNongSan,COUNT)
		values (@idBill,@idNongSan,@COUNT)
	end
end
go


create proc getlistbill
@checkin date, @checkout date
as
begin
	select c.name,DateCheckIn,DateCheckOut,b.totalprice
	from dbo.bill as b, dbo.cart as c
	where DateCheckIn> = @checkin and DateCheckOut <= @checkout and b.status=1 and	c.id=b.idCart
end
go

