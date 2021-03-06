USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER1\MSSQL\DATA\QLDSV.mdf' , SIZE = 17408KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER1\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 32448KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDSV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLDSV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLDSV', N'ON'
GO
USE [QLDSV]
GO
/****** Object:  User [HTKN_QLDSV]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE USER [HTKN_QLDSV] FOR LOGIN [HTKN_QLDSV] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV12      ]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE USER [GV12      ] FOR LOGIN [yasuo] WITH DEFAULT_SCHEMA=[GV12      ]
GO
/****** Object:  User [GV02]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE USER [GV02] FOR LOGIN [huy] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV01]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE USER [GV01] FOR LOGIN [son] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [User]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE ROLE [User]
GO
/****** Object:  DatabaseRole [PKT]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE ROLE [PKT]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [Khoa]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE ROLE [Khoa]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN_QLDSV]
GO
ALTER ROLE [User] ADD MEMBER [GV12      ]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV12      ]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV12      ]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV12      ]
GO
ALTER ROLE [PGV] ADD MEMBER [GV02]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV02]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [GV02]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV02]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV02]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV02]
GO
ALTER ROLE [Khoa] ADD MEMBER [GV01]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [GV01]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV01]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV01]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV01]
GO
ALTER ROLE [db_owner] ADD MEMBER [User]
GO
ALTER ROLE [db_datareader] ADD MEMBER [User]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [User]
GO
ALTER ROLE [db_owner] ADD MEMBER [PKT]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [PKT]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [PKT]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PKT]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PKT]
GO
ALTER ROLE [db_owner] ADD MEMBER [PGV]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PGV]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Khoa]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Khoa]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Khoa]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Khoa]
GO
/****** Object:  Schema [GV12      ]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE SCHEMA [GV12      ]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_diagramobjects]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	

GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIEM](
	[MASV] [char](12) NOT NULL,
	[MAMH] [char](6) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[DIEM] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_BE7D599357CF411A93B9C33E01A55780]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[MAKH] [char](4) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E67494521D0847AC9F09A90B4BB76CE1]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [char](4) NOT NULL,
	[TENKH] [nvarchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_8CA310AF61214907B89FACEA1AA5BC41]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [char](8) NOT NULL,
	[TENLOP] [nvarchar](200) NULL,
	[MAKH] [char](4) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F569B3131FE54332A8F9ECDF1A426EA0]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](6) NOT NULL,
	[TENMH] [nvarchar](40) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_40607C5FE06C4A49AA0FF7B1C1FD9DFC]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](12) NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[MALOP] [char](8) NOT NULL,
	[PHAI] [bit] NULL,
	[NGAYSINH] [datetime] NULL,
	[NOISINH] [nvarchar](40) NULL,
	[DIACHI] [nvarchar](80) NULL,
	[GHICHU] [ntext] NULL,
	[NGHIHOC] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_6B546E622FBD4281B6BA7B68FB46DBF9]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[DSGV_CTTK]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DSGV_CTTK] AS
  select MAGV, HOTEN=HO+' '+TEN from GIANGVIEN where not EXISTS(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = MAGV) 
					and not EXISTS(select name 
					from LINK_CN_HP.QLDSV.sys.database_principals 
					WHERE type_desc = 'SQL_USER' and name = MAGV)
					and not EXISTS(select name 
					from LINK_VT_HP.QLDSV.sys.database_principals 
					WHERE type_desc = 'SQL_USER' and name = MAGV)




GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT        PUBS.description AS tenCN, SUBS.subscriber_server AS TenServer
FROM            dbo.sysmergepublications AS PUBS INNER JOIN
                         dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server


GO
/****** Object:  View [dbo].[v_DSGV]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_DSGV]
AS
SELECT        MAGV, HO + ' ' + TEN AS HOTEN
FROM            dbo.GIANGVIEN


GO
/****** Object:  View [dbo].[v_DSLOP]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_DSLOP]
AS
SELECT        MALOP, TENLOP
FROM            dbo.LOP


GO
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'11115 ', 1, 9, N'2ba2dd10-da2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'111177', 1, 8, N'07a42d64-dc2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'CSDL  ', 1, 10, N'c187e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'CSDLPT', 1, 3, N'c287e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'CTDL  ', 1, 5, N'c387e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'int   ', 1, 9, N'ad14cb62-db2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'THDC  ', 1, 7, N'4273c7ab-dc2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'thdc2 ', 1, 5, N'e6221eec-db2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101    ', N'VB    ', 1, 6, N'371abde0-dc2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA102    ', N'11115 ', 1, 8, N'61c1ebc3-dd2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA102    ', N'CSDL  ', 1, 9.75, N'c487e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA102    ', N'CSDLPT', 1, 8, N'c587e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA102    ', N'CTDL  ', 1, 4, N'c687e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA103    ', N'11115 ', 1, 9.5, N'137a4b04-8430-eb11-9540-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA103    ', N'CSDLPT', 1, 5, N'ca87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA103    ', N'CTDL  ', 1, 7, N'cb87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA105    ', N'CSDLPT', 1, 7, N'cc87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA105    ', N'CTDL  ', 1, 8, N'cd87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN     ', N'11115 ', 1, 9, N'86e12dc3-d22f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN     ', N'CTDL  ', 1, 4, N'd187e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN     ', N'TRR3  ', 1, 8, N'd387e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN013  ', N'11115 ', 1, 4, N'805f5cc9-7e43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN013  ', N'CTDL  ', 1, 7, N'd487e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN013  ', N'TRR3  ', 1, 9, N'd587e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN103  ', N'TRR3  ', 1, 0, N'd687e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN104  ', N'11115 ', 1, 0, N'89e12dc3-d22f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N15DCCN104  ', N'TRR3  ', 1, 2.4, N'd887e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN115  ', N'11115 ', 1, 3, N'1efb285d-da2f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'1     ', 1, 3, N'13b5358f-6d43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'11115 ', 1, 3, N'6c607140-6c31-eb11-9540-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'CSDLPT', 1, 7, N'da87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'CTDL  ', 1, 8, N'db87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'LTCB  ', 1, 2, N'135f83bb-6d43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'thdc2 ', 1, 8, N'22812514-6743-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'TRR3  ', 1, 3, N'120509f9-d044-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN116  ', N'TRR3  ', 2, 7, N'03778918-d144-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN117  ', N'11115 ', 1, 4, N'6d607140-6c31-eb11-9540-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN117  ', N'CSDLPT', 1, 3, N'dc87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N16DCCN117  ', N'CTDL  ', 1, 4, N'de87e8fb-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'1     ', 1, 4, N'14b5358f-6d43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'CTDL  ', 1, 2, N'83b29b34-3440-eb11-9548-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'CTDL  ', 2, 3, N'1e64c03f-3440-eb11-9548-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'LTCB  ', 1, 4, N'145f83bb-6d43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'thdc2 ', 1, 4, N'23812514-6743-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'TRR3  ', 1, 3, N'130509f9-d044-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN010  ', N'TRR3  ', 2, 7, N'04778918-d144-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'1     ', 1, 6, N'15b5358f-6d43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'11115 ', 1, 10, N'78858477-d22f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'CSDLPT', 1, 8, N'4d6d55b5-ce28-eb11-953b-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'n17dccn074  ', N'ctdl  ', 1, 8, N'020d19c6-d12f-eb11-953f-1cbfce20fee6')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'LTCB  ', 1, 6, N'155f83bb-6d43-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'thdc2 ', 1, 9, N'24812514-6743-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'TRR3  ', 1, 6, N'140509f9-d044-eb11-954a-74d02b6236b7')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'N17DCCN074  ', N'VB    ', 2, 9, N'c95d46f7-7e43-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV01      ', N'NGUYEN HONG', N'SON       ', N'CNTT', N'5d93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV02      ', N'TRUONG DINH', N'HUY       ', N'CNTT', N'5e93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV10      ', N'Master', N'Yi', N'CNTT', N'2a1facca-5831-eb11-9540-1cbfce20fee6')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV12      ', N'Yasuo', N'God', N'CNTT', N'75dd46ed-5831-eb11-9540-1cbfce20fee6')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV14      ', N'Nguyễn', N'Ngạn', N'CNTT', N'71b88274-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV16      ', N'Phạm', N'Huy', N'CNTT', N'474a067c-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV18      ', N'Đại Địa ', N'Chấn', N'CNTT', N'ff3ea68a-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'CNTT', N'Công nghệ thông tin', N'5393e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'1111    ', N'1111111111111111111111111111', N'CNTT', N'1cd21ed0-6244-eb11-954a-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C10THA1 ', N'Cao dang chính qui CNTT gtrt5', N'CNTT', N'6193e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D15CQCN1', N'Đại học chính qui 1  ngành Hệ thống thông tin Khóa 2015', N'CNTT', N'6393e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16CQC1 ', N'Đại học chính qui 1  ngành Công nghệ thông tin Khóa 2016', N'CNTT', N'6293e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D16CQC2 ', N'Đại học chính quy 2  ngành Công nghệ thông tin Khóa 2016', N'CNTT', N'40cb04ce-9e4f-ea11-ac88-b46d83a05351')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D17CQCN2', N'Đại học chính quy 1 ngành Công nghệ thông tin khóa 2017', N'CNTT', N'a9a5793f-5e50-ea11-ac89-2047472e644d')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D17CQCP1', N'CÔNG NGHỆ PHẦN MỀM 1', N'CNTT', N'6f2079ab-ce28-eb11-953b-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D17CQCP2', N'CNPM2', N'CNTT', N'06f22458-1244-eb11-954a-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D19CQCN2', N'Đại học chính quy 2 ngành Công nghệ thông tin Khóa 2019', N'CNTT', N'43cb04ce-9e4f-ea11-ac88-b46d83a05351')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D20CQCN2', N'Đại học chính quy 2 Ngành Công nghệ thông tin khóa 2020', N'CNTT', N'141732c7-285c-ea11-ac8b-2047472e644d')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'MBK     ', N'MBK', N'CNTT', N'4ef0c731-1a3e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'MK      ', N'MAT', N'CNTT', N'e2fe3eab-173e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'MKJ     ', N'MBKđ', N'CNTT', N'64f89115-5e44-eb11-954a-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'QBKT    ', N'KTQB', N'CNTT', N'cebb4b39-1a3e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'1     ', N'22', N'e42e0160-883e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'11111 ', N'1111111111111111111111111111111111111111', N'df9c6f62-6144-eb11-954a-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'11112 ', N'Cơ sở dữ liệu 4', N'95ae1a3f-8226-eb11-953a-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'11115 ', N'111', N'a19740a3-8626-eb11-953a-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'111177', N'11177', N'f119a1b1-8626-eb11-953a-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'22    ', N'33', N'6aff4379-883e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDL  ', N'Cơ sở dữ liệu', N'5693e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDLPT', N'Cơ sở dữ liệu phân tán', N'5793e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CTDL  ', N'Cấu trúc dữ liệu', N'5593e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'hehehe', N'Cơ sở dữ liệu 2', N'57ef1c3c-7d26-eb11-953a-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'huy   ', N'11', N'd1574d97-883e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'int   ', N'11111', N'04b960d7-5826-eb11-953a-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTCB  ', N'Lập trình căn bản', N'5993e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTM   ', N'Lập trình mạng', N'86840e01-2a2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'THCS1 ', N'Tin học cơ sở 1', N'5a93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'THDC  ', N'Tin học đại cương', N'5b93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'thdc2 ', N'111114', N'4cec6193-f02b-eb11-953f-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR1  ', N'Toán rời rạc 1', N'5c93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR3  ', N'Toán rời rạc 3', N'19b24f09-2a2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'VB    ', N'Lập trình Visual Basic nâng cao', N'5893e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'vb2   ', N'Toán rời rạc  1', N'afa08e51-883e-eb11-9548-1cbfce20fee6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'vb24  ', N'5555', N'2f3986e2-8526-eb11-953a-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA101    ', N' Lê Ha', N'Vân', N'D16CQC1 ', 0, CAST(N'1976-06-06 00:00:00.000' AS DateTime), NULL, N'Ngô Quyền', N' ', 0, N'3fa2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA102    ', N'Trần Thi', N'Hoa', N'D16CQC1 ', 0, CAST(N'1976-07-07 00:00:00.000' AS DateTime), NULL, N'222 Lý Thánh Tông', N' ', 0, N'40a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA103    ', N'Nguyễn Thị Yến', N'Lan', N'D16CQC1 ', 0, CAST(N'1976-08-08 00:00:00.000' AS DateTime), NULL, N'33 California', N'', 0, N'41a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA104    ', N'Nguyễn ', N'Phong', N'D16CQC1 ', 1, CAST(N'2020-01-15 00:00:00.000' AS DateTime), NULL, N'Khánh Hòa', N'', 0, N'42a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA105    ', N'Nguyễn', N'Quận', N'D16CQC1 ', 1, CAST(N'2019-12-13 00:00:00.000' AS DateTime), NULL, N'22 Ngô Quyền', N'', 0, N'43a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN     ', N'Lê Thị', N'Hà', N'D15CQCN1', 0, CAST(N'1995-02-19 00:00:00.000' AS DateTime), NULL, N'CAN THO', N' ', 0, N'45a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN013  ', N'Tran Nguyen', N'Minh', N'D15CQCN1', 1, CAST(N'1995-06-19 00:00:00.000' AS DateTime), NULL, N'22 Cà Mau', N' ', 0, N'46a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN102  ', N'Nguyễn', N'phong', N'D15CQCN1', 1, CAST(N'2019-12-10 00:00:00.000' AS DateTime), NULL, N'Quảng Ngãi', N' ', 1, N'47a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN103  ', N'Nguyễn Văn', N'Thuận', N'D15CQCN1', 1, CAST(N'2019-06-12 00:00:00.000' AS DateTime), NULL, N'Quảng Ngãi', NULL, 0, N'48a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN104  ', N'Nguyễn ', N'Thái', N'D15CQCN1', 1, CAST(N'2020-03-17 00:00:00.000' AS DateTime), NULL, N'Đức Phổ', NULL, 1, N'49a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN115  ', N'Lê', N'Huy', N'D16CQC2 ', 1, CAST(N'2019-04-22 00:00:00.000' AS DateTime), NULL, N'Đức Phổ', N'haha', 0, N'4ba2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN116  ', N'Nguyễn Thanh', N'Huy', N'D17CQCP1', 1, CAST(N'2019-12-10 00:00:00.000' AS DateTime), NULL, N'Quảng Ngãi', N'', 0, N'4ca2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN117  ', N'Nguyễn Thanh', N'Phong', N'D16CQC2 ', 1, CAST(N'2019-02-19 00:00:00.000' AS DateTime), NULL, N'Quảng Ngãi', N'hihi', 0, N'4da2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N17DCCN010  ', N'HỒ MINH QUỐC ', N'BẢO', N'D17CQCP1', 1, CAST(N'1999-03-04 00:00:00.000' AS DateTime), N'ĐỒNG NAI', N'HCM', NULL, 0, N'b65a7fcb-5a35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N17DCCN074  ', N'TRẦN AN', N'KHOA', N'D17CQCP1', 1, CAST(N'1999-05-18 00:00:00.000' AS DateTime), N'ĐĂK LĂK', N'HCM', NULL, 0, N'4c6d55b5-ce28-eb11-953b-74d02b6236b7')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'N19DCCN118  ', N'Nguyễn ', N'Máy', N'D19CQCN2', 1, CAST(N'1989-06-14 00:00:00.000' AS DateTime), NULL, N'TP.Quảng Ngãi', NULL, 0, N'4ea2b3b4-2c2e-eb11-953f-1cbfce20fee6')
/****** Object:  Index [MSmerge_index_277576027]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_277576027] ON [dbo].[DIEM]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_309576141]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_309576141] ON [dbo].[GIANGVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_373576369]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_373576369] ON [dbo].[KHOA]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_TENLOP]    Script Date: 23-Dec-20 5:04:21 PM ******/
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [UK_TENLOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_405576483]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_405576483] ON [dbo].[LOP]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MONHOC]    Script Date: 23-Dec-20 5:04:21 PM ******/
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [IX_MONHOC] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_437576597]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_437576597] ON [dbo].[MONHOC]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_469576711]    Script Date: 23-Dec-20 5:04:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_469576711] ON [dbo].[SINHVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_DIEM_MONHOC1] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_MONHOC1]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[LOP]  WITH NOCHECK ADD  CONSTRAINT [FK_LOP_KHOA1] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA1]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM_DIEM] CHECK NOT FOR REPLICATION (([DIEM]>=(0) AND [DIEM]<=(10)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK_DIEM_DIEM]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM_LAN] CHECK NOT FOR REPLICATION (([LAN]=(1) OR [LAN]=(2)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK_DIEM_LAN]
GO
/****** Object:  StoredProcedure [dbo].[GETDSGV]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GETDSGV]
AS
select MAGV,Hoten=(ho+' '+ ten) from GIANGVIEN

GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKID]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKID] 
@Ma NVARCHAR(15),
@Type NVARCHAR(15)
AS
BEGIN
	-- LOP
	IF(@Type = 'MALOP')
	BEGIN	
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.MALOP = @Ma)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINk_CN_VT.QLDSV.dbo.LOP AS LOP WHERE LOP.MALOP = @Ma)
			RETURN 2;	--Mã NV tồn tại ở phân mãnh  khác
	END

	--MON HOC
	IF(@Type = 'MAMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE MAMH = @Ma)
		RETURN 1;
	END

	--SINH VIEN
	IF(@Type = 'MASV')
	BEGIN
		
		IF EXISTS(SELECT * FROM dbo.SINHVIEN WHERE dbo.SINHVIEN.MASV = @Ma)
			RETURN 1; -- Mã tồn tại ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINk_CN_VT.QLDSV.dbo.SINHVIEN AS SV WHERE SV.MASV = @Ma)
			RETURN 2;	--Mã tồn tại ở phân mãnh  khác
	END

	RETURN 0	--Không bị trùng được thêm
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKNAME]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHECKNAME]
@Name NVARCHAR(200),
@Type NVARCHAR(50)
AS
BEGIN
	--Kiểm tra Table lop của server hiện tại
	IF(@Type = 'TENLOP')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.TENLOP = @Name)
			RETURN 1; -- @name bị trùng  ở phân mãnh hiện tại
	
		ELSE IF EXISTS(SELECT * FROM LINK_CN_VT.QLDSV.dbo.LOP AS LOP WHERE LOP.TENLOP = @Name)
			RETURN 2;	--@name bị trùng ở phân mãnh  khác
	END

	IF(@Type = 'TENMONHOC')
	BEGIN
		IF EXISTS(SELECT * FROM dbo.MONHOC WHERE TENMH = @Name)
		RETURN 1;
	END
	
	RETURN 0	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CHUYENLOP]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CHUYENLOP]
@MASV NVARCHAR(12),-- de update status thanh nghi hoc
@MASVMOI NVARCHAR(12), -- de insert vao khoa moi
@MALOPCHUYENDEN NVARCHAR(12) -- ma lop moi se chuyen den
AS
BEGIN

	SET XACT_ABORT ON
	BEGIN TRY
		BEGIN DISTRIBUTED TRANSACTION
		
		INSERT INTO LINK_CN_VT.QLDSV.dbo.SINHVIEN (MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC)
		SELECT @MASVMOI AS MASV,HO,TEN,@MALOPCHUYENDEN AS MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,0 FROM dbo.SINHVIEN WHERE MASV = @MASV
		UPDATE dbo.SINHVIEN SET NGHIHOC=1 WHERE MASV = @MASV;-- Cap nhap trang thai nghi hoc cua sinh vien o site hien tai
		IF(@@TRANCOUNT > 0)
		BEGIN
			
			COMMIT TRANSACTION
			RETURN 0	--Thành công
		END
	END TRY

	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION
			RETURN -1;
		END
	END CATCH
	SET XACT_ABORT OFF
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM GIANGVIEN  WHERE MAGV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_DIEM]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_DIEM] @MASV NVARCHAR(12),  
@MAMH NVARCHAR(10),  
@LAN  smallint,  
@DIEM float  
AS  
BEGIN  
	SET XACT_ABORT ON
	BEGIN TRY
	BEGIN DISTRIBUTED TRANSACTION
            IF EXISTS (SELECT 1 FROM DIEM WHERE MASV=@MASV AND MAMH=@MAMH AND LAN=@LAN)  
                BEGIN  
                    UPDATE DIEM  
                    SET DIEM = @DIEM   
                    WHERE MASV= @MASV AND LAN=@LAN AND MAMH=@MAMH  
                END  
            ELSE  
                BEGIN  
                    INSERT INTO DBO.DIEM (MASV, MAMH, LAN, DIEM)  
                    VALUES (@MASV, @MAMH, @LAN, @DIEM)  
                END
			IF(@@TRANCOUNT > 0)
			BEGIN
				COMMIT TRANSACTION
				RETURN 0	--Thành công
			END
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION
			RETURN -1;
		END
	END CATCH
	SET XACT_ABORT OFF   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEMTRADIEMTHEOLAN]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KIEMTRADIEMTHEOLAN]
@MALOP VARCHAR(12),  
@MAMH VARCHAR(12),  
@LAN  INT
AS
BEGIN
	IF EXISTS( SELECT * FROM [QLDSV].[dbo].[SINHVIEN] SV
		INNER JOIN [QLDSV].[dbo].[DIEM] D
		ON SV.MASV = D.MASV
		WHERE MAMH = @MAMH AND MALOP = @MALOP AND LAN = @LAN)
		BEGIN
		return 1
		END
	ELSE
	return 0
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LAYDIEMSINHVIEN]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------@MALOP, @MAMH, @LAN; trả về MASV, HOTEN, DIEM
CREATE PROCEDURE [dbo].[SP_LAYDIEMSINHVIEN]
@MALOP VARCHAR (12),
@MAMH VARCHAR (12),
@LAN INT
AS
BEGIN
		
		SELECT INFO.MASV, CONCAT(HO, ' ', TEN) AS HOTEN, DIEM FROM 
		(SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP=@MALOP AND NGHIHOC = 'false') INFO
		LEFT JOIN 
		(SELECT MASV, DIEM FROM DIEM WHERE MAMH=@MAMH AND LAN =@LAN) DIEM
		ON INFO.MASV = DIEM.MASV
	
END


GO
/****** Object:  StoredProcedure [dbo].[SP_ReportBDTK]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReportBDTK]
@MALOP NVARCHAR(15)
AS
BEGIN
	SELECT INFO.MASV,INFO.HOTEN, MONHOC.TENMH, DIEM = MAX(DIEM.DIEM) 
	FROM (
		SELECT MASV, HO+' '+TEN as HOTEN
		FROM SINHVIEN
		WHERE MALOP=@MALOP and NGHIHOC= 'false'
	)AS INFO
	INNER JOIN DIEM ON DIEM.MASV =INFO.MASV 
	INNER JOIN MONHOC ON DIEM.MAMH= MONHOC.MAMH
	GROUP BY INFO.MASV,INFO.HOTEN, MONHOC.TENMH
	ORDER BY INFO.MASV
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReportDSSV]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportDSSV] @MALOP char(8)
AS
DECLARE @TENLOP nvarchar(200)
select @TENLOP = TENLOP FROM LOP where MALOP = @MALOP
select ROW_NUMBER() OVER (ORDER BY HO) AS STT,TENLOP = @TENLOP,MASV,HO,TEN,
	case when phai = 0 then N'Nữ'
	else N'Nam'end as PHAI,
	NGAYSINH,NOISINH,DIACHI 
From SINHVIEN 
where MALOP = @MALOP
GO
/****** Object:  StoredProcedure [dbo].[SP_ReportDsThi]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportDsThi] @MALOP NVARCHAR(20)
AS
BEGIN
Select ROW_NUMBER() OVER (ORDER BY MASV) AS STT, MASV,HOTEN=HO+' '+TEN, SOTO='', DIEM='', CHUKY='' from SINHVIEN where malop =@MALOP
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ReportPD]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportPD] @MASV VARCHAR(12)
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY MAMH) AS STT,MONHOC = (SELECT TENMH FROM MONHOC WHERE MONHOC.MAMH = DIEM.MAMH), DIEM = MAX(DIEM) 
	FROM DIEM 
	WHERE MASV = @MASV
	GROUP BY MAMH, MASV	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ReportPDMH]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportPDMH]
@MALOP VARCHAR (12),
@MAMH VARCHAR (12),
@LAN INT
AS
BEGIN
		
		SELECT ROW_NUMBER() OVER (ORDER BY INFO.MASV) AS STT,INFO.MASV, CONCAT(HO, ' ', TEN) AS HOTEN, DIEM FROM 
		(SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP=@MALOP AND NGHIHOC = 'false') INFO
		LEFT JOIN  
		(SELECT MASV, DIEM FROM DIEM WHERE MAMH=@MAMH AND LAN =@LAN) DIEM
		ON INFO.MASV = DIEM.MASV
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TAOLOGIN] @LGNAME varchar(50),
	@pass varchar(50),
	@username varchar(50),
	@role varchar(50)
as
	if exists(select name from sys.server_principals 
				where type in('U','S','G')
				and name NOT LIKE '%##%'
				and name = @LGNAME)
			return 1 --trùng login--
	else if exists(SELECT name FROM sys.database_principals
					WHERE type_desc = 'SQL_USER'
					AND name = @USERNAME)
			return 2
	--DECLARE @RET INT
	--EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV'
	--IF (@RET =1)  -- LOGIN NAME BI TRUNG
	--	RETURN 3
	--EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
	--IF (@RET =1)  -- USER  NAME BI TRUNG
	--BEGIN
	--	   EXEC SP_DROPLOGIN @LGNAME
	--	RETURN 4
	--END
	EXEC sp_addrolemember @ROLE, @USERNAME
	IF @ROLE= 'PGV' OR @ROLE= 'Khoa' oR @ROLE= 'PKT'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
RETURN 0  -- THANH CONG

	
GO
/****** Object:  StoredProcedure [dbo].[Sp_ThemLop]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_ThemLop](@Malop char(8), @TenLop nvarchar(200), @MaKH char(4))
AS
INSERT INTO LOP(MALOP,TENLOP,MAKH)
VALUES (@Malop,@TenLop,@MaKH)

GO
/****** Object:  StoredProcedure [dbo].[sp_TimSV]    Script Date: 23-Dec-20 5:04:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[sp_TimSV]
  @X Nvarchar(10)
AS
 DECLARE @MAKH NVARCHAR(10), @MALOP NVARCHAR(10), 
   @TENLOP NVARCHAR(50), 
   @HO nvarchar(50), @TEN nvarchar(10)
If  exists(select masv from  sinhvien where masv =@X)
 BEGIN
   	SELECT  @MALOP = MALOP,  @HO=HO, @TEN=TEN 
   	FROM SINHVIEN WHERE MASV=@X
    SELECT @TENLOP = TENLOP , @MAKH = MAKH 
      FROM LOP   WHERE MALOP=@MALOP
   SELECT tenlop= @TENLOP,
      	tenkh = (SELECT TENKH FROM KHOA WHERE MAKH=@MAKH), 
          HO=@HO, TEN=@TEN
END
ELSE RAISERROR (N'Mã SV không có trong DS',16,1)

GO
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO
