CREATE DATABASE QLNV_KiemTra
ON
(	NAME = 'QLNV_KiemTra_data',
	FILENAME = 'C:\Code\QLNV_KiemTra_data.mdf'
)
LOG ON
(	NAME = 'QLNV_KiemTra_log',
	FILENAME = 'C:\Code\QLNV_KiemTra_data.ldf'
);
GO

USE QLNV_KiemTra;
GO

CREATE TABLE PhongBan(
	MaPB INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	TenPB NVARCHAR(30) NOT NULL
);
GO
CREATE TABLE NhanVien(
	MaNV INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	HoTenNV NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(100) NOT NULL,
	NgaySinh DATE,
	DiaChiNV NVARCHAR(255),
	SdtNV NVARCHAR(24),
	MaPB INT,
	FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB)
);
GO
CREATE TABLE TaiKhoan(
	TaiKhoan VARCHAR(255) PRIMARY KEY,
	MatKhau VARCHAR(255),
	Quyen VARCHAR(255)
);
GO
INSERT INTO PhongBan (TenPB)
VALUES
('Phòng Ban A'),
('Phòng Ban B'),
('Phòng Ban C');
GO
INSERT INTO NhanVien (HoTenNV, GioiTinh, NgaySinh, DiaChiNV, SdtNV, MaPB)
VALUES
(N'Nguyen Van A', N'Nam', '1990-01-01', N'DiaChi A', '123456789', 1),
(N'Tran Thi B', N'Nữ', '1995-05-05', N'DiaChi B', '987654321', 2),
(N'Le Van C', N'Nam', '1988-10-10', N'DiaChi C', '111222333', 3);
GO
INSERT INTO TaiKhoan (TaiKhoan, MatKhau, Quyen)
VALUES
('admin', '0000', 'administration');

SELECT *
FROM NhanVien

