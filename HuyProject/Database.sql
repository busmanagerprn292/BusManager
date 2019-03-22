
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
/****** Object:  UserDefinedFunction [dbo].[StaffID]    Script Date: 3/10/2019 10:01:50 AM ******/
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
/****** Object:  Table [dbo].[Bus]    Script Date: 3/10/2019 10:01:50 AM ******/
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
/****** Object:  Table [dbo].[BusStation]    Script Date: 3/10/2019 10:01:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusStation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BusID] [varchar](6) NULL,
	[MSNVDRIVER] [varchar](6) NULL,
	[DepartureTime] [date] NULL,
	[TimeBack] [date] NULL,
	[MSNVCAST] [varchar](6) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_BusStation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owner]    Script Date: 3/10/2019 10:01:50 AM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 3/10/2019 10:01:50 AM ******/
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
/****** Object:  Table [dbo].[Route]    Script Date: 3/10/2019 10:01:50 AM ******/
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
/****** Object:  Table [dbo].[Staff]    Script Date: 3/10/2019 10:01:50 AM ******/
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
INSERT [dbo].[Bus] ([BusID], [BSX], [Brand], [DateRegistration], [OwnerId], [IDTuyenDuong]) VALUES (N'BU0001', N'49D-4567', N'Honda', CAST(N'2019-03-10' AS Date), N'OW0001', 1)
INSERT [dbo].[Owner] ([Id], [Name], [Phone], [DateOfBirth], [CMND], [Address]) VALUES (N'OW0001', N'Nguyễn Văn Cường', N'0908200399', CAST(N'1970-09-27' AS Date), N'159753654', N'900 Tạ Quang Bửu')
INSERT [dbo].[Owner] ([Id], [Name], [Phone], [DateOfBirth], [CMND], [Address]) VALUES (N'OW0002', N'Lê Thị Ngọc Sương', N'0908533299', CAST(N'1971-10-27' AS Date), N'127894567', N'34 Trần Hưng Đạo')
INSERT [dbo].[Role] ([Role], [NameRole]) VALUES (N'SA', N'Administrator')
INSERT [dbo].[Role] ([Role], [NameRole]) VALUES (N'SU', N'User')
SET IDENTITY_INSERT [dbo].[Route] ON 

INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (1, N'Bến Xe An Sương')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (2, N'Bến Xe Miền Tây')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (3, N'Đầm Sen')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (4, N'Số Tiên')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (5, N'Nhà Thờ Đức Bà')
INSERT [dbo].[Route] ([Id], [TuyenDuong]) VALUES (6, N'Quân Khu 7')
SET IDENTITY_INSERT [dbo].[Route] OFF
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0001', N'025788830', N'Nguyen Gia Huy', CAST(N'1998-07-25' AS Date), N'0798051011', N'SA')
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0002', N'025808639', N'Nguyễn Nguyệt Minh', CAST(N'1998-08-18' AS Date), N'0788008238', N'SA')
INSERT [dbo].[Staff] ([MSNV], [CMND], [Name], [DateOfBirth], [Phone], [Role]) VALUES (N'ST0003', N'410170300', N'Nguyễn Thiện Chính', CAST(N'1997-05-24' AS Date), N'0932367717', N'SU')
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
