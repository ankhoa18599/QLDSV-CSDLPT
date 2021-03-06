USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER3\MSSQL\DATA\QLDSV.mdf' , SIZE = 15360KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER3\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 35712KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  User [HTKN_QLDSV]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE USER [HTKN_QLDSV] FOR LOGIN [HTKN_QLDSV] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV10]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE USER [GV10] FOR LOGIN [pkt] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [User]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE ROLE [User]
GO
/****** Object:  DatabaseRole [PKT]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE ROLE [PKT]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [Khoa]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE ROLE [Khoa]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN_QLDSV]
GO
ALTER ROLE [PKT] ADD MEMBER [GV10]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV10]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [GV10]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV10]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV10]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV10]
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
/****** Object:  UserDefinedFunction [dbo].[fn_diagramobjects]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  Table [dbo].[CT_DONGHOCPHI]    Script Date: 23-Dec-20 5:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_DONGHOCPHI](
	[MASV] [char](12) NOT NULL,
	[NIENKHOA] [nvarchar](50) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[NGAYDONG] [date] NOT NULL,
	[SOTIENDONG] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F1D2AD1385FA4552975E9EAE5768349B]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CT_DONGHOCPHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[NIENKHOA] ASC,
	[HOCKY] ASC,
	[NGAYDONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  Table [dbo].[HOCPHI]    Script Date: 23-Dec-20 5:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCPHI](
	[MASV] [char](12) NOT NULL,
	[NIENKHOA] [nvarchar](50) NOT NULL,
	[HOCKY] [int] NOT NULL CONSTRAINT [DF_HOCPHI_HOCKY]  DEFAULT ((1)),
	[HOCPHI] [int] NOT NULL CONSTRAINT [DF_HOCPHI_HOCPHI]  DEFAULT ((6000000)),
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_1A45516AEA9B4B86A547BE86B02B8947]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_HOCPHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[NIENKHOA] ASC,
	[HOCKY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  Table [dbo].[LOP]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
	[NGHIHOC] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_6B546E622FBD4281B6BA7B68FB46DBF9]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[DSGV_CTTK]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN010  ', N'2020-2021', 1, CAST(N'2020-11-10' AS Date), 3000000, N'd9fa6855-5b35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN010  ', N'2020-2021', 2, CAST(N'2020-12-03' AS Date), 4000000, N'1ac538c3-7835-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'n17dccn074  ', N'2018-2019', 1, CAST(N'2020-11-21' AS Date), 3000000, N'd19df1ab-7b43-eb11-954a-74d02b6236b7')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2018-2019', 1, CAST(N'2020-12-03' AS Date), 1000000, N'8606a12d-4c35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2018-2019', 1, CAST(N'2020-12-21' AS Date), 2000000, N'c131cbfc-7743-eb11-954a-74d02b6236b7')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2019-2020', 1, CAST(N'2019-10-03' AS Date), 7000000, N'86294512-1e35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2019-2020', 1, CAST(N'2020-12-03' AS Date), 1000000, N'bc6c677b-4335-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2019-2020', 2, CAST(N'2020-03-05' AS Date), 8000000, N'ac778521-1e35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2020-2021', 1, CAST(N'2020-10-10' AS Date), 1000000, N'cb426749-a834-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2020-2021', 1, CAST(N'2020-10-12' AS Date), 1000000, N'f34f9de0-a834-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2020-2021', 1, CAST(N'2020-10-13' AS Date), 1000000, N'60e880ef-a834-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2020-2021', 1, CAST(N'2020-11-10' AS Date), 5000000, N'7e2b7b74-a834-eb11-9540-1cbfce20fee6')
INSERT [dbo].[CT_DONGHOCPHI] ([MASV], [NIENKHOA], [HOCKY], [NGAYDONG], [SOTIENDONG], [rowguid]) VALUES (N'N17DCCN074  ', N'2020-2021', 1, CAST(N'2020-12-10' AS Date), 300000, N'b0bfd09e-ae3a-eb11-9547-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV01      ', N'NGUYEN HONG', N'SON       ', N'CNTT', N'5d93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV02      ', N'TRUONG DINH', N'HUY       ', N'CNTT', N'5e93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV03      ', N'NGUYEN XUAN', N'KHANH     ', N'VT  ', N'5f93e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV04      ', N'TRAN DINH', N'THUAN     ', N'VT  ', N'6093e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV10      ', N'Master', N'Yi', N'CNTT', N'2a1facca-5831-eb11-9540-1cbfce20fee6')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV11      ', N'Super', N'Man', N'VT  ', N'003fa68a-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV12      ', N'Yasuo', N'God', N'CNTT', N'75dd46ed-5831-eb11-9540-1cbfce20fee6')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV13      ', N'Lazy', N'Boy', N'VT  ', N'7ebaf995-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV14      ', N'Nguyễn', N'Ngạn', N'CNTT', N'71b88274-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV15      ', N'Nguyễn', N'Đậu', N'VT  ', N'14cb8ea5-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV16      ', N'Phạm', N'Huy', N'CNTT', N'474a067c-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV17      ', N'Lê', N'Ngọc', N'VT  ', N'f74001ac-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [MAKH], [rowguid]) VALUES (N'GV18      ', N'Đại Địa ', N'Chấn', N'CNTT', N'ff3ea68a-2c44-eb11-954a-74d02b6236b7')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN010  ', N'2020-2021', 1, 8500000, N'86648ff5-5a35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN010  ', N'2020-2021', 2, 9000000, N'3e42c5fe-5a35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN074  ', N'2018-2019', 1, 10000000, N'902423bd-4635-eb11-9540-1cbfce20fee6')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN074  ', N'2018-2019', 2, 10000000, N'1566b6cc-4635-eb11-9540-1cbfce20fee6')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN074  ', N'2019-2020', 1, 10000000, N'875ab80a-1e35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN074  ', N'2019-2020', 2, 8000000, N'85294512-1e35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY], [HOCPHI], [rowguid]) VALUES (N'N17DCCN074  ', N'2020-2021', 1, 8500000, N'55e7aa03-a834-eb11-9540-1cbfce20fee6')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'CNTT', N'Công nghệ thông tin', N'5393e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'VT  ', N'Viễn thông', N'5493e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'1111    ', N'1111111111111111111111111111', N'CNTT', N'1cd21ed0-6244-eb11-954a-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C10THA1 ', N'Cao dang chính qui CNTT gtrt5', N'CNTT', N'6193e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D07VTA1 ', N'Đại học chính quy 1 Viễn thông kháo 2007', N'VT  ', N'3ecb04ce-9e4f-ea11-ac88-b46d83a05351')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D08VTA1 ', N'Đại học chính qui 1  Viễn thông Khóa 2008', N'VT  ', N'6493e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D09VTA1 ', N'Đại học chính qui 1  Viễn thông Khóa 2009', N'VT  ', N'6593e2fe-7f0e-eb11-952e-74d02b6236b7')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D10VTC  ', N'Đại học chính quy 1 Viễn thông khóa 2009', N'VT  ', N'3fcb04ce-9e4f-ea11-ac88-b46d83a05351')
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
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'08VTA101    ', N'Nguyễn Thanh', N'Hằng', N'D08VTA1 ', 1, CAST(N'1975-12-07 00:00:00.000' AS DateTime), 0, N'3da2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'08VTA102    ', N'Võ Văn', N'Phát', N'D08VTA1 ', 1, CAST(N'1976-05-05 00:00:00.000' AS DateTime), 0, N'3ea2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'09THA101    ', N' Lê Ha', N'Vân', N'D16CQC1 ', 0, CAST(N'1976-06-06 00:00:00.000' AS DateTime), 0, N'3fa2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'09THA102    ', N'Trần Thi', N'Hoa', N'D16CQC1 ', 0, CAST(N'1976-07-07 00:00:00.000' AS DateTime), 0, N'40a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'09THA103    ', N'Nguyễn Thị Yến', N'Lan', N'D16CQC1 ', 0, CAST(N'1976-08-08 00:00:00.000' AS DateTime), 0, N'41a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'09THA104    ', N'Nguyễn ', N'Phong', N'D16CQC1 ', 1, CAST(N'2020-01-15 00:00:00.000' AS DateTime), 0, N'42a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'09THA105    ', N'Nguyễn', N'Quận', N'D16CQC1 ', 1, CAST(N'2019-12-13 00:00:00.000' AS DateTime), 0, N'43a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'D17VTCN001  ', N'Nguyễn ', N'Thanh Kẹ', N'D07VTA1 ', 1, CAST(N'2019-12-04 00:00:00.000' AS DateTime), 0, N'44a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN     ', N'Lê Thị', N'Hà', N'D15CQCN1', 0, CAST(N'1995-02-19 00:00:00.000' AS DateTime), 0, N'45a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN013  ', N'Tran Nguyen', N'Minh', N'D15CQCN1', 1, CAST(N'1995-06-19 00:00:00.000' AS DateTime), 0, N'46a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN102  ', N'Nguyễn', N'phong', N'D15CQCN1', 1, CAST(N'2019-12-10 00:00:00.000' AS DateTime), 1, N'47a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN103  ', N'Nguyễn Văn', N'Thuận', N'D15CQCN1', 1, CAST(N'2019-06-12 00:00:00.000' AS DateTime), 0, N'48a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N15DCCN104  ', N'Nguyễn ', N'Thái', N'D15CQCN1', 1, CAST(N'2020-03-17 00:00:00.000' AS DateTime), 1, N'49a2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN076  ', N'Võ Duy', N'Khánh', N'D10VTC  ', 0, CAST(N'2020-03-25 00:00:00.000' AS DateTime), 0, N'4aa2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN115  ', N'Lê', N'Huy', N'D16CQC2 ', 1, CAST(N'2019-04-22 00:00:00.000' AS DateTime), 0, N'4ba2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN116  ', N'Nguyễn Thanh', N'Huy', N'D17CQCP1', 1, CAST(N'2019-12-10 00:00:00.000' AS DateTime), 0, N'4ca2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N16DCCN117  ', N'Nguyễn Thanh', N'Phong', N'D16CQC2 ', 1, CAST(N'2019-02-19 00:00:00.000' AS DateTime), 0, N'4da2b3b4-2c2e-eb11-953f-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N17DCCN010  ', N'HỒ MINH QUỐC ', N'BẢO', N'D17CQCP1', 1, CAST(N'1999-03-04 00:00:00.000' AS DateTime), 0, N'b65a7fcb-5a35-eb11-9540-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N17DCCN074  ', N'TRẦN AN', N'KHOA', N'D17CQCP1', 1, CAST(N'1999-05-18 00:00:00.000' AS DateTime), 0, N'4c6d55b5-ce28-eb11-953b-74d02b6236b7')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N17DCVT104  ', N'Nguyễn ', N'Thái', N'D10VTC  ', 1, CAST(N'2020-03-17 00:00:00.000' AS DateTime), 0, N'ac4e0a60-3540-eb11-9548-1cbfce20fee6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NGHIHOC], [rowguid]) VALUES (N'N19DCCN118  ', N'Nguyễn ', N'Máy', N'D19CQCN2', 1, CAST(N'1989-06-14 00:00:00.000' AS DateTime), 0, N'4ea2b3b4-2c2e-eb11-953f-1cbfce20fee6')
/****** Object:  Index [MSmerge_index_245575913]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_245575913] ON [dbo].[CT_DONGHOCPHI]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_309576141]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_309576141] ON [dbo].[GIANGVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_341576255]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_341576255] ON [dbo].[HOCPHI]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_373576369]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_373576369] ON [dbo].[KHOA]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UK_TENLOP]    Script Date: 23-Dec-20 5:05:31 PM ******/
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [UK_TENLOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_405576483]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_405576483] ON [dbo].[LOP]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [id_sv]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE NONCLUSTERED INDEX [id_sv] ON [dbo].[SINHVIEN]
(
	[MASV] ASC
)
INCLUDE ( 	[HO],
	[TEN],
	[MALOP]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_469576711]    Script Date: 23-Dec-20 5:05:31 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_469576711] ON [dbo].[SINHVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI]  WITH NOCHECK ADD  CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI] FOREIGN KEY([MASV], [NIENKHOA], [HOCKY])
REFERENCES [dbo].[HOCPHI] ([MASV], [NIENKHOA], [HOCKY])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CT_DONGHOCPHI] CHECK CONSTRAINT [FK_CT_DONGHOCPHI_HOCPHI]
GO
ALTER TABLE [dbo].[GIANGVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_GIANGVIEN_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[GIANGVIEN] CHECK CONSTRAINT [FK_GIANGVIEN_KHOA]
GO
ALTER TABLE [dbo].[HOCPHI]  WITH NOCHECK ADD  CONSTRAINT [FK_HOCPHI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[HOCPHI] CHECK CONSTRAINT [FK_HOCPHI_SINHVIEN]
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
/****** Object:  StoredProcedure [dbo].[CT_HOADON]    Script Date: 23-Dec-20 5:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CT_HOADON] @MASV NVARCHAR(20)
AS
BEGIN
		--select HP.NIENKHOA,HP.HOCKY,HP.HOCPHI,SOTIENDADONG=(SELECT sum(SOTIENDONG) FROM CT_DONGHOCPHI CT WHERE CT.MASV=@MASV AND CT.NIENKHOA=hp.NIENKHOA AND CT.HOCKY=hp.HOCKY) from HOCPHI hp
		--where HP.MASV=@MASV
		--group by HP.NIENKHOA,HP.HOCKY,HOCPHI 
		--SELECT HP.NIENKHOA,HP.HOCKY,HP.HOCPHI,CT.SOTIENDONG SOTIENDADONG FROM 
		--	(SELECT MASV,NIENKHOA,HOCKY,HOCPHI FROM HOCPHI WHERE MASV=@MASV) HP
		--	LEFT JOIN 
		--	(SELECT MASV,NIENKHOA,HOCKY,SOTIENDONG=SUM(SOTIENDONG) FROM CT_DONGHOCPHI group by NIENKHOA,HOCKY,MASV) CT
		--	ON HP.NIENKHOA=CT.NIENKHOA and HP.HOCKY=CT.HOCKY AND HP.MASV = CT.MASV
	
	SELECT HP.NIENKHOA,HP.HOCKY,HP.HOCPHI,CT.SOTIENDONG SOTIENDADONG FROM 
			(SELECT NIENKHOA,HOCKY,HOCPHI FROM HOCPHI WHERE MASV=@MASV) HP
			LEFT JOIN 
			(SELECT NIENKHOA,HOCKY,SOTIENDONG=SUM(SOTIENDONG) FROM CT_DONGHOCPHI WHERE MASV=@MASV group by NIENKHOA,HOCKY) CT
			ON HP.NIENKHOA=CT.NIENKHOA and HP.HOCKY=CT.HOCKY
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ReportHP]    Script Date: 23-Dec-20 5:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReportHP] @MALOP NVARCHAR(20),
@NIENKHOA NVARCHAR(20),
@HOCKY INT
AS
BEGIN
	select ROW_NUMBER() OVER (ORDER BY SV.TEN) AS STT, HOTEN=SV.HO+' '+SV.TEN,HP.HOCPHI,CT.SOTIENDADONG
	from (select MASV,HO,TEN from SINHVIEN where MALOP=@MALOP) as SV	
	left join 
	(select MASV,HOCPHI FROM HOCPHI Where NIENKHOA = @NIENKHOA and HOCKY=@HOCKY) as HP
	ON HP.MASV=SV.MASV
	left join
	(select MASV,SOTIENDADONG=SUM(SOTIENDONG) FROM CT_DONGHOCPHI WHERE NIENKHOA = @NIENKHOA and HOCKY=@HOCKY GROUP BY MASV) as CT
	ON HP.MASV=CT.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOLOGIN]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_ThemLop]    Script Date: 23-Dec-20 5:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sp_ThemLop](@Malop char(8), @TenLop nvarchar(200), @MaKH char(4))
AS
INSERT INTO LOP(MALOP,TENLOP,MAKH)
VALUES (@Malop,@TenLop,@MaKH)

GO
/****** Object:  StoredProcedure [dbo].[sp_TimSV]    Script Date: 23-Dec-20 5:05:31 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_HOCPHI]    Script Date: 23-Dec-20 5:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UPDATE_HOCPHI] @MASV NVARCHAR(12),  
@NIENKHOA NVARCHAR(50),  
@HOCKY  smallint,  
@NGAY NVARCHAR(20), 
@SOTIEN INT
AS  
BEGIN
	SET XACT_ABORT ON
	BEGIN TRY
	BEGIN DISTRIBUTED TRANSACTION 
            IF EXISTS (SELECT 1 FROM CT_DONGHOCPHI WHERE MASV = @MASV AND NGAYDONG=@NGAY AND NIENKHOA=@NIENKHOA)
			BEGIN  
				COMMIT TRANSACTION
                RETURN 1 
			END 
            ELSE  
                BEGIN  
                    INSERT INTO CT_DONGHOCPHI (MASV, NIENKHOA, HOCKY, NGAYDONG,SOTIENDONG)  
                    VALUES (@MASV, @NIENKHOA, @HOCKY, @NGAY,@SOTIEN)  
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
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO
