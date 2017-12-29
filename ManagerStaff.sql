create database ManagerStaff
go
use ManagerStaff
go
create table Department
(
	MaDV int primary key,
	TenDV nvarchar(50)
)
insert into Department(MaDV, TenDV) values(1,N'IT' )
insert into Department(MaDV, TenDV) values(2,N'Marketing' )
create table Staff(
	MaDV int foreign key REFERENCES  Department(MaDV),
	MaNV int primary key,
	TenNV nvarchar(30)
)
insert into Staff(MaDV,MaNV,TenNV) values(1,1,N'Mai Văn Tú')
insert into Staff(MaDV,MaNV,TenNV) values(1,2,N'Trần Quang Bảo')
insert into Staff(MaDV,MaNV,TenNV) values(2,3,N'Vũ Xuân Quỳnh')
insert into Staff(MaDV,MaNV,TenNV) values(2,4,N'Khánh Nhi')
insert into Staff(MaDV,MaNV,TenNV) values(2,5,N'Trịnh Hồng Đào')