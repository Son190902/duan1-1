CREATE DATABASE DUAN1QLNT
GO
USE DUAN1QLNT
GO
CREATE TABLE Khachhang 
(
	makhach varchar(10) primary key,
	tenkhach nvarchar(20) not null,
	diachi nvarchar(200) not null,
	sdt nvarchar(10) not null,
	gioitinh nvarchar(5) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE Nhanvien 
(
	manhanvien varchar(10) primary key,
	tennhanvien nvarchar(20) not null,
	sdt nvarchar(10) not null,
	diachi nvarchar(200) not null,
	vaitro int not null,
	email nvarchar(50) not null,
	matkhau nvarchar(20) not null,
	trangthai nvarchar(10) not null
	
);

CREATE TABLE Hoadon
(
 mahoadon varchar(10) primary key,
 makhach varchar(10) not null,
 manhanvien varchar(10) not null,
 ngaydathang date not null,
 tiendatcoc decimal(12,0) not null,
 trangthai nvarchar(10) not null,
 CONSTRAINT fk1 FOREIGN KEY(makhach) REFERENCES
 Khachhang(makhach),
 CONSTRAINT fk2  FOREIGN KEY(manhanvien) REFERENCES
 Nhanvien(manhanvien)
);
CREATE TABLE Thanhtoan 
(
	mathanhtoan varchar(10) primary key,
	mahoadon varchar(10) not null,
	ngaythanhtoan date not null,
	sotienthanhtoan decimal(12,0) not null,
	solan int not null ,
	trangthai nvarchar(10) not null,
	FOREIGN KEY(mahoadon) REFERENCES
    Hoadon(mahoadon)
);
CREATE TABLE Loaidichvu 
(
	maloaidichvu varchar(10) primary key,
	tenloaisanpham nvarchar(20) not null,
	trangthai nvarchar(10) not null
	
);
CREATE TABLE Dichvu 
(
	madichvu varchar(10) primary key,
	maloaidichvu varchar(10) not null,
	tendichvu nvarchar(20) not null,
	giadichvu decimal(12,0) not null,
	ngaysudungdichvu date not null,
	trangthai nvarchar(10) not null,
	FOREIGN KEY(maloaidichvu) REFERENCES
    Loaidichvu(maloaidichvu)
);
CREATE TABLE Loaisanpham
(
	maloaisp varchar(10) primary key,
	tenloaisanpham nvarchar(20) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE Sanpham
(
	masanpham varchar(10) primary key,
	tensanpham nvarchar(20) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE Hinhanh
(
	mahh varchar(10) primary key,
	hinhanh nvarchar(400) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE Chatlieu
(
	macl varchar(10) primary key,
	chatlieu nvarchar(20) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE Mausac
(
	mams varchar(10) primary key,
	mausac nvarchar(20) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE Donvi
(
	madv varchar(10) primary key,
	donvitinh nvarchar(20) not null,
	trangthai nvarchar(10) not null
);
CREATE TABLE CTsanpham 
(
	mactsanpham varchar(10)  primary key,
	masanpham varchar(10) not null,
	maloaisp varchar(10) not null,
	soluong int not null,
	giaban  decimal(12,0) not null,
	mahh varchar(10) not null,
	macl varchar(10) not null,
	mams varchar(10) not null,
	madv varchar(10) not null,
	trangthai nvarchar(10) not null,
	CONSTRAINT sp1 FOREIGN KEY(masanpham) REFERENCES
    Sanpham(masanpham),
    CONSTRAINT sp2  FOREIGN KEY(maloaisp) REFERENCES
    Loaisanpham(maloaisp),
	CONSTRAINT sp3  FOREIGN KEY(mahh) REFERENCES
    Hinhanh(mahh),
	CONSTRAINT sp4  FOREIGN KEY(macl) REFERENCES
    Chatlieu(macl),
	CONSTRAINT sp5  FOREIGN KEY(mams) REFERENCES
    Mausac(mams),
	CONSTRAINT sp6  FOREIGN KEY(madv) REFERENCES
    Donvi(madv)
);

CREATE TABLE Chitiethoadon
(
 maCTDH varchar(10) primary key,
 mahoadon varchar(10) not null,
 mactsanpham varchar(10) not null,
 madichvu varchar(10) not null,
 soluong int not null,
 dongia decimal(12,0) not null,
 ngaygiaohang date not null,
 tongtienthanhtoan decimal(12,0) not null,
 trangthai nvarchar(10) not null,
 CONSTRAINT ct1 FOREIGN KEY(mahoadon) REFERENCES
 Hoadon(mahoadon),
  CONSTRAINT ct2  FOREIGN KEY(mactsanpham) REFERENCES
 CTsanpham(mactsanpham),
 CONSTRAINT ct3  FOREIGN KEY(madichvu) REFERENCES
 Dichvu(madichvu)

);