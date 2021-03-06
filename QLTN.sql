USE [QLTN]
GO
/****** Object:  Table [dbo].[BAITHI]    Script Date: 7/22/2018 12:00:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAITHI](
	[MASV] [char](8) NOT NULL,
	[MAMH] [char](5) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[MACAUHOI] [int] NOT NULL,
	[CAUTRALOI] [nchar](1) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_9C691205F53D4F2DAA4FFA938E52F7CB]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC,
	[MACAUHOI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANGDIEM](
	[MASV] [char](8) NOT NULL,
	[MAMH] [char](5) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[NGAYTHI] [datetime] NULL DEFAULT (getdate()),
	[DIEM] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_FDCDC518849D45468524A29F5AA864C9]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BODE]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BODE](
	[MAMH] [char](5) NULL,
	[CAUHOI] [int] NOT NULL,
	[TRINHDO] [char](1) NULL,
	[NOIDUNG] [ntext] NULL,
	[A] [nvarchar](80) NULL,
	[B] [nvarchar](80) NULL,
	[C] [nvarchar](80) NULL,
	[D] [nvarchar](80) NULL,
	[DAP_AN] [char](1) NULL,
	[MAGV] [char](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_4CB922378FB84342A787553C0E9194DD]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[CAUHOI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COSO]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COSO](
	[MACS] [nchar](3) NOT NULL,
	[TENCS] [nvarchar](40) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_08F5EC9492394203976643922FB78DA1]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MACS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MAGV] [char](8) NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[HOCVI] [nvarchar](40) NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A5836994B5F6446C83A7E8CEDA4F034E]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN_DANGKY]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN_DANGKY](
	[MAGV] [char](8) NULL,
	[MALOP] [char](8) NOT NULL,
	[MAMH] [char](5) NOT NULL,
	[TRINHDO] [char](1) NULL,
	[NGAYTHI] [datetime] NULL DEFAULT (getdate()),
	[LAN] [smallint] NOT NULL,
	[SOCAUTHI] [smallint] NULL,
	[THOIGIAN] [smallint] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_3477C29D0D4843209259C4AD7856680B]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [nchar](8) NOT NULL,
	[TENKH] [nvarchar](40) NULL,
	[MACS] [nchar](3) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_D17320839D4844E1852EEC50B0138EBE]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [char](8) NOT NULL,
	[TENLOP] [nvarchar](40) NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_FEC99880713A42D29F0B17FC3E8B803B]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK__LOP__7A3DE2113B8D9919] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](5) NOT NULL,
	[TENMH] [nvarchar](40) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_88230E14BCAA4A98A7A511C6FE79C280]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](8) NOT NULL,
	[HO] [varchar](40) NULL,
	[TEN] [varchar](10) NULL,
	[NGAYSINH] [datetime] NULL,
	[DIACHI] [nvarchar](50) NULL,
	[MALOP] [char](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_B42BD64C59554E0C86B7DC452137EE24]  DEFAULT (newsequentialid()),
PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_ds_phanmanh]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view  [dbo].[v_ds_phanmanh] as
SELECT  PUBS.description AS COSO, SUBS.subscriber_server AS TENSERVER
FROM  dbo.sysmergepublications AS PUBS INNER JOIN
      dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid
	  AND PUBS.publisher <> SUBS.subscriber_server
GO
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 1, N'C', N'b46820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 24, N'D', N'b16820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 27, N'A', N'b66820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 28, N'A', N'b36820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 50, N'B', N'b86820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 54, N'A', N'b26820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 55, N'C', N'b76820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 58, N'D', N'b56820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 225, N'B', N'af6820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, 228, N'C', N'b06820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 1, N'D', N'b464c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 6, N'C', N'ac64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 20, N'B', N'ad64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 22, N'B', N'b764c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 23, N'B', N'bc64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 26, N'B', N'b564c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 27, N'B', N'b064c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 28, N'B', N'b264c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 29, N'C', N'b164c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 50, N'B', N'ab64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 51, N'C', N'b364c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 52, N'D', N'b964c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 53, N'C', N'ae64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 54, N'A', N'bb64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 55, N'C', N'b664c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 56, N'D', N'af64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 57, N'C', N'b864c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 58, N'B', N'a964c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 59, N'C', N'aa64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, 228, N'B', N'ba64c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 7, N'B', N'78e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 13, N'C', N'6de206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 14, N'D', N'67e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 15, N'C', N'64e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 17, N'B', N'6fe206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 18, N'B', N'72e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 81, N'B', N'7ae206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 83, N'A', N'73e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 86, N'C', N'74e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 87, N'D', N'76e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 89, N'B', N'63e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 95, N'B', N'69e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 97, N'D', N'79e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 100, N'A', N'6ae206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 101, N'C', N'7de206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 105, N'B', N'7ce206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 111, N'C', N'66e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 113, N'C', N'71e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 116, N'B', N'6be206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 118, N'C', N'62e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 121, N'A', N'6ce206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 122, N'D', N'70e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 123, N'C', N'68e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 128, N'B', N'77e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 129, N'C', N'61e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 131, N'B', N'75e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 132, N'A', N'7be206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 133, N'A', N'65e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 134, N'D', N'6ee206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BAITHI] ([MASV], [MAMH], [LAN], [MACAUHOI], [CAUTRALOI], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, 140, N'A', N'7ee206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BANGDIEM] ([MASV], [MAMH], [LAN], [NGAYTHI], [DIEM], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 1, CAST(N'2017-12-10 00:00:00.000' AS DateTime), 1, N'ae6820e2-5edd-e711-9bd1-08edb98553be')
INSERT [dbo].[BANGDIEM] ([MASV], [MAMH], [LAN], [NGAYTHI], [DIEM], [rowguid]) VALUES (N'N14DC080', N'AVCB ', 2, CAST(N'2017-12-10 00:00:00.000' AS DateTime), 2, N'a864c5fb-5ddd-e711-9bd1-08edb98553be')
INSERT [dbo].[BANGDIEM] ([MASV], [MAMH], [LAN], [NGAYTHI], [DIEM], [rowguid]) VALUES (N'N14DC080', N'MMTCB', 2, CAST(N'2017-12-09 00:00:00.000' AS DateTime), 2, N'60e206b2-ccdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 1, N'A', N'mạng máy tính(compute netword) so với hệ thống tập trung multi-user', N'dễ phát triển hệ thống', N'tăng độ tin cậy', N'tiết kiệm chi phí', N'tất cả đều đúng', N'D', N'TH657   ', N'69be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 3, N'A', N'để một máy tính truyền dữ liệu cho một số máy khác trong mạng, ta dùng loại địa chỉ', N'Broadcast', N'Broadband', N'multicast', N'multiple access', N'C', N'TH123   ', N'6abe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 4, N'A', N'thứ tự phân loại mạng theo chiều dài đường truyền', N'internet, lan, man, wan', N'internet, wan, man, lan', N'lan, wan, man, internet', N'man, lan, wan, internet', N'B', N'TH123   ', N'6bbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 5, N'A', N'mạng man được sử dụng trong phạm vi:', N'quốc gia', N'lục địa', N'khu phố', N'thành phố', N'D', N'TH123   ', N'6cbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 6, N'A', N'thuật ngữ man được viết tắt bởi:', N'middle area network', N'metropolitan area network', N'medium area network', N'multiple access network', N'D', N'TH123   ', N'6dbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 7, N'A', N'mạng man không kết nối theo sơ đồ:', N'bus', N'ring', N'star', N'tree', N'D', N'TH123   ', N'6ebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 8, N'A', N'kiến trúc mạng (network architechture) là:', N'tập các chức năng trong mạng', N'tập các cấp và các protocol trong mỗi cấp', N'tập các dịch vụ trong mạng', N'tập các protocol trong mạng', N'B', N'TH123   ', N'6fbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 9, N'A', N'thuật ngữ nào không cùng nhóm:', N'simplex', N'multiplex', N'half duplex', N'full duplex', N'B', N'TH123   ', N'70be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 10, N'A', N'loại dịch vụ nào có thể nhận dữ liệu không đúng thứ tự khi truyền', N'point to point', N'có kết nối', N'không kết nối', N'broadcast', N'C', N'TH123   ', N'71be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 11, N'A', N'dịch vụ không xác nhận (unconfirmed) chỉ sử dụng 2 phép toán cơ bản:', N'response and confirm', N'confirm and request', N'request and indication', N'indication and response', N'C', N'TH123   ', N'72be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 12, N'A', N'Chọn câu sai trong các nguyên lý phân cấp của mô hình OSI', N'Mỗi cấp thực hiện 1 chức năng rõ ràng', N'Mỗi cấp được chọn sao cho thông tin trao đổi giữa các cấp tối thiểu', N'Mỗi cấp được tạo ra ứng với 1 mức trừu tượng hóa', N'Mỗi cấp phải cung cấp cùng 1 kiểu địa chỉ và dịch vụ', N'D', N'TH123   ', N'73be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 13, N'A', N'Chức năng của cấp vật lý(physical)', N'Qui định truyền 1 hay 2 chiều', N'Quản lý lỗi sai', N'Xác định thời gian truyền 1 bit dữ liệu', N'Quản lý địa chỉ vật lý', N'C', N'TH123   ', N'74be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 14, N'A', N'Chức năng câp liên kết dữ liệu (data link)', N'Quản lý lỗi sai', N'Mã hóa dữ liệu', N'Tìm đường đi cho dữ liệu', N'Chọn kênh truyền', N'A', N'TH123   ', N'75be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 15, N'A', N'Chức năng cấp mạng (network)', N'Quản lý lưu lượng đường truyền', N'Điều khiển hoạt động subnet', N'Nén dữ liệu', N'Chọn điện áp trên kênh truyền', N'B', N'TH123   ', N'76be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 16, N'A', N'Chức năng cấp vận tải (transport) ', N'Quản lý địa chỉ mạng', N'Chuyển đổi các dạng frame khác nhau', N'Thiết lập và hủy bỏ dữ liệu', N'Mã hóa và giải mã dữ liệu', N'C', N'TH123   ', N'77be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 17, N'A', N'Cáp xoắn đôi trong mạng LAN dùng đầu nối', N'AUI', N'BNC', N'RJ11', N'RJ45', N'D', N'TH123   ', N'78be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 18, N'A', N'T-connector dùng trong loại cáp', N'10Base-2', N'10Base-5', N'10Base-T', N'10Base-F', N'A', N'TH123   ', N'79be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 19, N'A', N'chọn câu sai trong các nguyên lý phân cấp của mô hình osi', N'mỗi cấp thực hiện 1 chức năng rõ ràng', N'mỗi cấp được chọn sao cho thông tin trao đổi giữa các cấp tối thiểu', N'mỗi cấp được tạo ra ứng với 1 mức trừu tượng hóa', N'mỗi cấp phải cung cấp cùng một kiểu địa chỉ và dịch vụ', N'D', N'TH123   ', N'7abe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 20, N'A', N'The publishers suggested that the envelopes be sent to ...... by courier so that the film can be developed as soon as possible', N'they', N'their', N'theirs', N'them', N'D', N'TH234   ', N'7bbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 21, N'A', N'Board members ..... carefully define their goals and objectives for the agency before the monthly meeting next week.', N'had', N'should', N'used ', N'have', N'B', N'TH234   ', N'7cbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 22, N'A', N'For business relations to continue between our two firms, satisfactory agreement must be ...... reached and signer', N'yet', N'both', N'either ', N'as well as', N'C', N'TH234   ', N'7dbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 23, N'A', N'The corporation, which underwent a major restructing seven years ago, has been growing steadily ......five years', N'for', N'on', N'from', N'since', N'A', N'TH234   ', N'7ebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 24, N'A', N'Making advance arrangements for audiovisual equipment is....... recommended for all seminars.', N'sternly', N'strikingly', N'stringently', N'strongly', N'A', N'TH234   ', N'7fbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 25, N'A', N'Two assistants will be required to ...... reporter''s names when they arrive at the press conference', N'remark', N'check', N'notify', N'ensure', N'B', N'TH234   ', N'80be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 26, N'A', N'The present government has an excellent ......to increase exports', N'popularity', N'regularity', N'celebrity', N'opportunity', N'D', N'TH234   ', N'81be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 27, N'A', N'While you are in the building, please wear your identification badge at all times so that you are ....... as a company employee.', N'recognize', N'recognizing', N'recognizable', N'recognizably', N'C', N'TH234   ', N'82be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 28, N'A', N'Our studies show that increases in worker productivity have not been adequately .......rewarded by significant increases in ......', N'compensation', N'commodity', N'compilation', N'complacency', N'B', N'TH234   ', N'83be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 29, N'A', N'Conservatives predict that government finaces will remain...... during the period of the investigation', N'authoritative', N'summarized', N'examined', N'stable', N'D', N'TH234   ', N'84be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 30, N'B', N'Battery-operated reading lamps......very well right now', N'sale', N'sold', N'are selling', N'were sold', N'C', N'TH234   ', N'85be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 31, N'B', N'In order to place a call outside the office, you have to .......nine first. ', N'tip', N'make', N'dial', N'number', N'D', N'TH234   ', N'86be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 32, N'B', N'We are pleased to inform...... that the missing order has been found.', N'you', N'your', N'yours', N'yourseld', N'A', N'TH234   ', N'87be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 33, N'B', N'Unfortunately, neither Mr.Sachs....... Ms Flynn will be able to attend the awards banquet this evening', N'but', N'and', N' nor', N'either', N'C', N'TH234   ', N'88be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 34, N'B', N'According to the manufacturer, the new generatir is capable of....... the amount of power consumed by our facility by nearly ten percent.', N'reduced', N'reducing', N'reduce', N'reduces', N'B', N'TH234   ', N'89be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 35, N'B', N'After the main course, choose from our wide....... of homemade deserts', N'varied', N'various', N'vary', N'variety', N'D', N'TH234   ', N'8abe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 36, N'B', N'One of the most frequent complaints among airline passengers is that there is not ...... legroom', N'enough', N'many', N'very', N'plenty', N'A', N'TH234   ', N'8bbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 37, N'B', N'Faculty members are planning to..... a party in honor of Dr.Walker, who will retire at the end of the semester', N'carry', N'do', N'hold', N'take', N'D', N'TH234   ', N'8cbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 38, N'B', N'Many employees seem more ....... now about how to use the new telephone system than they did before they attended the workshop', N'confusion', N'confuse', N'confused', N'confusing', N'C', N'TH234   ', N'8dbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 39, N'B', N'.........our production figures improve in the near future, we foresee having to hire more people between now and July', N'During', N'Only', N'Unless', N'Because', N'D', N'TH234   ', N'8ebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 40, N'C', N'Though their performance was relatively unpolished, the actors held the audience''s ........for the duration of the play.', N'attentive', N'attentively', N'attention', N'attentiveness', N'C', N'TH234   ', N'8fbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 41, N'C', N'Dr. Abernathy''s donation to Owstion College broke the record for the largest private gift...... give to the campus', N'always', N'rarely', N'once', N'ever', N'C', N'TH234   ', N'90be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 42, N'C', N'Savat Nation Park is ....... by train,bus, charter plane, and rental car.', N'accessible', N'accessing', N'accessibility', N'accesses', N'A', N'TH234   ', N'91be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 43, N'C', N'In Piazzo''s lastest architectural project, he hopes to......his flare for blending contemporary and traditional ideals.', N'demonstrate', N'appear', N'valve', N'position', N'A', N'TH234   ', N'92be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 44, N'C', N'Replacing the offic equipment that the company purchased only three years ago seems quite.....', N'waste', N'wasteful', N'wasting', N'wasted', N'C', N'TH234   ', N'93be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 45, N'C', N'On........, employees reach their peak performance level when they have been on the job for at least two years.', N'common', N'standard', N'average', N'general', N'D', N'TH234   ', N'94be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 46, N'C', N'We were........unaware of the problems with the air-conidtioning units in the hotel rooms until this week.', N'complete ', N'completely', N'completed', N'completing', N'D', N'TH234   ', N'95be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 47, N'C', N'If you send in an order ....... mail, we recommend that you phone our sales division directly to confirm the order.', N'near', N'by', N'for', N'on', N'A', N'TH234   ', N'96be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 48, N'C', N'A recent global survey suggests.......... demand for aluminum and tin will remain at its current level for the next five to ten years.', N'which', N'it ', N'that', N'both', N'C', N'TH234   ', N'97be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 49, N'C', N'Rates for the use of recreational facilities do not include ta and are subject to change without.........', N'signal', N'cash', N'report', N'notice', N'A', N'TH234   ', N'98be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 50, N'A', N'Aswering telephone calls is the..... of an operator', N'responsible', N'responsibly', N'responsive', N'responsibility', N'D', N'TH234   ', N'99be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 51, N'A', N'A free watch will be provided with every purchase of $20.00 or more a ........ period of time', N'limit', N'limits', N'limited', N'limiting', N'C', N'TH234   ', N'9abe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 52, N'A', N'The president of the corporation has .......arrived in Copenhagen and will meet with the Minister of Trade on Monday morning', N'still', N'yet', N'already', N'soon', N'C', N'TH234   ', N'9bbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 53, N'A', N'Because we value your business, we have .......for card members like you to receive one thousand  dollars of complimentary life insurance', N'arrange', N'arranged', N'arranges', N'arranging', N'B', N'TH234   ', N'9cbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 54, N'A', N'Employees are........that due to the new government regulations. there is to be no smoking in the factory', N'reminded', N'respected', N'remembered', N'reacted', N'A', N'TH234   ', N'9dbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 55, N'A', N'MS. Galera gave a long...... in honor of the retiring vice-president', N'speak', N'speaker', N'speaking', N'speech', N'D', N'TH234   ', N'9ebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 56, N'A', N'Any person who is........ in volunteering his or her time for the campaign should send this office a letter of intent', N'interest', N'interested', N'interesting', N'interestingly', N'B', N'TH234   ', N'9fbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 57, N'A', N'Mr.Gonzales was very concerned.........the upcoming board of directors meeting', N'to', N'about', N'at ', N'upon', N'B', N'TH234   ', N'a0be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 58, N'A', N'The customers were told that no ........could be made on weekend nights because the restaurant was too busy', N'delays', N'cuisines', N'reservation', N'violations', N'C', N'TH234   ', N'a1be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 59, N'A', N'The sales representive''s presentation was difficult to understand ........ he spoke very quickly', N'because', N'althought', N'so that', N'than', N'A', N'TH234   ', N'a2be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 60, N'B', N'It has been predicted that an.......weak dollar will stimulate tourism in the United States', N'increased', N'increasingly', N'increases', N'increase', N'B', N'TH234   ', N'a3be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 61, N'B', N'The firm is not liable for damage resulting from circumstances.........its control.', N'beyond', N'above', N'inside', N'around', N'A', N'TH234   ', N'a4be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 62, N'B', N'Because of.......weather conditions, California has an advantage in the production of fruits and vegetables', N'favorite', N'favor', N'favorable', N'favorably', N'C', N'TH234   ', N'a5be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 63, N'B', N'On international shipments, all duties and taxes are paid by the..........', N'recipient', N'receiving', N'receipt', N'receptive', N'A', N'TH234   ', N'a6be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 64, N'B', N'Although the textbook gives a definitive answer,wise managers will look for........ own creative solutions', N'them', N'their', N'theirs', N'they', N'B', N'TH234   ', N'a7be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 65, N'B', N'Initial ....... regarding the merger of the companies took place yesterday at the Plaza Conference Center.', N'negotiations', N'dedications', N'propositions', N'announcements', N'A', N'TH234   ', N'a8be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 66, N'B', N'Please......... photocopies of all relevant docunments to this office ten days prior to your performance review date', N'emerge', N'substantiate', N'adapt', N'submit', N'D', N'TH234   ', N'a9be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 67, N'B', N'The auditor''s results for the five year period under study were .........the accountant''s', N'same', N'same as', N'the same', N'the same as', N'D', N'TH234   ', N'aabe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 68, N'B', N'.........has the marketing environment been more complex and subject to change', N'Totally', N'Negatively', N'Decidedly', N'Rarely', N'D', N'TH234   ', N'abbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 69, N'B', N'All full-time staff are eligible to participate in the revised health plan, which becomes effective the first ......... the month.', N'of', N'to', N'from', N'for', N'A', N'TH234   ', N'acbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 70, N'C', N'Contracts must be read........ before they are signed.', N'thoroughness', N'more thorough', N'thorough', N'thoroughly', N'D', N'TH234   ', N'adbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 71, N'C', N'Passengers should allow for...... travel time to the airport in rush hour traffic', N'addition', N'additive', N'additionally', N'additional', N'D', N'TH234   ', N'aebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 72, N'C', N'This fiscal year, the engineering team has worked well together on all phases ofproject.........', N'development', N'developed', N'develops', N'developer', N'A', N'TH234   ', N'afbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 73, N'C', N'Mr.Dupont had no ....... how long it would take to drive downtown', N'knowledge', N'thought', N'idea', N'willingness', N'C', N'TH234   ', N'b0be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 74, N'C', N'Small company stocks usually benefit..........the so called January effect that cause the price of these stocks to rise between November and January', N'unless', N'from', N'to ', N'since', N'B', N'TH234   ', N'b1be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 75, N'C', N'It has been suggested that employees ........to work in their current positions until the quarterly review is finished.', N'continuity', N'continue', N'continuing', N'continuous', N'B', N'TH234   ', N'b2be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 76, N'C', N'It is admirable that Ms.Jin wishes to handle all transactions by........, but it might be better if several people shared the responsibility', N'she', N'herself', N'her', N'hers', N'B', N'TH234   ', N'b3be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 77, N'C', N'This new highway construction project will help the company.........', N'diversity', N'clarify', N'intensify', N'modify', N'A', N'TH234   ', N'b4be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 78, N'C', N'Ms.Patel has handed in an ........business plan to the director', N'anxious', N'evident', N'eager', N'outstanding', N'D', N'TH234   ', N'b5be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 79, N'C', N'Recent changes in heating oil costs have affected..........production of turniture', N'local', N'locality', N'locally', N'location', N'A', N'TH234   ', N'b6be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 80, N'A', N'Termiator là linh kiện dùng trong loại cáp mạng', N'Cáp quang', N'UTP và STP ', N'Xoắn đôi', N'Đồng trục', N'D', N'TH123   ', N'b7be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 81, N'A', N'Mạng không dây dùng loại sóng nào không bị ảnh hưởng bởi khoảng cách địa lý', N'Sóng radio', N'Sống hồng ngoại', N'Sóng viba', N'Song cực ngắn', N'A', N'TH123   ', N'b8be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 82, N'A', N'Đường truyền E1 gồm 32 kênh, trong đó sử dụng cho dữ liệu là:', N'32 kênh', N'31 kênh', N'30 kênh', N'24 kênh', N'C', N'TH123   ', N'b9be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 83, N'A', N'Mạng máy tính thường sử dụng loại chuyển mach', N'Gói (packet switch)', N'Kênh (Circuit switch)', N'Thông báo(message switch)', N'Tất cả đều đúng', N'A', N'TH123   ', N'babe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 84, N'A', N'Cáp UTP hỗ trợ tôc độ truyền 100MBps là loại', N'Cat 3', N'Cat 4', N'Cat 5', N'Cat 6', N'C', N'TH123   ', N'bbbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 85, N'A', N'Thiết bị nào làm việc trong cấp vật lý (physical) ', N'Terminator', N'Hub', N'Repeater', N'Tất cả đều đúng', N'D', N'TH123   ', N'bcbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 86, N'A', N'Phương pháp dồn kênh phân chia tần số gọi là', N'FDM', N'WDM', N'TDM', N'CSMA', N'A', N'TH123   ', N'bdbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 87, N'A', N'Dịch vụ nào không sử dụng trong cấp data link', N'Xác nhận, có kết nối', N'Xác nhận, không kết nôi', N'Không xác nhận, có kết nối', N'Không xác nhận, không kết nối', N'C', N'TH123   ', N'bebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 88, N'A', N'Nguyên nhân gây sai sót khi gửi/nhận dữ liệu trên mạng', N'Mất đồng bộ trong khi truyền', N'Nhiễu từ môi trường', N'Lỗi phần cứng hoặc phần mềm', N'Tất cả đều đúng ', N'D', N'TH123   ', N'bfbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 89, N'A', N'Để tránh sai sót khi truyền dữ liệu trong cấp data link', N'Đánh số thứ tự frame', N'Quản lý dữ liệu theo frame', N'Dùng vùng checksum', N'Tất cả đều đúng', N'D', N'TH123   ', N'c0be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 90, N'A', N'Quản lý lưu lượng đường truyền là chức năng của cấp', N'Presentation', N'Network', N'Data link', N'Physical', N'C', N'TH123   ', N'c1be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 91, N'A', N'Hoạt động của protocol Stop and Wait', N'Chờ một khoảng thời gian time-out rồi gửi tiếp frame kế', N'Chờ 1 khoảng thời gian time-out rồi gửi lại frame trước', N'Chờ nhận được ACK của frame trước mới gửi tiếp frame kế', N'Không chờ mà gửi liên tiếp các frame kế nhau', N'C', N'TH123   ', N'c2be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 92, N'A', N'Protocol nào tạo frame bằng phương pháp chèn kí tự', N'ADCCP', N'HDLC', N'SDLC', N'PPP', N'D', N'TH123   ', N'c3be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 93, N'A', N'Phương pháp nào được dủng trong việc phát hiện lỗi', N'Timer', N'Ack', N'Checksum', N'Tất cả đều đúng', N'C', N'TH123   ', N'c4be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 94, N'A', N'Kiểm soát lưu lượng (flow control) có nghĩa là', N'Thay đổi thứ tự truyền frame', N'Điều tiết tốc độ truyền frame', N'Thay đổi thời gian chờ time-out', N'Điều chỉnh kích thước frame', N'B', N'TH123   ', N'c5be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 95, N'A', N'Khả năng nhận biết tình trạng đường truyền ( carrier sence) là', N'Xác định đường truyền tốt hay xấu', N'Có kết nối được hay không', N'Nhận biết có xung đột hay không', N'Đường truyền đang rảnh hay bận', N'C', N'TH123   ', N'c6be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 96, N'A', N'Mạng nào không có khả năng nhận biết tình trạng đường truyền (carrier sence)', N'ALOHA', N'CSMA', N'CSMA/CD', N'Tất cả đều đúng ', N'A', N'TH123   ', N'c7be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 97, N'A', N'Mạng nào có khả năng nhận biết xung đột (collision)', N'ALOHA', N'CSMA', N'CSMA/CD', N'Tất cả đều đúng', N'D', N'TH123   ', N'c8be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 98, N'A', N'Chuẩn mạng nào có khả năng pkhát hiện xung đột (collision) trong khi truyền', N'1-persistent CSMA', N'p-persistent CSMA', N'Non-persistent CSMA', N'CSMA/CD', N'D', N'TH123   ', N'c9be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 99, N'A', N'Loại mạng cục bộ nào dùng chuẩn CSMA/CD', N'Token-ring', N'Token-bus', N'Ethernet', N'ArcNet', N'C', N'TH123   ', N'cabe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 100, N'A', N'Mạng Ethernet được IEEE đưa vào chuẩn', N'IEEE 802.2', N'IEEE 802.3', N'IEEE 802.4', N'IEEE 802.5', N'B', N'TH123   ', N'cbbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 101, N'A', N'Chuẩn nào không dùng trong mạng cục bộ (LAN )', N'IEEE 802.3', N'IEEE 802.4', N'IEEE 802.5', N'IEEE 802.6', N'D', N'TH123   ', N'ccbe34b9-00d8-e711-9bce-08edb98553be')
GO
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 102, N'A', N'Loại mạng nào dùng 1 máy tính làm Monitor để bảo trì mạng', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều sai', N'B', N'TH123   ', N'cdbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 103, N'A', N'Loại mạng nào không có độ ưu tiên', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều sai', N'D', N'TH123   ', N'cebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 104, N'A', N'Loại mạng nào dùng 2 loại frame khác nhau trên đường truyền', N'Token-ring', N'Token-bus', N'Ethernet', N'Tất cả đều sai', N'A', N'TH123   ', N'cfbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 105, N'A', N'Vùng dữ liệu trong mạng Ethernet chứa tối đa', N'185 bytes', N'1500 bytes', N'8182 bytes', N'Không giới hạn', N'B', N'TH123   ', N'd0be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 106, N'A', N'Chọn câu sai:" Cầu nối (bridge) có thể kết nối các mạng có...."', N'Chiều dài frame khác nhau', N'Cấu trúc frame khác nhau', N'Tốc độ truyền khác nhau', N'Chuẩn khác nhau', N'A', N'TH123   ', N'd1be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 107, N'A', N'Mạng nào có tốc độ truyền lớn hơn 100Mbps', N'Fast Ethernet', N'Gigabit Ethernet', N'Ethernet', N'Tất cả đều đúng', N'B', N'TH123   ', N'd2be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 108, N'A', N'Mạng Ethernet sử dụng được loại cáp', N'Cáp quang', N'Xoắn đôi', N'Đồng trục', N'Tất cả đều đúgn', N'D', N'TH123   ', N'd3be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 109, N'A', N'Khoảng cách đường truyền tối đa mạng FDDI có thể đạt', N'1Km', N'10Km', N'100Km', N'1000Km', N'C', N'TH123   ', N'd4be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 110, N'A', N'Cấp network truyền nhận theo kiểu end-to-end vì nó quản lý dữ liệu', N'Giữa 2 đầu subnet', N'Giữa 2 máy tính trong mạng', N'Giữa 2 thiết bị trên đường truyền', N'Giữa 2 đầu đường truyền', N'A', N'TH123   ', N'd5be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 111, N'A', N'Kiểu mạch ảo(virtual circuit) được dùng trong loại dịch vụ mạng', N'Có kết nối', N'Không kết nối', N'Truyền 1 chiều', N'Truyền 2 chiều', N'A', N'TH123   ', N'd6be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 112, N'A', N'Kiểu datagram trong cấp network', N'Chỉ tìm đường 1 lần khi tạo kết nối', N'Phải tìm đường riêng cho từng packet', N'THông tin có sẵn trong packet, không cần tìm đường', N'Thông tin có sẵn trong router , không cần tìm đường', N'B', N'TH123   ', N'd7be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 113, N'A', N'Kiểm soát tắc nghẽn (congestion) là nhiệm vụ của cấp', N'Physical', N'Transport', N'Data link', N'Network', N'D', N'TH123   ', N'd8be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 114, N'A', N'Nguyên nhân dẫn đến tắt nghẻn (congestion) trên mạng', N'Tốc độ xử lý của router chậm', N'Buffers trong router nhỏ', N'Router có nhiều đường vào nhưng ít đường ra', N'Tất cả đều đúng', N'D', N'TH123   ', N'd9be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 115, N'A', N'Cấp appliation trong mô hình TCP/IP tương đương với cấp nào trong mô hình OSI', N'Session', N'Application', N'Presentation', N'Tất cả đều đúng', N'D', N'TH123   ', N'dabe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 116, N'A', N'Cấp nào trong mô hình mạng OSI tương đương với cấp Internet trong mô hình TCP/IP ', N'Network', N'Transport', N'Physical', N'Data link', N'A', N'TH123   ', N'dbbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 117, N'A', N'Chất lượng dịch vụ mạng không được đánh giá trên chỉ tiêu nào?', N'Thời gian thiết lập kết nối ngắn', N'Tỉ lệ sai sót rất nhỏ', N'Tốc độ đường truyền cao', N'Khả năng phục hồi khi có sự cố', N'A', N'TH123   ', N'dcbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 118, N'A', N'Kỹ thuật Multiplexing được dùng khi', N'Có nhiều kênh truyền hơn đường truyền', N'Có nhiều đường truyền hơn kênh truyền', N'Truyền dữ liệu số trên mạng điện thoại', N'Truyền dữ liệu tương tự trên mạng điện thọai', N'A', N'TH123   ', N'ddbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 119, N'A', N'Dịch vụ truyền Email sử dụng protocol nào?', N'HTTP', N'NNTP', N'SMTP', N'FTP', N'C', N'TH123   ', N'debe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 120, N'A', N'Địa chỉ IP lớp B nằm trong phạm vi nào', N'192.0.0.0 - 223.0.0.0', N'127.0.0.0 - 191.0.0.0', N'128.0.0.0 - 191.0.0.0 ', N'1.0.0.0 - 126.0.0.0', N'C', N'TH123   ', N'dfbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 121, N'A', N'Subnet Mask nào sau đây chỉ cho tối đa 2 địa chỉ host', N'255.255.255.252', N'255.255.255.254', N'255.255.255.248', N'255.255.255.240', N'A', N'TH123   ', N'e0be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 122, N'A', N'Thành phần nào không thuộc socket', N'Port', N'Địa chỉ IP', N'Địa chỉ cấp MAC', N'Protocol cấp Transport', N'C', N'TH123   ', N'e1be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 123, N'A', N'Mục đích của Subnet Mask trong địa chỉ IP là', N'Xác định host của địa chỉ IP', N'Xác định vùng network của địa chỉ IP', N'Lấy các bit trong vùng subnet làm địa chỉ host', N'Lấy các bit trong vùng địa chỉ host làm subnet', N'A', N'TH123   ', N'e2be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 124, N'A', N'Bước đầu tiên cần thực hiện để truyền dữ liệu theo ALOHA là', N'Chờ 1 thời gian ngẫu nhiên', N'Gửi tín hiệu tạo kết nối', N'Kiểm tra tình trạng đường truyền', N'Lập tức truyền dữ liệu', N'D', N'TH123   ', N'e3be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 125, N'A', N'Cầu nối trong suốt hoạt động trong cấp nào', N'Data link', N'Physical', N'Network', N'Transport', N'A', N'TH123   ', N'e4be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 126, N'A', N'Tốc độ của đường truyền T1 là:', N'2048 Mbps', N'1544 Mbps', N'155 Mbps', N'56 Kbps', N'B', N'TH123   ', N'e5be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 127, N'A', N'Khi một dịch vụ trả lời ACK cho biết dữ liệu đã nhận được, đó là', N'Dịch vụ có xác nhận', N'Dịch vụ không xác nhận', N'Dịch vụ có kết nối', N'Dịch vụ không kết nối', N'A', N'TH123   ', N'e6be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 128, N'A', N'Loại frame nào được sử dụng trong mạng Token-ring', N'Monitor', N'Token', N'Data', N'Token và Data', N'D', N'TH123   ', N'e7be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 129, N'A', N'Thuật ngữ OSI là viết tắt bởi', N'Organization for Standard Institude', N'Organization for Standard Internet', N'Open Standard Institude', N'Open System Interconnection', N'D', N'TH123   ', N'e8be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 130, N'A', N'Trong mạng Token-ting, khi 1 máy nhận được Token', N'Nó phải truyền cho máy kế trong vòng', N'Nó được quyền truyền dữ liệu', N'Nó được quyền giữ lại Token', N'Tất cả đều sai', N'B', N'TH123   ', N'e9be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 131, N'A', N'Trong mạng cục bộ, để xác định 1 máy trong mạng ta dùng địa chỉ', N'MAC', N'Socket', N'Domain', N'Port', N'A', N'TH123   ', N'eabe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 132, N'A', N'Thứ tự các cấp trong mô hình OSI', N'Application,Session,Transport,Physical', N'Application, Transport, Network, Physical', N'Application, Presentation,Session,Network,Transport,Data link,Physical', N'Application,Presentation,Session,Transport,Network,Data link,Physical', N'D', N'TH123   ', N'ebbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 133, N'A', N'Cấp vật lý (physical) không quản lý', N'Mức điện áp', N'Địa chỉ vật lý', N'Mạch giao tiếp vật lý', N'Truyền các bit dữ liêu', N'B', N'TH123   ', N'ecbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 134, N'A', N'TCP sử dụng loại dịch vụ', N'Có kết nối, độ tin cậy cao', N'Có kết nối, độ tin cậy thấp', N'Không kết nối, độ tin cậy cao', N'Không kết nối, độ tin cậy thấp', N'A', N'TH123   ', N'edbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 135, N'A', N'Địa chỉ IP bao gồm', N'Địa chỉ Network và địa chỉ host', N'Địa chỉ physical và địa chỉ logical', N'Địa chỉ cấp MAC và và địa chỉ LLC', N'Địa chỉ hardware và địa chỉ software', N'A', N'TH123   ', N'eebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 136, N'A', N'Chức năng cấp mạng (network) là', N'Mã hóa và định dạng dữ liệu', N'Tìm đường và kiểm soát tắc nghẽn', N'Truy cập môi trường mạng', N'Kiểm soát lỗi và kiểm soát lưu lượng', N'B', N'TH123   ', N'efbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 137, N'A', N'Mạng CSMA/CD làm gì', N'Truyền Token trên mạng hình sao', N'Truyền Token trên mạng dạng Bus', N'Chia packet ra thành từng frame nhỏ và truỵền đi trên mạng', N'Truy cập đường truyền và truyền lại dữ liệu nếu xảy ra đụng độ', N'D', N'TH123   ', N'f0be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 138, N'A', N'Tiền thân của mạng Internet là', N'Intranet', N'Ethernet', N'Arpanet', N'Token-bus', N'C', N'TH123   ', N'f1be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 139, N'A', N'Khi 1 cầu nối ( bridge) nhận được 1 framechưa biết thông tin về địa chỉ máy nhận, nó sẽ', N'Xóa bỏ frame này', N'Gửi trả lại máy gốc', N'Gửi đến mọi ngõ ra còn lại', N'Giảm thời gian sống của frame đi 1 đơn vị và gửi đến mọi ngõ ra còn lại', N'C', N'TH123   ', N'f2be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 140, N'A', N'Chức năng của cấp Network là', N'Tìm đường', N'Mã hóa dữ liệu', N'Tạo địa chỉ vật lý', N'Kiểm soát lưu lượng', N'A', N'TH123   ', N'f3be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 141, N'B', N'Sự khác nhau giữa địa chỉ cấp Data link và Network là', N'Địa chỉ cấp Data link có kích thước nhỏ hơn địa chỉ cấp Network', N'Địa chỉ cấp Data link là đia chỉ Physic, địa chỉ cấp Network là địa chỉ Logic', N'Địa chỉ cấp Data Link là địa chỉ Logic, địa chỉ câp Network là địa chỉ Physic', N'Địa chỉ Data link cấu hình theo mạng, địa chỉ cấp Network xác định theo IEEE', N'B', N'TH123   ', N'f4be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 142, N'B', N'Kỹ thuật nào không sử dụng được trong việc kiểm soát lưu lượng(flow control)', N'Ack', N'Buffer', N'Windowing', N'Multiplexing', N'D', N'TH123   ', N'f5be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 143, N'B', N'Cấp cao nhất trong mô hình mạng OSI là', N'Transport', N'Physical', N'Network', N'Application', N'D', N'TH123   ', N'f6be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 144, N'B', N'Tại sao mạng máy tình dùng mô hình phân cấp', N'Để mọi người sử dụng cùng 1 ứng dụng mạng', N'Để phân biệt giữa chuẩn mạng và ứng dụng mạng', N'Giảm độ phức tạp trong việc thiết kế và cài đặt', N'Các cấp khác không cần sửa đổi khi thay đổi 1 cấp mạng', N'D', N'TH123   ', N'f7be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 145, N'B', N'Router làm gì để giảm tăc nghẽn (congestion)', N'Nén dữ liệu', N'Lọc bớt dữ liệu theo địa chỉ vật lý', N'Lọc bớt dữ liệu theo địa chỉ logic', N'Cấm truyền dữ liệu broadcasr', N'D', N'TH123   ', N'f8be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 146, N'B', N'Byte đầu của 1 IP có giá trị 222, địa chỉ này thuộc lớp địa chỉ nào', N'Lớp A', N'Lớp B', N'Lớp C', N'Lớp D', N'C', N'TH123   ', N'f9be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 147, N'B', N'Chọn câu đúng đối với switch của mạng LAN', N'Là 1 cầu nối tốc độ cao', N'Nhận data từ 1 cổng và xuất ra mọi cổng còn lại', N'Nhận data từ 1 cổng và xuất ra  cổng đích tùy theo địa chỉ cấp IP', N'Nhận data từ 1 cổng và xuất ra 1 cổng đích tùy theo địa chỉ cấp MAC', N'D', N'TH123   ', N'fabe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 148, N'B', N'Thuật ngữ nào cho biết loại mạng chỉ truyền được  chiều tại 1 thời điểm', N'Half duplex', N'Full duplex', N'Simplex', N'Monoplex', N'A', N'TH123   ', N'fbbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 149, N'B', N'Protocol nghĩa là', N'Tập các chuẩn truyền dữ liệu', N'Tập các cấp mạng trong mô hình OSI', N'Tập các chức năng của từng cấp trong mạng', N'Tập các qui tắc và cấu trúc dữ liệu để truyền thông giữa các cấp mạng', N'D', N'TH123   ', N'fcbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 150, N'B', N'Truyền dữ liệu theo kiểu có kết nối không cần thực hiện việc', N'Hủy kết nối', N'Tạo kết nối', N'Truyền dữ liệu', N'Tìm đường cho từng gói tin', N'D', N'TH123   ', N'fdbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 151, N'B', N'Byte đầu của địa chỉ IP lớp E nằm trong phạm vi', N'128 - 191', N'192 - 232 ', N'224 - 239 ', N'240 - 247', N'D', N'TH123   ', N'febe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 152, N'B', N'Khi truyền đi chuỗi "VIET NAM" nhưng nhận được chuỗi"MAN TEIV ". Cần phải hiệu chỉnh các protocol trong cấp nào để truyền chính xác', N'Session', N'Transport', N'Application', N'Presentation', N'B', N'TH123   ', N'ffbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 153, N'B', N'Tên cáp UTP dùng torng mạng Fast Ethernet là', N'100BaseF', N'100Base2', N'100BaseT', N'100Base5', N'C', N'TH123   ', N'00bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 154, N'B', N'Tốc độ truyền của mạng Ethernet là', N'1 Mbps', N'10 Mbps', N'100 Mbps', N'1000 Mbps', N'B', N'TH123   ', N'01bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 155, N'B', N'Dịch vụ mạng thường được phân chia thành', N'Dịch vụ không kết nối và có kết nối', N'Dich vụ có xác nhận và không xác nhận', N'Dịch vụ có độ tin cậy cao và có độ tin cậy thấp', N'Tất cả đều đúng', N'D', N'TH123   ', N'02bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 156, N'B', N'Đơn vị truyền dữ liệu trong cấp Network gọi là', N'Bit', N'Frame', N'Packet', N'Segment', N'C', N'TH123   ', N'03bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 157, N'B', N'Protocol nào trong mạng TCP/IP chuyển đổi địa chỉ vật lý thành địa chỉ IP', N'IP', N'ARP', N'ICMP', N'RARP', N'D', N'TH123   ', N'04bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 158, N'B', N'Đầu nới AUI dùng cho loại cáp nào?', N'Đồng trục', N'Xoắn đôi', N'Cáp quang', N'Tất cả đều đúng', N'A', N'TH123   ', N'05bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 159, N'B', N'Subnet mask chuẩn của địa chỉ IP lớp B là', N'255.0.0.0', N'255.255.0.0', N'255.255.255.0', N'255.255.255.255', N'B', N'TH123   ', N'06bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 160, N'B', N'Lý do nào khiến người ta chọn protocol TCP hơn là UDP', N'Không ACK', N'Dễ sử dụng', N'Độ tin cậy', N'Không kết nối', N'C', N'TH123   ', N'07bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 161, N'B', N'Nhược điểm của dịch vụ có kết nối so với không kết nối', N'Độ tin cậy', N'Thứ tự nhận dữ liệu không đúng', N'Đường truyền không thay đổi', N'Đường truyền thay đổi liên tục', N'C', N'TH123   ', N'08bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 162, N'B', N'Cấp Data link không thực hiện chức năng nào?', N'Kiểm soát lỗi', N'Địa chỉ vật lý', N'Kiểm soát lưu lượng', N'Thiết lập kết nối', N'D', N'TH123   ', N'09bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 163, N'B', N'Cầu nối (bridge)dựa vào thông tin nào để truyền tiếp hoặc hủy bỏ 1 frame', N'Điạ chỉ nguồn', N'Địa chỉ đích', N'Địa chỉ mạng', N'Tất cả đều đúng', N'C', N'TH123   ', N'0abf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 164, N'B', N'Chuẩn nào sử dụng trong cấp presentation?', N'UTP và STP', N'SMTP và HTTP', N'ASCII và EBCDIC', N'TCP và UDP', N'C', N'TH123   ', N'0bbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 165, N'B', N'Đơn vị truyền dữ liệu giữa các cấp trong mạng theo thứ tự', N'bit,frame,packet,data', N'bit,packet,frame,data', N'data,frame,packet,bit', N'data,bit,packet,frame', N'A', N'TH123   ', N'0cbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 166, N'B', N'Mạng Ethernet do cơ quan nào phát minh', N'ANSI', N'ISO', N'IEEE', N'XEROX', N'D', N'TH123   ', N'0dbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 167, N'B', N'Chiều dài loại cáp nào tối đa 100 m? ', N'10Base2', N'10Base5', N'10BaseT', N'10BaseF', N'C', N'TH123   ', N'0ebf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 168, N'B', N'Địa chỉ IP 100.150.200.250 có nghĩa là', N'Địa chỉ network 100, địa chỉ host 150.200.250', N'Địa chỉ network 100.150, địa chỉ host 200.250', N'Địa chỉ network 100.150.200, địa chỉ host 250', N'Tất cả đều sai', N'D', N'TH123   ', N'0fbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 169, N'B', N'Switching hun khác hub thông thường ở chỗ nó làm', N'Giảm collision trên mạng', N'Tăng collision trên mạng', N'Giảm congestion trên mạng', N'Tăng congestion trên mạng', N'A', N'TH123   ', N'10bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 170, N'B', N'Loại cáp nào chỉ truyền dữ liệu 1 chiều', N'Cáp quang', N'Xoắn đôi', N'Đồng trục', N'Tất cả đều đúng', N'A', N'TH123   ', N'11bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 171, N'B', N'Thiết bị Modem dùng để', N'Tách và ghép tín hiệu', N'Nén và gải nén tín hiệu', N'Mã hóa và giải mã tín hiệu', N'Điều chế và giải điều chế tín hiệu', N'D', N'TH123   ', N'12bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 172, N'B', N'Việc cấp phát kênh truyền áp dụng cho loại mạng', N'Peer to peer', N'Point to point', N'Broadcast', N'Multiple Access', N'C', N'TH123   ', N'13bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 173, N'B', N'Mạng nào dùng phương pháp mã hóa Manchester Encoding', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều đúng ', N'D', N'TH123   ', N'14bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 174, N'B', N'Phương pháp tìm đường có tính đến thời gian trễ', N'Tìm đường theo chiều sâu', N'Tìm đường theo chiều rộng', N'Tìm đường theo vector khoảng cách', N'Tìm đường theo trạng thái đường truyền', N'D', N'TH123   ', N'15bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 175, N'B', N'Chuẩn mạng nào khi có dữ liệu không truyền ngay mà chờ 1 thời gian ngẫu nhiên?', N'1-presistent CSMA', N'p-presistent CSMA', N'Non-presistent CSMA', N'CSMA/CD', N'C', N'TH123   ', N'16bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 176, N'B', N'Phương pháp chèn bit (bit stuffing) được dùng để', N'Phân biệt đầu và cuối frame', N'Bổ sung cho đủ kích thước frame tối thiểu', N'Phân cách nhiều bit 0 bằng bit 1', N'Biến đổi dạng dữ liệu 8 bit ra 16 bit', N'A', N'TH123   ', N'17bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 177, N'B', N'Để chống nhiễu trên đường truyền tốt nhất, nên dùng loại cáp:', N'Xoắn đôi', N'Đồng trục', N'Cáp quang', N'Mạng không dây', N'C', N'TH123   ', N'18bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 178, N'B', N'Phần mềm gửi/nhận thư điện tử thuộc cấp nào trong mô hình OSI', N'Data link', N'Network', N'Application', N'Presentation', N'C', N'TH123   ', N'19bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 179, N'B', N'Chức năng của thiết bị Hub trong mạng LAN', N'Mã hóa tín hiệu', N'Triệt tiêu tín hiệu', N'Phân chia tín hiệu', N'Điều chế tín hiếu', N'C', N'TH123   ', N'1abf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 180, N'B', N'Switch là thiết bị mạng làm việc tương tự như', N'Hub', N'Repeater', N'Router', N'Bridge', N'D', N'TH123   ', N'1bbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 181, N'C', N'Thiết bị nào làm việc trong cấp Network', N'Bridge', N'Repeater', N'Router', N'Gateway', N'C', N'TH123   ', N'1cbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 182, N'C', N'Thiết bị nào cần có bộ nhớ làm buffer', N'Hub', N'Switch', N'Repeater', N'Router', N'D', N'TH123   ', N'1dbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 183, N'C', N'Luật 5-4-3 cho phép tối đa', N'5 segment trong 1 mạng', N'5 repeater trong 1 mạng', N'5 máy tính trong 1 mạng', N'5 máy tính trong 1 segment', N'A', N'TH123   ', N'1ebf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 184, N'C', N'Thiết bị nào có thể thêm vào mạng LAN mà không sợ vi phạm luật 5-4-3', N'Router', N'Repeater', N'Máy tính', N'Tất cả đều đúng', N'A', N'TH123   ', N'1fbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 185, N'C', N'Thêm thiết bị nào vào mạng có thể qui phạm luật 5-4-3', N'Router', N'Repeater', N'Bridge', N'Tất cả đều đúng', N'B', N'TH123   ', N'20bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 186, N'C', N'Mạng nào cóxảy ra xung đột (collision) trên đường truyền', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều sai', N'A', N'TH123   ', N'21bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 187, N'C', N'Từ "Broad" trong tên cáp 10Broad36 viết tắt bởi', N'Broadcast', N'Broadbase', N'Broadband', N'Broadway', N'C', N'TH123   ', N'22bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 188, N'C', N'Protocol nào sử dụng trong cấp Network', N'IP', N'TCP', N'UDP', N'FTP', N'A', N'TH123   ', N'23bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 189, N'C', N'Protocol nào torng cấp Transport cung cấp dịch vụ không kết nối', N'IP', N'TCP', N'UDP', N'FTP', N'C', N'TH123   ', N'24bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 190, N'C', N'Protocol nào trong cấp Transport dùng kiểu dịch vụ có kết nối?', N'IP', N'TCP', N'UDP', N'FTP', N'B', N'TH123   ', N'25bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 191, N'C', N'Địa chỉ IP được chia làm mấy lớp', N'2', N'3', N'4', N'5', N'D', N'TH123   ', N'26bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 192, N'C', N'Chức năng nào không phải của cấp Network', N'Tìm đường', N'Địa chỉ logic', N'Kiểm soát tắc nghẽn', N'Chất lượng dịch vụ', N'B', N'TH123   ', N'27bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 193, N'C', N'Phương pháp chèn kí tự dùng để', N'Phân cách các frame', N'Phân biệt dữ liệu và ký tự điều khiển', N'Nhận diện đầu cuối frame', N'Bổ sung cho đủ kich thước frame tối thiểu', N'B', N'TH123   ', N'28bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 194, N'C', N'Kỹ thuật truyền nào mã hóa trực tiếp dữ liệu ra đường truyền không cần sóng mang', N'Broadcast', N'Digital', N'Baseband', N'Broadband', N'C', N'TH123   ', N'29bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 195, N'C', N'Sóng viba sử dụng băng tần', N'SHF', N'LF và MF', N'UHF và VHF', N'Tất cả đều đúng', N'D', N'TH123   ', N'2abf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 196, N'C', N'Sóng viba bị ảnh hưởng bời', N'Trời mưa', N'Sấm chớp', N'Giông bão', N'Ánh sáng mặt trời', N'A', N'TH123   ', N'2bbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 197, N'C', N'Đường dây trung kế trong mạng điện thoại sử dụng', N'Tín hiệu số', N'Kỹ thuật dồn kênh', N'Cáp quang, cáp đồng và viba', N'Tất cả đêu đúng', N'D', N'TH123   ', N'2cbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 198, N'C', N'Cáp quang dùng công nghệ dồn kênh nào', N'TDM', N'FDM', N'WDM', N'CDMA', N'C', N'TH123   ', N'2dbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 199, N'C', N'Nhược điểm của phương pháp chèn ký tự', N'Giảm tốc độ đường truyền', N'Tăng phí tổn đường truyền', N'Mất đồng bộ frame', N'Không nhận diện được frame', N'B', N'TH123   ', N'2ebf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 200, N'C', N'Mất đồng bộ frame xảy ra đối với phương pháp', N'Chèn bit', N'Đếm ký tự', N'Chèn ký tự', N'Tất cả đều đúng', N'B', N'TH123   ', N'2fbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 201, N'C', N'Mạng nào dùng công nghệ Token-bus', N'FDDI', N'CDDI', N'Fast Ethernet', N'100VG-AnyLAN', N'D', N'TH123   ', N'30bf34b9-00d8-e711-9bce-08edb98553be')
GO
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 202, N'C', N'Thiết bị nào tự trao đổi thông tin lẫn nhau để quản lý mạng', N'Hub', N'Bridge', N'Router', N'Repeater', N'C', N'TH123   ', N'31bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 203, N'C', N'Tần số sóng điện từ dùng trong mạng vô tuyến sắp theo thứ tự tăng dần', N'Radio,viba,hồng ngoại', N'Radio,hồng ngoại,viba', N'Hồng ngoại,viba,radio', N'Viba,radio,hồng ngoại', N'A', N'TH123   ', N'32bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 204, N'C', N'Đường dây hạ kế (local loop) trong mạch điện thoại dùng tín hiệu', N'Digital', N'Analog', N'Manchester', N'T1 hoặc E1', N'B', N'TH123   ', N'33bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 205, N'C', N'Để tránh nhận trùng dữ liệu người ta dùng phương pháp', N'Đánh số thứ tự các frame', N'Quy định kích thước frame cố định', N'Chờ nhận ACK mới gửi frame kế tiếp', N'So sánh và loại bỏ các frame giống nhau', N'A', N'TH123   ', N'34bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 206, N'C', N'Cơ chế Timer dùng để', N'Đo thời gian chơ frame', N'Tránh tình trạng mất frame', N'Chọn thời điểm truyền frame', N'Kiểm soát thòi gian truyền frame', N'A', N'TH123   ', N'35bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 207, N'C', N'Cấp nào trong mô hình OSI quan tâm tới topology mạng', N'Transport', N'Network', N'Data link', N'Physical', N'B', N'TH123   ', N'36bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 208, N'C', N'Loại mạng nào sử dụng trên WAN', N'Ethernet và Token-bus', N'ISDN và Frame relay', N'Token-ring và FDDI', N'SDLC và HDLC', N'A', N'TH123   ', N'37bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 209, N'C', N'Repeater nhiều port là tên gọi của', N'Hub', N'Host', N'Bridge', N'Router', N'A', N'TH123   ', N'38bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 210, N'C', N'Đơn vị đo tốc độ đường truyền', N'bps(bit per second)', N'Bps(Byte per second)', N'mps(meter per second)', N'hertz (ccle per second)', N'A', N'TH123   ', N'39bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 211, N'C', N'Repeater dùng để', N'Lọc bớt dữ liệu trên mạng', N'Tăng tốc độ lưu thông trên mạng', N'Tăng thời gian trễ trên mạng', N'Mở rộng chiều dài đường truyền', N'D', N'TH123   ', N'3abf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 212, N'C', N'Cáp đồng trục (coaxial)', N'Có 4 đôi dây', N'Không cần repeater', N'Truyền tín hiệu ánh sáng', N'Chống nhiễu tốt hơn UTP', N'D', N'TH123   ', N'3bbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 213, N'C', N'Câp Data link ', N'Truyền dữ liệu cho các cấp khác trong mạng', N'Cung cấp dịch vụ cho chương trình ứng dụng', N'Nhận tín hiệu yếu,lọc,khuếch đại và phát lại trên mạng', N'Bảo đảm đường truyền dữ liệu tin cậy giữa 2 đầu đường truyền', N'D', N'TH123   ', N'3cbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 214, N'C', N'Địa chỉ IP còn gọi là', N'Địa chĩ vật lý', N'Địa chỉ luận lý', N'Địa chỉ thập phân', N'Địa chỉ thập lục phân', N'B', N'TH123   ', N'3dbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 215, N'C', N'Cấp Presentation', N'Thiết lập, quản lý và kết thúc các ứng dụng', N'Hướng dẫn cách mô tả hình ảnh, âm thanh, tiếng nói', N'Cung cấp dịch vụ truyền dữ liệu từ nguồn đến đích', N'Hỗ trợ việc truyền thông trong các ứng dụng như web, mail...', N'C', N'TH123   ', N'3ebf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 216, N'C', N'Tập các luật để định dạng và truyền dữ liệu gọi là', N'Qui luật (rule)', N'Nghi thức (protocol)', N'Tiêu chuẩn (standard)', N'Mô hình (model)', N'B', N'TH123   ', N'3fbf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 217, N'C', N'Tại sao cần có tiêu chuẩn về mang', N'Định hướng phát triển phần cứng và phần mềm mới', N'LAN,MAN và WAN sử dụng các thiết bị khác nhau', N'Kết nối mạng giữa các quôc gia khác nhau', N'Tương thích về công nghệ để truyền thông được lẫn nhau', N'D', N'TH123   ', N'40bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 218, N'C', N'Dữ liệu truyền trên mạng bằng', N'Mã ASCII', N'Số nhị phân', N'Không và một', N'Xung điện áp', N'D', N'TH123   ', N'41bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 219, N'C', N'Mạng CSMA/CD', N'Kiểm tra để bảo đảm dữ liệu truyền đến đích', N'Kiểm tra đường truyền nếu rảnh mới truyền dữ liệu', N'Chờ 1 thời gian ngẫu nhiên rồi truyền  dữ liệu kế tiếp', N'Tất cả đều đúng', N'B', N'TH123   ', N'42bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 220, N'C', N'Địa chỉ MAC ', N'Gồm có 32 bit', N'Còn gọi là địa chỉ logic', N'Nằm trong cấp Network', N'Dùng để phân biệt các máy trong mạng', N'D', N'TH123   ', N'43bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'MMTCB', 223, N'B', N'isuydsuy', N'ksdyfus', N'sjflds', N'sdjfls', N'sidfuos', N'B', N'TH123   ', N'44bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'LTW  ', 224, N'A', N'kjck', N'kjdks', N'kdjfhsk', N'jdhf', N'kxjdfk', N'C', N'TH123   ', N'45bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 225, N'A', N'Cháu lên ba cháu vô mẫu giáo, cô khen cháu cháu không khóc nhè.', N'1', N'2', N'3', N'4', N'C', N'TH123   ', N'46bf34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'AVCB ', 228, NULL, N'sdsdss', N'sdaa', N'ádsada', N'sdsad', N'sdada', N'A', N'TH101   ', N'49eb84d6-0fdc-e711-9bd0-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (N'CTDL ', 231, NULL, N'mkjk', N'hhjh', N'hjhjh', N'ghgh', N'ghghgh', N'A', N'TH101   ', N'2bb5656d-12dc-e711-9bd0-08edb98553be')
INSERT [dbo].[BODE] ([MAMH], [CAUHOI], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (NULL, 232, NULL, N'dsadsad', N'sadsadsa', N'sdada', N'sda', N'Dsaa', N'A', N'TH101   ', N'e991042c-13dc-e711-9bd0-08edb98553be')
INSERT [dbo].[COSO] ([MACS], [TENCS], [DIACHI], [rowguid]) VALUES (N'CS1', N'CO SO 1 ', N'11 Nguyễn Đình Chiểu, Phường Đakao, Quận 1', N'46be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[COSO] ([MACS], [TENCS], [DIACHI], [rowguid]) VALUES (N'CS2', N'CO SO 2', N'97  Man Thiện , Phường Hiệp Phú, Quận 9', N'47be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'1       ', N'LE', N'HUNG', N'TIẾN SĨ', N'MR      ', N'54be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'2       ', N'NGUYEN DAM', N'DUY', N'THẠC SĨ', N'QT      ', N'55be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'MR401   ', N'LE', N'CHI', N'THẠC SĨ', N'MR      ', N'56be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'QT301   ', N'NGUYEN BAO', N'LAM', N'THẠC SĨ ', N'QT      ', N'57be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'TH101   ', N'KIEU DAC', N'THIEN', N'THẠC SĨ', N'CNTT    ', N'58be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'TH123   ', N'PHAN VAN ', N'HAI', N'THẠC SĨ', N'CNTT    ', N'59be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'TH234   ', N'DAO VAN ', N'TUYET', N'THẠC SĨ ', N'CNTT    ', N'5abe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'TH657   ', N'PHAN HONG', N'NGOC', N'TIẾN SĨ ', N'VT      ', N'5bbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [HOCVI], [MAKH], [rowguid]) VALUES (N'VT201   ', N'LUONG PHUONG', N'NHAT', N'TIẾN SĨ', N'VT      ', N'5cbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MALOP], [MAMH], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH123   ', N'D14CN1  ', N'AVCB ', N'A', CAST(N'2017-12-08 13:39:42.610' AS DateTime), 1, 30, 30, N'ef7ccd09-bed8-e711-9bcf-08edb98553be')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MALOP], [MAMH], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH101   ', N'D14CN1  ', N'AVCB ', N'A', CAST(N'2017-12-10 00:00:00.000' AS DateTime), 2, 20, 20, N'd9b45755-bfd8-e711-9bcf-08edb98553be')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MALOP], [MAMH], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH101   ', N'D14CN1  ', N'MMTCB', N'A', CAST(N'2017-12-10 00:00:00.000' AS DateTime), 1, 10, 15, N'7941b4ec-c3dc-e711-9bd0-08edb98553be')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MALOP], [MAMH], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH101   ', N'D14CN1  ', N'MMTCB', N'A', CAST(N'2017-12-09 00:00:00.000' AS DateTime), 2, 30, 15, N'26ee29ee-c4dc-e711-9bd0-08edb98553be')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'CNTT    ', N'Công nghệ thông tin', N'CS1', N'50be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'MR      ', N'Marketing', N'CS2', N'51be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'QT      ', N'Quản trị kinh doanh', N'CS2', N'52be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'VT      ', N'Viễn thông', N'CS1', N'53be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D14CN1  ', N'CÔNG NGHỆ THÔNG TIN 2014', N'CNTT    ', N'5dbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D14MR1  ', N'MARKETING 2014', N'MR      ', N'5ebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D14QT1  ', N'QUẢN TRỊ KINH DOANH 2014', N'QT      ', N'5fbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D14VT1  ', N'VIỄN THÔNG 2014', N'VT      ', N'60be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'AVCB ', N'ANH VAN CAN BAN', N'48be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDL ', N'CO SO DU LIEU', N'4abe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CTDL ', N'CAU TRUC DU LIEU', N'49be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'HQT  ', N'HE QUAN TRI CSDL', N'4bbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'KTTSL', N'KY THUAT TRUYEN SO LIEU', N'4cbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTMCB', N'LAP TRINH MANG CO BAN', N'4dbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTW  ', N'LAP TRINH TREN WINDOW', N'4ebe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'MMTCB', N'MANG MAY TINH CAN BAN', N'4fbe34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14CQ001', N'NGUYEN MANH', N'CUONG', CAST(N'1996-08-02 00:00:00.000' AS DateTime), N'CẦN GIỜ ,TPHCM ', N'D14CN1  ', N'61be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14CQ059', N'MAI THI PHUONG', N'THAO', CAST(N'1996-01-06 00:00:00.000' AS DateTime), N'97 MAN THIỆN QUẬN 9', N'D14CN1  ', N'62be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14CQ083', N'NGUYEN KHANH', N'TOAN', CAST(N'1996-05-10 00:00:00.000' AS DateTime), N'Hoóc Môn', NULL, N'12b74ab0-b8dc-e711-9bd0-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14CQ102', N'TRAN QUANG', N'HUY', CAST(N'1996-03-06 00:00:00.000' AS DateTime), N'23 CAO LANH DONG THAP', N'D14CN1  ', N'63be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14DC079', N'NGUYEN THANH', N'NAM', CAST(N'1996-05-10 00:00:00.000' AS DateTime), N'Q12', N'D14CN1  ', N'5a4d4f5f-b7dc-e711-9bd0-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14DC080', N'PHAN THI THUY', N'NHI', CAST(N'1995-11-14 00:00:00.000' AS DateTime), N'97 ĐƯỜNG MAN THIỆN P HIEP PHU Q9', N'D14CN1  ', N'64be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14MR001', N'NGUYEN THI THUY', N'HIEN', CAST(N'1997-02-09 00:00:00.000' AS DateTime), N'11 ĐƯỜNG 2 DĨ AN BÌNH DƯƠNG', N'D14MR1  ', N'65be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14QT111', N'LUONG THI THU ', N'HA', CAST(N'1996-02-03 00:00:00.000' AS DateTime), N'22 ĐƯỜNG NGUYỄN TẤT THÀNH BMT ĐẮK LẮK', N'D14QT1  ', N'66be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14QT121', N'NGUYEN THI PHUONG', N'HONG', CAST(N'1997-11-02 00:00:00.000' AS DateTime), N'97 MAN THIỆN QUAJNA9 TPHCM', N'D14QT1  ', N'67be34b9-00d8-e711-9bce-08edb98553be')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'N14VT020', N'DOAN THI AI', N'TRAM', CAST(N'1996-09-02 00:00:00.000' AS DateTime), N'22 ĐƯỜNG VO THI SAU P3 Q3', N'D14VT1  ', N'68be34b9-00d8-e711-9bce-08edb98553be')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_COSO]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[COSO] ADD  CONSTRAINT [UK_COSO] UNIQUE NONCLUSTERED 
(
	[TENCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__LOP__E100BDB7D1FC2F12]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [UQ__LOP__E100BDB7D1FC2F12] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_MONHOC]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [UK_MONHOC] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__MONHOC__A58D38A004769758]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__MONHOC__A58D38A01271644E]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__MONHOC__A58D38A0CE2CF863]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__MONHOC__A58D38A0D00BE66C]    Script Date: 7/22/2018 12:00:57 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BAITHI]  WITH CHECK ADD FOREIGN KEY([MASV], [MAMH], [LAN])
REFERENCES [dbo].[BANGDIEM] ([MASV], [MAMH], [LAN])
GO
ALTER TABLE [dbo].[BAITHI]  WITH CHECK ADD FOREIGN KEY([MACAUHOI])
REFERENCES [dbo].[BODE] ([CAUHOI])
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[BODE]  WITH CHECK ADD FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[BODE]  WITH CHECK ADD FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [FK__GIAOVIEN___MALOP__5FB337D6] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK__GIAOVIEN___MALOP__5FB337D6]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD FOREIGN KEY([MACS])
REFERENCES [dbo].[COSO] ([MACS])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [PK_lOP_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [PK_lOP_KHOA]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK__SINHVIEN__MALOP__5629CD9C] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK__SINHVIEN__MALOP__5629CD9C]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [CK__BANGDIEM__DIEM] CHECK  (([DIEM]>=(0) AND [DIEM]<=(10)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK__BANGDIEM__DIEM]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD CHECK  (([LAN]>=(1) AND [LAN]<=(2)))
GO
ALTER TABLE [dbo].[BODE]  WITH CHECK ADD CHECK  (([DAP_AN]=N'D' OR [DAP_AN]=N'C' OR [DAP_AN]=N'B' OR [DAP_AN]='A'))
GO
ALTER TABLE [dbo].[BODE]  WITH CHECK ADD CHECK  (([TRINHDO]=N'C' OR [TRINHDO]=N'B' OR [TRINHDO]='A'))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_GVDK_LAN] CHECK  (([LAN]>=(1) AND [LAN]<=(2)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_GVDK_LAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_GVDK_SOCAU] CHECK  (([SOCAUTHI]>=(10) AND [SOCAUTHI]<=(100)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_GVDK_SOCAU]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_GVDK_THOIGIAN] CHECK  (([THOIGIAN]>=(15) AND [THOIGIAN]<=(60)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_GVDK_THOIGIAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_GVDK_TRINHDO] CHECK  (([TRINHDO]='A' OR [TRINHDO]='B' OR [TRINHDO]='C'))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_GVDK_TRINHDO]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD CHECK  ((NOT [HO] like '%[^A-Z ]%' AND NOT [TEN] like '%[^A-Z ]%'))
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
DECLARE @TENNHOM NVARCHAR(50)
select @TENUSER = name from sys.sysusers where sid = SUSER_SID(@TENLOGIN)
select @TENNHOM = NAME FROM sys.sysusers where UID =(SELECT GROUPUID FROM SYS.SYSMEMBERS
WHERE MEMBERUID =(SELECT UID FROM SYS.SYSUSERS WHERE NAME =@TENUSER))
if(@TENNHOM ='SINHVIEN')
select USERNAME = @TENUSER,HOTEN =(SELECT HO + ' ' + TEN FROM [dbo].[SINHVIEN] WHERE MASV =@TENUSER),TENNHOM = @TENNHOM
else
select USERNAME = @TENUSER,HOTEN =(SELECT HO + ' ' + TEN FROM [dbo].[GIAOVIEN] WHERE MAGV =@TENUSER),TENNHOM = @TENNHOM
GO
/****** Object:  StoredProcedure [dbo].[sp_khoa_kiemtra]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_khoa_kiemtra]
@MAKH nchar(8),
@TENKH nvarchar(40)
AS
DECLARE @RET int = 1
if(not exists(select * from KHOA where MAKH =@MAKH or TENKH =@TENKH))
	if (not exists(select * from [LINK].[QLTN].[dbo].Khoa where MAKH =@MAKH or TENKH =@TENKH))
		set @RET = 0
select @RET
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRA_MH]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_KIEMTRA_MH]
@MAMH char(5),
@TENMH nvarchar(40)
AS
DECLARE @RET int = 0
select @RET = COUNT(MAMH) from (select MAMH from MONHOC where MAMH =@MAMH or TENMH = @TENMH 
union select MAMH from LINK.QLTN.dbo.MONHOC where mamh = @MAMH or TENMH =@TENMH) as A
select @RET
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRA_SOCAUHOI]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_KIEMTRA_SOCAUHOI]
@TRINHDO char(1),
@MAMH char(5),
@SOCAUTHI int
AS
DECLARE @SOCAU int
DECLARE @RET int =0
select @SOCAU=COUNT(CAUHOI) from bode where MAMH =@MAMH and ((@TRINHDO ='A') or 
(@TRINHDO ='B' and TRINHDO != 'A') or (TRINHDO = @TRINHDO))
if(@SOCAU > @SOCAUTHI)
	set @RET =1
select @RET
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRA_THI]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_KIEMTRA_THI]
@MASV char(8),
@MAMH char(5),
@LAN smallint
AS
DECLARE @RET int = 0
if(exists (select MASV from BANGDIEM where MASV =@MASV and MAMH =@MAMH and LAN =@LAN))
	set @RET =1;
select @RET
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRALOP]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KIEMTRALOP]
	@MALOP	  nvarchar(8)
	AS
	DECLARE @RET INT =1
	IF (NOT EXISTS ( SELECT * FROM dbo.LOP WHERE MALOP=@MALOP))
		IF(NOT EXISTS ( SELECT * FROM [LINK].[QLTN].[dbo].[LOP] WHERE MALOP=@MALOP))
			SET @RET=0
    SELECT @RET
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRASINHVIEN]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KIEMTRASINHVIEN]
	@MASV nvarchar(8)
	AS
	DECLARE @RET INT =1
	IF (NOT EXISTS ( SELECT * FROM SINHVIEN WHERE MASV=@MASV))
		IF(NOT EXISTS ( SELECT * FROM [LINK].[QLTN].[dbo].[SINHVIEN] WHERE MASV=@MASV))
			SET @RET=0
    SELECT @RET
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_LOP]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LAY_LOP]
@MASV char(8)
AS
DECLARE @MALOP char(8)
select @MALOP = MALOP from SINHVIEN where MASV = @MASV
select MALOP,TENLOP from LOP where MALOP =@MALOP
GO
/****** Object:  StoredProcedure [dbo].[SP_LAYDE]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LAYDE] @TRINHDO CHAR(8),
@MAMH CHAR(8),
@SOCAU INT
AS
create table #DETHI(CAUHOI int,TRINDO char(1),NOIDUNG ntext,A nvarchar(80)
					,B nvarchar(80),C nvarchar(80),D nvarchar(80),DAPAN char(1))
insert into #DETHI select TOP(@SOCAU)CAUHOI,TRINHDO,NOIDUNG,A,B,C,D,DAP_AN from bode where MAMH = @MAMH and
		MAGV in (select MAGV from GIAOVIEN where MAKH in (select MAKH from KHOA)) 
		and ((@TRINHDO ='A') OR (@TRINHDO ='B' and TRINHDO !='A') OR (@TRINHDO ='C' and TRINHDO ='C')) order by TRINHDO,newID()

set @SOCAU =@SOCAU -@@ROWCOUNT
if(@SOCAU > 0)
	insert into #DETHI select TOP(@SOCAU)CAUHOI,TRINHDO,NOIDUNG,A,B,C,D,DAP_AN from bode where MAMH = @MAMH and
		MAGV in (select MAGV from GIAOVIEN where MAKH not in (select MAKH from KHOA)) 
		and ((@TRINHDO ='A') OR (@TRINHDO ='B' and TRINHDO !='A') OR (@TRINHDO ='C' and TRINHDO ='C')) order by TRINHDO,newID()
select * from #DETHI order by newID()

GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 7/22/2018 12:00:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_TAOLOGIN]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLTN'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'TRUONG' OR @ROLE='COSO'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'GIAOVIEN' OR @ROLE= 'SINHVIEN'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
END

GO
