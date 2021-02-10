create database DB_PENJUALANPC

use DB_PENJUALANPC

create table Pegawai(
	ID_Admin int identity(1, 1) primary key not null,
	Nama_Admin varchar(30),
	Username_Admin varchar(30),
	Password_Admin varchar(30)
	)

create table Pelanggan(
	ID_Pelanggan int identity(1, 1) primary key not null,
	Nama_Pelanggan varchar(30),
	Username_Pelanggan varchar(30),
	Email_Pelanggan varchar(30),
	Password_Pelanggan varchar(30),
	IsOnline int default 0
	)



CREATE TABLE Barang(
	Kode_Barang varchar(10) primary key not null,
	Nama_Barang varchar(50),
	Merk_Barang varchar(50),
	Stok_Barang int,
	Harga_Barang int,
	Satuan_Barang varchar (50)
)

CREATE TABLE Pembelian(
	Kode_Pembelian int identity(1, 1) primary key not null,
	Nama_Pelanggan varchar(50),
	Nama_Barang varchar(50),
	Merk_Barang varchar(50), 
	Harga_Barang int,
	Jumlah_Item int,
	Total_Harga int
)

create table Nota (
	Kode_Nota int identity(1, 1) primary key not null,
	Nama_Admin varchar(50),
	Nama_Pelanggan varchar(50),
	Nama_Barang varchar(50),
	Merk_Barang varchar(50), 
	Harga_Barang int,
	Jumlah_Item int,
	Total_Harga int
)

insert into Pegawai values
('Farhan Patria', 'farhanpatria', 'ADMIN1')

select * from Pelanggan
select * from Barang
select * from Pembelian
select * from Nota
select * from Pegawai






