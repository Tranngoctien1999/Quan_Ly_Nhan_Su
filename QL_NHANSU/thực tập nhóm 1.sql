CREATE DATABASE QLNS
GO
USE QLNS
GO

CREATE TABLE [dbo].[DuAn](
	[MaDA] [int] IDENTITY(1,1) NOT NULL,
	[TenDA] [nvarchar](50) NOT NULL,
	[MaPB] [int] NULL,
	[DiaDiem] [nvarchar](50) NULL,
	[tongsogio] [int] NULL,
 CONSTRAINT [PK_DuAn] PRIMARY KEY  
(
	[MaDA] 
)
) 
GO

/****** Object:  Table [dbo].[NguoiDung]    Script Date: 10/20/2020 2:32:54 PM ******/




CREATE TABLE [dbo].[NguoiDung](
	[ID] [varchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY  
(
	[ID] 
)
) 
GO

/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/20/2020 2:32:54 PM ******/




CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[DChi] [nvarchar](50) NULL,
	[GTinh] [nvarchar](10) NULL,
	[Luong] [int] NULL,
	[MaPB] [int] NULL,
	[NgGS] [int] NULL,
	[SoNVDuoiQuyen] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Chucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY  
(
	[MaNV] 
)
) 
GO

/****** Object:  Table [dbo].[PhanCong]    Script Date: 10/20/2020 2:32:54 PM ******/




CREATE TABLE [dbo].[PhanCong](
	[MaNV] [int] NOT NULL,
	[MaDA] [int] NOT NULL,
	[SoGio] [int] NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY  
(
	[MaNV] ,
	[MaDA] 
)
) 
GO

/****** Object:  Table [dbo].[PhongBan]    Script Date: 10/20/2020 2:32:54 PM ******/




CREATE TABLE [dbo].[PhongBan](
	[MaPB] [int] IDENTITY(1,1) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[MaTP] [int] NULL,
	[Ng_NC] [date] NULL,
	[SoNV] [int] NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY  
(
	[MaPB] 
)
) 
GO

/****** Object:  Table [dbo].[ThanNhan]    Script Date: 10/20/2020 2:32:54 PM ******/




CREATE TABLE [dbo].[ThanNhan](
	[MaNV] [int] NOT NULL,
	[TenTN] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[QuanHe] [nvarchar](50) NULL
) 
GO

SET IDENTITY_INSERT [dbo].[DuAn] ON 

INSERT [dbo].[DuAn] ([MaDA], [TenDA], [MaPB], [DiaDiem], [tongsogio]) VALUES (2, N'DA1', 1, N'HN1', 5)
INSERT [dbo].[DuAn] ([MaDA], [TenDA], [MaPB], [DiaDiem], [tongsogio]) VALUES (3, N'DA2', 2, N'HN2', 6)
SET IDENTITY_INSERT [dbo].[DuAn] OFF

INSERT [dbo].[NguoiDung] ([ID], [pass]) VALUES (1, N'123')
INSERT [dbo].[NguoiDung] ([ID], [pass]) VALUES (2, N'123')

SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DChi], [GTinh], [Luong], [MaPB], [NgGS], [SoNVDuoiQuyen], [Email], [SDT], [Chucvu]) VALUES (1, N'NV1', CAST(0x65240B00 AS Date), N'QN', N'Nam', 7000000, 1, NULL, 1, N'nv1@gmail.com', N'0123456789', N'Tp1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DChi], [GTinh], [Luong], [MaPB], [NgGS], [SoNVDuoiQuyen], [Email], [SDT], [Chucvu]) VALUES (2, N'NV2', CAST(0x84240B00 AS Date), N'QB', N'Nữ', 6000000, 1, 1, 0, N'nv2@gmail.com', N'0123789456', N'Nv1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DChi], [GTinh], [Luong], [MaPB], [NgGS], [SoNVDuoiQuyen], [Email], [SDT], [Chucvu]) VALUES (3, N'NV3', CAST(0xA4240B00 AS Date), N'DN', N'Nam', 7500000, 2, NULL, 1, N'nv3@gmail.com', N'0456789123', N'Tp2')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DChi], [GTinh], [Luong], [MaPB], [NgGS], [SoNVDuoiQuyen], [Email], [SDT], [Chucvu]) VALUES (4, N'NV4', CAST(0xC3240B00 AS Date), N'DL', N'Nữ', 6500000, 2, 3, 0, N'nv4@gmail.com', N'0789123456', N'Nv2')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[PhanCong] ([MaNV], [MaDA], [SoGio]) VALUES (1, 2, 2)
INSERT [dbo].[PhanCong] ([MaNV], [MaDA], [SoGio]) VALUES (2, 2, 3)
INSERT [dbo].[PhanCong] ([MaNV], [MaDA], [SoGio]) VALUES (3, 3, 4)
INSERT [dbo].[PhanCong] ([MaNV], [MaDA], [SoGio]) VALUES (4, 3, 2)
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [Ng_NC], [SoNV]) VALUES (1, N'PB1', 1, CAST(0x693A0B00 AS Date), 2)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [MaTP], [Ng_NC], [SoNV]) VALUES (2, N'PB2', 3, CAST(0x493A0B00 AS Date), 2)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
INSERT [dbo].[ThanNhan] ([MaNV], [TenTN], [GioiTinh], [NgaySinh], [QuanHe]) VALUES (1, N'TN1', N'Nữ', CAST(0x65240B00 AS Date), N'Vợ')
INSERT [dbo].[ThanNhan] ([MaNV], [TenTN], [GioiTinh], [NgaySinh], [QuanHe]) VALUES (2, N'TN2', N'Nam', CAST(0x84240B00 AS Date), N'Chồng')
INSERT [dbo].[ThanNhan] ([MaNV], [TenTN], [GioiTinh], [NgaySinh], [QuanHe]) VALUES (2, N'TN3', N'Nam', CAST(0xFB070B00 AS Date), N'Bố')



ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([NgGS])
REFERENCES [dbo].[NhanVien] ([MaNV])


ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])


ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_DuAn] FOREIGN KEY([MaDA])
REFERENCES [dbo].[DuAn] ([MaDA])


ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])

ALTER TABLE [dbo].[PhongBan]  WITH CHECK ADD  CONSTRAINT [FK_PhongBan_NhanVien] FOREIGN KEY([MaTP])
REFERENCES [dbo].[NhanVien] ([MaNV])


ALTER TABLE [dbo].[ThanNhan]  WITH CHECK ADD  CONSTRAINT [FK_ThanNhan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])

