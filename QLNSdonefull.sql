
CREATE DATABASE [QLNS]
 
USE [QLNS]

CREATE TABLE [dbo].[BAOCAOCONGNO](
	[MaKhachHang] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[NoDau] [int] NOT NULL,
	[NoCuoi] [int] NOT NULL,
	[PhatSinh] [int] NULL,
 CONSTRAINT [PK_BAOCAOCONGNO] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC,
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAOCAOTON]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON](
	[MaSach] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[TonDau] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
 CONSTRAINT [PK_BAOCAOTON] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HOADON]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOADON](
	[MaSach] [int] NOT NULL,
	[SoHD] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_CT_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAPSACH]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAPSACH](
	[SoPNS] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaNhap] [int] NOT NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUNHAPSACH] PRIMARY KEY CLUSTERED 
(
	[SoPNS] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHD] [int] NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgayLap] [datetime] NULL,
	[ThanhToan] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [int] NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SoTienNo] [int] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNhaXuatBan] [int] NOT NULL,
	[TenNhaXuatBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAPSACH]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPSACH](
	[SoPNS] [int] NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_PHIEUNHAPSACH_1] PRIMARY KEY CLUSTERED 
(
	[SoPNS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUTIEN]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN](
	[SoPT] [int] NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgayLap] [date] NOT NULL,
	[SoTienThu] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY CLUSTERED 
(
	[SoPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [int] NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaTheLoai] [int] NULL,
	[MaNhaXuatBan] [int] NULL,
	[GiaBan] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[TacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[SoLuongNhapToiThieu] [int] NOT NULL,
	[SoLuongTonToiThieu] [int] NOT NULL,
	[SoLuongTonToiDa] [int] NOT NULL,
	[SoTienNoToiDa] [int] NULL,
	[ApDungQD4] [nvarchar](50) NOT NULL,
	[MatKhauAdmin] [nvarchar](50) NULL,
	[MatKhauNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[ApDungQD4] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 7/9/2021 11:37:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTheLoai] [int] NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAOCAOCONGNO] ([MaKhachHang], [Thang], [Nam], [NoDau], [NoCuoi], [PhatSinh]) VALUES (1, 6, 2021, 0, 25000, 25000)
INSERT [dbo].[BAOCAOCONGNO] ([MaKhachHang], [Thang], [Nam], [NoDau], [NoCuoi], [PhatSinh]) VALUES (1, 7, 2021, 25000, 24425000, 24400000)
GO
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (0, 6, 2021, 0, 192, 192)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (0, 7, 2021, 192, 292, 100)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (1, 6, 2021, 0, 300, 300)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (1, 7, 2021, 300, 250, -50)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (2, 6, 2021, 0, 190, 190)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (2, 7, 2021, 190, 390, 200)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (3, 6, 2021, 0, 310, 310)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (3, 7, 2021, 310, 310, 0)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (4, 6, 2021, 0, 220, 220)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (4, 7, 2021, 220, 320, 100)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (5, 6, 2021, 0, 140, 140)
INSERT [dbo].[BAOCAOTON] ([MaSach], [Thang], [Nam], [TonDau], [TonCuoi], [PhatSinh]) VALUES (5, 7, 2021, 140, 290, 150)
GO
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (0, 1, 22500, 20, 450000)
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (0, 6, 114000, 100, 11400000)
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (1, 3, 22500, 10, 225000)
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (1, 5, 120000, 50, 6000000)
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (1, 6, 120000, 100, 12000000)
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (2, 2, 22500, 20, 450000)
INSERT [dbo].[CT_HOADON] ([MaSach], [SoHD], [DonGia], [SoLuong], [ThanhTien]) VALUES (5, 4, 225000, 100, 22500000)
GO
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, 0, 10, 20000, 200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, 1, 10, 20000, 200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, 2, 10, 20000, 200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, 3, 10, 20000, 200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, 4, 10, 20000, 200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (1, 5, 10, 20000, 200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (2, 0, 2, 15000, 30000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (3, 5, 10, 25000, 250000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (4, 1, 300, 15000, 4500000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (5, 0, 200, 15000, 3000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (6, 3, 150, 20000, 3000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (7, 3, 150, 20000, 3000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (8, 2, 200, 15000, 3000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (9, 4, 110, 55000, 6050000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (10, 5, 120, 60000, 7200000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (11, 4, 100, 50000, 5000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (12, 5, 150, 150000, 22500000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (13, 2, 100, 50000, 5000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (14, 0, 100, 76000, 7600000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (14, 2, 100, 66000, 6600000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (14, 4, 100, 93000, 9300000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (14, 5, 100, 97000, 9700000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (15, 1, 100, 80000, 8000000)
INSERT [dbo].[CT_PHIEUNHAPSACH] ([SoPNS], [MaSach], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (16, 0, 100, 76000, 7600000)
GO
INSERT [dbo].[HOADON] ([SoHD], [MaKhachHang], [NgayLap], [ThanhToan]) VALUES (1, 1, CAST(N'2021-06-24T10:38:59.857' AS DateTime), 450000)
INSERT [dbo].[HOADON] ([SoHD], [MaKhachHang], [NgayLap], [ThanhToan]) VALUES (2, 1, CAST(N'2021-06-24T10:39:12.493' AS DateTime), 450000)
INSERT [dbo].[HOADON] ([SoHD], [MaKhachHang], [NgayLap], [ThanhToan]) VALUES (3, 1, CAST(N'2021-06-24T10:44:01.117' AS DateTime), 225000)
INSERT [dbo].[HOADON] ([SoHD], [MaKhachHang], [NgayLap], [ThanhToan]) VALUES (4, 1, CAST(N'2021-07-04T21:27:14.537' AS DateTime), 22500000)
INSERT [dbo].[HOADON] ([SoHD], [MaKhachHang], [NgayLap], [ThanhToan]) VALUES (5, 1, CAST(N'2021-07-08T21:18:30.627' AS DateTime), 6000000)
INSERT [dbo].[HOADON] ([SoHD], [MaKhachHang], [NgayLap], [ThanhToan]) VALUES (6, 1, CAST(N'2021-07-09T11:28:17.183' AS DateTime), 23400000)
GO
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [DiaChi], [SDT], [Email], [SoTienNo]) VALUES (1, N'Nguyen Long', N'So 4 duong 31C an phu quan 2', N'0834644336', N'sieutromlong1412@gmail.com', 24425000)
GO
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (1, N'Nhà xuất bản Hội nhà văn')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (2, N'Nhà xuất bản Lao động')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (3, N'Nhà xuất bản GIà')
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan]) VALUES (4, N'Nhà xuất bản Giáo dục')
GO
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (1, CAST(N'2021-06-12' AS Date), 200000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (2, CAST(N'2021-06-12' AS Date), 30000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (3, CAST(N'2021-06-12' AS Date), 250000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (4, CAST(N'2021-06-18' AS Date), 4500000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (5, CAST(N'2021-06-18' AS Date), 3000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (6, CAST(N'2021-06-18' AS Date), 3000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (7, CAST(N'2021-06-18' AS Date), 3000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (8, CAST(N'2021-06-20' AS Date), 3000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (9, CAST(N'2021-06-25' AS Date), 6050000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (10, CAST(N'2021-06-25' AS Date), 7200000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (11, CAST(N'2021-06-29' AS Date), 5000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (12, CAST(N'2021-07-04' AS Date), 22500000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (13, CAST(N'2021-07-07' AS Date), 5000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (14, CAST(N'2021-07-08' AS Date), 33200000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (15, CAST(N'2021-07-09' AS Date), 8000000)
INSERT [dbo].[PHIEUNHAPSACH] ([SoPNS], [NgayNhap], [TongTien]) VALUES (16, CAST(N'2021-07-09' AS Date), 7600000)
GO
INSERT [dbo].[PHIEUTHUTIEN] ([SoPT], [MaKhachHang], [NgayLap], [SoTienThu]) VALUES (1, 1, CAST(N'2021-06-24' AS Date), 500000)
INSERT [dbo].[PHIEUTHUTIEN] ([SoPT], [MaKhachHang], [NgayLap], [SoTienThu]) VALUES (2, 1, CAST(N'2021-06-25' AS Date), 600000)
INSERT [dbo].[PHIEUTHUTIEN] ([SoPT], [MaKhachHang], [NgayLap], [SoTienThu]) VALUES (3, 1, CAST(N'2021-07-04' AS Date), 500000)
INSERT [dbo].[PHIEUTHUTIEN] ([SoPT], [MaKhachHang], [NgayLap], [SoTienThu]) VALUES (4, 1, CAST(N'2021-07-08' AS Date), 22000000)
INSERT [dbo].[PHIEUTHUTIEN] ([SoPT], [MaKhachHang], [NgayLap], [SoTienThu]) VALUES (5, 1, CAST(N'2021-07-08' AS Date), 5000000)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTheLoai], [MaNhaXuatBan], [GiaBan], [SoLuongTon], [TacGia]) VALUES (0, N'Đắc Nhân Tâm', 4, 2, 76000, 292, N'Dale Carnegie')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTheLoai], [MaNhaXuatBan], [GiaBan], [SoLuongTon], [TacGia]) VALUES (1, N'Siêu Trí Nhớ', 4, 2, 80000, 250, N'Dominic O''Brien')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTheLoai], [MaNhaXuatBan], [GiaBan], [SoLuongTon], [TacGia]) VALUES (2, N'Tuổi Trẻ Đáng Giá Bao Nhiêu', 3, 2, 66000, 390, N'Rosie Nguyễn')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTheLoai], [MaNhaXuatBan], [GiaBan], [SoLuongTon], [TacGia]) VALUES (3, N'Nhà Giả Kim', 3, 2, 70000, 310, N'Paulo Coelho')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTheLoai], [MaNhaXuatBan], [GiaBan], [SoLuongTon], [TacGia]) VALUES (4, N'Chiến Binh Cầu Vồng', 4, 3, 93000, 320, N'Andrea Hinata')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTheLoai], [MaNhaXuatBan], [GiaBan], [SoLuongTon], [TacGia]) VALUES (5, N'Hiệu Sách Nhỏ Ỏ Paris', 3, 3, 97000, 290, N'Nina George')
GO
INSERT [dbo].[THAMSO] ([SoLuongNhapToiThieu], [SoLuongTonToiThieu], [SoLuongTonToiDa], [SoTienNoToiDa], [ApDungQD4], [MatKhauAdmin], [MatKhauNV]) VALUES (100, 20, 300, 15000000, N'1', N'admin', N'nhanvien')
GO
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Hề hước')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Trinh thám')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'Tiểu thuyết')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (4, N'Kỹ năng sống')
GO
ALTER TABLE [dbo].[BAOCAOCONGNO]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOCONGNO_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[BAOCAOCONGNO] CHECK CONSTRAINT [FK_BAOCAOCONGNO_KHACHHANG]
GO
ALTER TABLE [dbo].[BAOCAOTON]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[BAOCAOTON] CHECK CONSTRAINT [FK_BAOCAOTON_SACH]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HOADON] FOREIGN KEY([SoHD])
REFERENCES [dbo].[HOADON] ([SoHD])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HOADON]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_SACH]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAPSACH]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAPSACH_PHIEUNHAPSACH] FOREIGN KEY([SoPNS])
REFERENCES [dbo].[PHIEUNHAPSACH] ([SoPNS])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAPSACH] CHECK CONSTRAINT [FK_CT_PHIEUNHAPSACH_PHIEUNHAPSACH]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAPSACH]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAPSACH_SACH1] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAPSACH] CHECK CONSTRAINT [FK_CT_PHIEUNHAPSACH_SACH1]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NhaXuatBan] FOREIGN KEY([MaNhaXuatBan])
REFERENCES [dbo].[NHAXUATBAN] ([MaNhaXuatBan])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NhaXuatBan]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
USE [master]
GO
ALTER DATABASE [QLNS] SET  READ_WRITE 
GO
