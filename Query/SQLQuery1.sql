CREATE DATABASE HotelDeLuna

use HotelDeLuna

/*============ Table ==================*/

Create Table tbl_Admin(
	adminId int identity(10000,1) Primary Key,
	admin_User nvarchar(50),
	admin_Pass nvarchar(50)
)



Create Table tbl_Staff(
	staff_Id int identity(23000,1) Primary Key,
	firstName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	position nvarchar(50) Not Null,
	phoneNumber nvarchar(50) Not Null,
	email nvarchar(50) Not Null,
	homeAddress nvarchar(50) Not Null,
	--FK_adminId int FOREIGN KEY REFERENCES tbl_Admin(adminId)
);

-- assigned employee for system interaction



Create Table tbl_account(
	acc_id int identity(73000,1) Primary Key,
	acc_User nvarchar(50),
	acc_Pass nvarchar(50)

	
	--FK_adminId int FOREIGN KEY REFERENCES tbl_Admin(adminId)
);



Create Table tbl_Guest(
	Guest_Id int identity(33000,1) Primary Key,
	firstName nvarchar(50) Not Null,
	lastName nvarchar(50) Not Null,
	phoneNumber nvarchar(50) Not Null,
	email nvarchar(50) Not Null,
	RoomType nvarchar(30) default 'TBU',
	RoomNo nvarchar(30) default 'TBU',
	PersonCount nvarchar (30) default 'TBU',
	CheckIn nvarchar(30) default 'TBU',
	CheckOut nvarchar(30) default 'TBU',
	NoOfDays nvarchar(30) default 'TBU',
	IsSettled nvarchar(30) default 'TBU',
	IsClean nvarchar(30) default 'TBU',
)


Create Table tbl_Rooms(
	room_Id int identity(43000,1) Primary Key,
	room_type nvarchar(50),
	room_number nvarchar(30),
	personCount nvarchar(30),
	Guest_Id int  Foreign Key References tbl_Guest(Guest_Id)
)


Create Table tbl_CheckIn(
	checkIn_Id int identity(53000,1) Primary Key,
	Total_Amount decimal(10,2),
	checkIn_date DateTime,
	Guest_Id int  Foreign Key References tbl_Guest(Guest_Id)

)

Create Table tbl_CheckOut(
	checkOut_Id int identity(63000,1) Primary Key,
	checkOut_date DateTime,
	DaysCount nvarchar(30),
	Guest_Id int  Foreign Key References tbl_Guest(Guest_Id)
	
)



---iNSERTING ADMIN ACCOUNT

select * from tbl_Staff

Delete tbl_Staff
where staff_id = 23003;


--Create Table tbl_Guest(
--Create Table tbl_Rooms(
--Create Table tbl_CheckIn(
--Create Table tbl_CheckOut(
Drop table tbl_Guest

 
--tbl_Admin
--tbl_account
select * from tbl_Admin


insert into tbl_Admin
Values('Admin','123')


insert into tbl_account
Values('user','123')




insert into tbl_Staff
Values('Shinet','Sunggayan','Front Desk Receptionist','09329562456','shinettomarii@gmail.com','Naga City, Cebu'),
('Ralph','Bascon','Housekeeping Staff','09329562143','ralph_bascon@gmail.com','Talisay City, Cebu'),
('Jerico','Labajo','Maintenance Staff','09325874569','jericolabajo11@gmail.com','Karihatag City, Surigao'),
('Raffy','Tagalog','Event Coordinator','09569854526','raffytagalog23@gmail.com','San Fernando, Cebu'),
('Lalyn','Ybañez','Finance Manager','09256781234','ybañezlalyn@gmail.com','Minglanilla, Cebu');



