USE [master]
GO
/****** Object:  Database [BusManager]    Script Date: 3/25/2019 10:06:05 PM ******/
CREATE DATABASE [BusManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BusManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BusManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BusManager] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BusManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusManager] SET  MULTI_USER 
GO
ALTER DATABASE [BusManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BusManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusManager] SET QUERY_STORE = OFF
GO
USE [BusManager]
GO
/****** Object:  UserDefinedFunction [dbo].[StaffID]    Script Date: 3/25/2019 10:06:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[StaffID]()
returns varchar(6)
as
begin
	DECLARE @id INT
	Set @id = (Select MAX(Cast(right(MSNV,4) as int)) from Staff)
	
	if @id is null set @id = 0
	Return 'ST' + right('0000' + convert(varchar(10),(@id + 1)),4)
end
GO
/****** Object:  Table [dbo].[Bus]    Script Date: 3/25/2019 10:06:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bus](
	[BusID] [varchar](6) NOT NULL,
	[BSX] [nvarchar](10) NOT NULL,
	[Brand] [nvarchar](50) NULL,
	[DateRegistration] [date] NULL,
	[OwnerId] [varchar](6) NULL,
	[IDTuyenDuong] [int] NULL,
 CONSTRAINT [PK_Bus_1] PRIMARY KEY CLUSTERED 
(
	[BusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BusStation]    Script Date: 3/25/2019 10:06:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusStation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BusID] [varchar](6) NULL,
	[MSNVDRIVER] [varchar](6) NULL,
	[DepartureTime] [datetime] NULL,
	[TimeBack] [datetime] NULL,
	[MSNVCAST] [varchar](6) NULL,
	[Status] [nvarchar](10) NULL,
 CONSTRAINT [PK_BusStation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owner]    Script Date: 3/25/2019 10:06:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owner](
	[Id] [varchar](6) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[CMND] [nvarchar](9) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 3/25/2019 10:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Role] [varchar](10) NOT NULL,
	[NameRole] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Route]    Script Date: 3/25/2019 10:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TuyenDuong] [nvarchar](max) NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 3/25/2019 10:06:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[MSNV] [varchar](6) NOT NULL,
	[CMND] [nvarchar](9) NULL,
	[Name] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Role] [varchar](10) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bus] ([BusID], [BSX], [Brand], [DateRegistration], [OwnerId], [IDTuyenDuong]) VALUES (N'BU0001', N'49D-4567', N'Honda', CAST(N'2019-03-10' AS Date), N'OW0001', 2)
INSERT [dbo].[Bus] ([BusID], [BSX], [Brand], [DateRegistration], [OwnerId], [IDTuyenDuong]) VALUES (N'BU0002', N'30F-1234', N'Honda', CAST(N'2019-03-10' AS Date), N'OW0002', 2)
INSERT [dbo].[Bus] ([BusID], [BSX], [Brand], [DateRegistration], [OwnerId], [IDTuyenDuong]) VALUES (N'BU0003', N'50E-0908', N'Honda', CAST(N'2019-03-10' AS Date), N'OW0001', 3)
INSERT [dbo].[Bus] ([BusID], [BSX], [Brand], [DateRegistration], [OwnerId], [IDTuyenDuong]) VALUES (N'BU0004', N'49D-533299', N'Honda', CAST(N'2019-03-10' AS Date), N'OW0001', 1011)
SET IDENTITY_INSERT [dbo].[BusStation] ON 

INSERT [dbo].[BusStation] ([Id], [BusID], [MSNVDRIVER], [DepartureTime], [TimeBack], [MSNVCAST], [Status]) VALUES (1, N'BU0001', N'ST0003', CAST(N'2019-04-01T10:00:00.000' AS DateTime), CAST(N'2019-04-01T12:00:00.000' AS DateTime), N'ST0001', N'wait')
INSERT [dbo].[BusStation] ([Id], [BusID], [MSNVDRIVER], [DepartureTime], [TimeBack], [MSNVCAST], [Status]) VALUES (2, N'BU0001', N'ST0001', CAST(N'2019-04-01T13:00:00.000' AS DateTime), CAST(N'2019-04-08T15:00:00.000' AS DateTime), N'ST0002', N'going')
INSERT [dbo].[BusStation] ([Id], [BusID], [MSNVDRIVER], [DepartureTime], [TimeBack], [MSNVCAST], [Status]) VALUES (3, N'BU0001', N'ST0004', CAST(N'2019-03-25T21:00:00.000' AS DateTime), CAST(N'2019-03-25T22:00:00.000' AS DateTime), N'ST0004', N'Waiting')
INSERT [dbo].[BusStation] ([Id], [BusID], [MSNVDRIVER], [DepartureTime], [TimeBack], [MSNVCAST], [Status]) VALUES (5, N'BU0004', N'ST0003', CAST(N'2019-03-26T05:11:28.000' AS DateTime), CAST(N'2019-03-26T06:11:28.000' AS DateTime), N'ST0003', N'wait')
SET IDENTITY_INSERT [dbo].[BusStation] OFF
INSERT [dbo].[Owner] ([Id], [Name], [Phone], [DateOfBirth], [CMND], [Address]) VALUES (N'OW0001', N'Nguyễn Văn Cường', N'0908200399', CAST(N'1970-09-27' AS Date), N'159753654', N'900 Tạ Quang Bửu')
INSERT [dbo].[Owner] ([Id], [Name], [Phone], [DateOfBirth], [CMND], [Address]) VALUES (N'OW0002', N'Lê Thị Ngọc Sương', N'0908533299', CAST(N'1971-10-27' AS Date), N'127894567', N'34 Trần Hưng Đạo')
INSERT [dbo].[Owner] ([Id], [Name], [Phone], [DateOfBirth], [CMND], [Address]) VALUES (N'OW0003', N'Huy Nguyen', N'0798051011', CAST(N'1998-07-25' AS Date), N'025788830', N'Test')
INSERT [dbo].[Owner] ([Id], [Name], [Phone], [DateOfBirth], [CMND], [Address]) VALUES (N'OW1111', N'a', N'1234567899', CAST(N'2019-03-19' AS Date), N'025788830', N'a')
INSERT [dbo].[Role] ([Role], [NameRole]) VALUES (N'SA', N'Administrator')
INSERT [dbo].[Role] ([Role], [NameRole]) VALUES (N'SU', N'User')
SET IDENTITY_INSERT [dbo].[Route] ON 

INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (1, N'Bến Xe An Sương')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (2, N'Bến Xe Miền Tây')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (3, N'Đầm Sen')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (4, N'Số Tiên')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (5, N'Nhà Thờ Đức Bà')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (6, N'Quân Khu 7')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (1011, N'Huy')
SET IDENTITY_INSERT [dbo].[Route] OFF
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0001', N'025788830', N'Nguyen Gia Huy', CAST(N'1998-07-25' AS Date), N'0798051011', N'SA')
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0002', N'025808639', N'Nguyễn Nguyệt Minh', CAST(N'1998-08-18' AS Date), N'0788008238', N'SA')
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0003', N'410170300', N'Nguyễn Thiện Chính', CAST(N'1997-05-24' AS Date), N'0932367717', N'SU')
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0004', N'55566623', N'ggghhh21312425', CAST(N'1997-05-24' AS Date), N'(555) 566-6622', N'SA')
ALTER TABLE [dbo].[Bus]  WITH CHECK ADD  CONSTRAINT [FK_Bus_Owner] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owner] ([Id])
GO
ALTER TABLE [dbo].[Bus] CHECK CONSTRAINT [FK_Bus_Owner]
GO
ALTER TABLE [dbo].[Bus]  WITH CHECK ADD  CONSTRAINT [FK_Bus_Route] FOREIGN KEY([IDTuyenDuong])
REFERENCES [dbo].[Route] ([Id])
GO
ALTER TABLE [dbo].[Bus] CHECK CONSTRAINT [FK_Bus_Route]
GO
ALTER TABLE [dbo].[BusStation]  WITH CHECK ADD  CONSTRAINT [FK_BusStation_Bus] FOREIGN KEY([BusID])
REFERENCES [dbo].[Bus] ([BusID])
GO
ALTER TABLE [dbo].[BusStation] CHECK CONSTRAINT [FK_BusStation_Bus]
GO
ALTER TABLE [dbo].[BusStation]  WITH CHECK ADD  CONSTRAINT [FK_BusStation_Staff] FOREIGN KEY([MSNVDRIVER])
REFERENCES [dbo].[Staff] ([MSNV])
GO
ALTER TABLE [dbo].[BusStation] CHECK CONSTRAINT [FK_BusStation_Staff]
GO
ALTER TABLE [dbo].[BusStation]  WITH CHECK ADD  CONSTRAINT [FK_BusStation_Staff1] FOREIGN KEY([MSNVCAST])
REFERENCES [dbo].[Staff] ([MSNV])
GO
ALTER TABLE [dbo].[BusStation] CHECK CONSTRAINT [FK_BusStation_Staff1]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role] ([Role])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Role]
GO
USE [master]
GO
ALTER DATABASE [BusManager] SET  READ_WRITE 
GO
