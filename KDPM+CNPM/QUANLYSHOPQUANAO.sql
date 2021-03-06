CREATE DATABASE QUANLYSHOPQUANAO
 USE [QUANLYSHOPQUANAO]

 CREATE TABLE SANPHAM
 (
	[MASP] [nchar](10) NOT NULL,
	[TENSP] [nvarchar](50) NULL,
	[HINHANH] [nvarchar](300) NULL,
	[MOTA] [nvarchar](50) NULL,
	[DONGIA] [int] NULL,
	[TRANGTHAI] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
	[MALOAI] [nchar](10) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY (MASP)
 )

CREATE TABLE LOAI
(
	[MALOAI] [nchar](10) NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
	CONSTRAINT [PK_LOAI] PRIMARY KEY (MALOAI)
)

CREATE TABLE KHACHHANG 
(
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[SDT] [char](20) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[USERNAME] [varchar](50) NULL,
	[PASS] [varchar](50) NULL,
	CONSTRAINT [PK_KHACHHANG] PRIMARY KEY (MAKH)
)

CREATE TABLE HOADON 
(
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [int] NOT NULL,
	[NGAYDATHANG] [date] NULL,
	[GIAMGIA] [nvarchar](50) NULL,
	[SDT] [char](20) NULL,
	[TONGTIEN] [int] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[TRANGTHAI] [nvarchar](50) NULL,
	CONSTRAINT [PK_HOADON] PRIMARY KEY (MAHD,MAKH)
)

CREATE TABLE CT_HOADON
(
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[MASP] [nchar](10) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [int] NULL,
	[GIAMGIA] [nvarchar](50) NULL,
	[THANHTIEN] [int] NULL,
	CONSTRAINT [PK_CT_HOADON] PRIMARY KEY (MAHD,MASP)
)

CREATE TABLE NHAPHANG
(
	[MANHAP] [nchar](10) NOT NULL,
	[MASP] [nchar](10) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [int] NULL,
	[THANHTIEN] [int] NULL,
	CONSTRAINT [PK_CT_NHAPHANG] PRIMARY KEY (MANHAP,MASP)
)

CREATE TABLE NHANVIEN
(
	[MANV] [nchar](10) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[HINHANH] [nvarchar](300) NULL,
	[SDT] [char](20) NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[USERNAME] [varchar](50) NULL,
	[PASS] [varchar](50) NULL,
	[CHUCVU] [nchar](10) NULL,
	CONSTRAINT [PK_NHANVIEN] PRIMARY KEY (MANV)
)

CREATE TABLE QUANLY
(
	[MAQL] [nchar](10) NOT NULL,
	[TENQL] [nvarchar](50) NULL,
	[HINHANH] [nvarchar](300) NULL,
	[SDT] [char](20) NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[USERNAME] [varchar](50) NULL,
	[PASS] [varchar](50) NULL,
	[CHUCVU] [nchar](10) NULL,
	CONSTRAINT [PK_QUANLY] PRIMARY KEY (MAQL)
)

ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Loai] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAI] ([MALOAI])

ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])

ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])

ALTER TABLE [dbo].[NHAPHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHAPHANG_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])


INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML001     ', N'ÁO TRẺ EM')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML002     ', N'QUẦN TRẺ EM')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML003     ', N'ÁO NGƯỜI LỚN')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML004     ', N'QUẦN NGƯỜI LỚN')


INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000001', N'Áo thun da cá sấu', N'aothundacasau.jpg', N'Chất vải được dệt từ những sợi vải đan xen vào', 250000, N'CÒN HÀNG', 50, N'ML001     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000002', N'Quần kaki nam', N'quankakinam.jpg', N'Chất liệu:96% Cotton,4% Spandex', 400000, N'CÒN HÀNG', 47, N'ML004     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000003', N'Áo sơ mi trắng', N'aosomi.jpg', N'Chất liệu:100% cotton', 300000, N'CÒN HÀNG', 50, N'ML003     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000004', N'Áo Hoodie', N'aohoodie.jpg', N'Hoddie thời trang trẻ trung', 270000, N'Còn Hàng', 47, N'ML003     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000005', N'Quần Jean', N'quanjean.jpg', N'Chất liệu:95% Cotton,5% Spandex ', 450000, N'CÒN HÀNG', 50, N'ML002     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000006', N'Quần Baggy', N'quanbaggy.jpg', N'Chất liệu:100% cotton,6% Spandex', 350000, N'CÒN HÀNG', 50, N'ML004     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000007', N'Áo da', N'aoda.png', N'chất liệu da cừu màu đen cao cấp', 550000, N'CÒN HÀNG', 50, N'ML003     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000008', N'Áo len', N'aolen.jpg', N'Thiết kế áo cổ bèo cơ bản', 250000, N'CÒN HÀNG', 50, N'ML001     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000009', N'Quần tây', N'quantay.jpg', N'Co giãn Kenta với form dáng slim fit sang trọng', 350000, N'CÒN HÀNG', 50, N'ML004     ')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [HINHANH], [MOTA], [DONGIA], [TRANGTHAI], [SOLUONG], [MALOAI]) VALUES (N'SP00000010', N'Áo thun tay dài', N'aothuntaydai.jpg', N'Chất liệu: cotton 100%, mực in bền màu', 60000, N'CÒN HÀNG', 50, N'ML001     ')


INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [HINHANH], [SDT], [GIOITINH], [USERNAME], [PASS], [CHUCVU]) VALUES (N'NV01', N'Dương Văn Đại', N'vandai.jpg', '0902314882', N'Nam', N'dai', '123', N'Nhân viên     ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [HINHANH], [SDT], [GIOITINH], [USERNAME], [PASS], [CHUCVU]) VALUES (N'NV02', N'Lê Nguyễn Phước Thiện', N'phuocthien.jpg', '0920311192', N'Nam', N'thien', '123', N'Nhân viên     ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [HINHANH], [SDT], [GIOITINH], [USERNAME], [PASS], [CHUCVU]) VALUES (N'NV03', N'Nguyễn Vũ Cảnh', N'vucanh.jpg', '0123999201', N'Nam', N'canh', '123', N'Nhân viên     ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [HINHANH], [SDT], [GIOITINH], [USERNAME], [PASS], [CHUCVU]) VALUES (N'NV04', N'Bùi Khắc Chung', N'khacchung.jpg', '0490230012', N'Nam', N'chung', '123', N'Nhân viên     ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [HINHANH], [SDT], [GIOITINH], [USERNAME], [PASS], [CHUCVU]) VALUES (N'NV05', N'Dương Thanh Công', N'thanhcong.jpg', '0903219999', N'Nam', N'cong', '123', N'Nhân viên     ')

INSERT [dbo].[QUANLY] ([MAQL],[TENQL],[HINHANH],[SDT],[GIOITINH],[USERNAME],[PASS],[CHUCVU]) VALUES (N'QL01', N'Trần Tấn Hiếu', N'tanhieu.jpg', '0394238489', N'Nam', N'hieu', '123', N'Quản lý     ')
