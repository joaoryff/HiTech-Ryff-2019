USE [master]
GO
/****** Object:  Database [HiTech]    Script Date: 2019-04-25 12:50:34 PM ******/
CREATE DATABASE [HiTech]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechEmployee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\HiTechEmployee.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechEmployee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\HiTechEmployee_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HiTech] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTech].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTech] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTech] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTech] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTech] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTech] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTech] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTech] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTech] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTech] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTech] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTech] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTech] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTech] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTech] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTech] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTech] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTech] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTech] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTech] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTech] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTech] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTech] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTech] SET RECOVERY FULL 
GO
ALTER DATABASE [HiTech] SET  MULTI_USER 
GO
ALTER DATABASE [HiTech] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTech] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTech] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTech] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTech] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HiTech', N'ON'
GO
ALTER DATABASE [HiTech] SET QUERY_STORE = OFF
GO
USE [HiTech]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](13) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[QoH] [int] NULL,
	[Year] [int] NULL,
	[PId] [int] NULL,
	[SId] [int] NULL,
	[AuthorId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[CId] [int] NOT NULL,
	[CName] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](10) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[FaxNumber] [nvarchar](15) NOT NULL,
	[Credit] [float] NOT NULL,
	[CEmail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Oid] [int] NOT NULL,
	[Cid] [int] NOT NULL,
	[ClientName] [nvarchar](50) NULL,
	[IssueDate] [date] NULL,
	[DueDate] [date] NULL,
	[ISBN] [nvarchar](13) NULL,
	[BookName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [float] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Invoice_1] PRIMARY KEY CLUSTERED 
(
	[Oid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OId] [int] NOT NULL,
	[OrderDate] [date] NULL,
	[ReqDate] [date] NULL,
	[ShipDate] [date] NULL,
	[CId] [int] NULL,
	[QoO] [int] NULL,
	[Total] [float] NULL,
	[ISBN] [nvarchar](13) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PId] [int] NOT NULL,
	[PName] [nvarchar](50) NOT NULL,
	[WebSite] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SId] [int] NOT NULL,
	[SName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2019-04-25 12:50:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[EmpId] [int] NOT NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (1, N'Joao', N'Ryff')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2, N'Jessica', N'Velasco')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (3, N'Cao', N'Quang Hoang')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (4, N'Leandro', N'Fortunato')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (5, N'Mauricio', N'Antao')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (6, N'Moyses', N'Lima')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (7, N'Wallacce', N'Correa')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (8, N'Juliana', N'Tamiazi')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (9, N'Luiz', N'Bezzerra')
INSERT [dbo].[Books] ([ISBN], [Title], [Price], [QoH], [Year], [PId], [SId], [AuthorId]) VALUES (N'100000000000', N'HTML Intermedieta', 99.56, 48, 1986, 2, 3, 9)
INSERT [dbo].[Books] ([ISBN], [Title], [Price], [QoH], [Year], [PId], [SId], [AuthorId]) VALUES (N'1000000000000', N'C adv', 20.55, 16, 2016, 3, 6, 8)
INSERT [dbo].[Books] ([ISBN], [Title], [Price], [QoH], [Year], [PId], [SId], [AuthorId]) VALUES (N'1000000000001', N'Sql for dummis', 50.33, 21, 1999, 2, 3, 4)
INSERT [dbo].[Books] ([ISBN], [Title], [Price], [QoH], [Year], [PId], [SId], [AuthorId]) VALUES (N'1000000000002', N'C# basic', 100.49, 27, 2019, 4, 6, 8)
INSERT [dbo].[Clients] ([CId], [CName], [Street], [City], [PostalCode], [Phone], [FaxNumber], [Credit], [CEmail]) VALUES (1, N'MCGILL UNIVERSITY', N'845 SHERBROOKE ST W, MONTREAL', N'MONTREAL', N'H3A 0G4', N'(111) 111-1111', N'(111) 111-1111', 100000, N'purchasing@mcgill.com')
INSERT [dbo].[Clients] ([CId], [CName], [Street], [City], [PostalCode], [Phone], [FaxNumber], [Credit], [CEmail]) VALUES (2, N'UNIVERSITE SHERBROOK', N'2500 BOULEVARD DE L''UNIVERSITÉ, SHERBROOKE', N'SHERBROOK', N'J1K 0A5', N'(819) 821-8000', N'(819) 821-8000', 75000, N'buy@sherbrook.com')
INSERT [dbo].[Clients] ([CId], [CName], [Street], [City], [PostalCode], [Phone], [FaxNumber], [Credit], [CEmail]) VALUES (3, N'CONCORDIA UNIVERSITY', N'1455 BOULEVARD DE MAISONNEUVE O', N'MONTREAL', N'H3G 1M8', N'(514) 848-2424', N'(514) 848-2424', 95008.8, N'achat@guiconcordia.com')
INSERT [dbo].[Clients] ([CId], [CName], [Street], [City], [PostalCode], [Phone], [FaxNumber], [Credit], [CEmail]) VALUES (4, N'COLLÈGE LASALLE', N'2000 SAINT-CATHERINE ST W', N'MONTREAL', N'A3A 555', N'(514) 939-2006', N'(514) 939-2006', 9994792.120000001, N'achats@lassale.com')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1111, N'Henry ', N'Brown', N'MIS Manager')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1112, N'Thomas', N'Moore', N'Sales Manager')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1113, N'Mary', N'Brown', N'Order Clerk')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1114, N'Jennifer', N'Bouchard', N'Order Clerk')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1115, N'Kim', N'Hoa Nguyen', N'Accountant')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1116, N'Peter', N'Wang', N'Inventory Controller')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1117, N'Joao', N'Ryff', N'Sales Manager')
INSERT [dbo].[Employees] ([EmpId], [FirstName], [LastName], [JobTitle]) VALUES (1118, N'Luiz', N'Mariano', N'Order Clerk')
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (1, 3, N'CONCORDIA UNIVERSITY', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'1000000000001', N'Sql for dummis', 25, 50.33, 1258.25)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (2, 3, N'CONCORDIA UNIVERSITY', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'1000000000001', N'Sql for dummis', 15, 50.33, 754.94999999999993)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (3, 3, N'CONCORDIA UNIVERSITY', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'1000000000001', N'Sql for dummis', 28, 50.33, 1409.24)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (4, 3, N'CONCORDIA UNIVERSITY', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'1000000000000', N'C adv', 4, 20.55, 82.2)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (5, 4, N'COLLÈGE LASALLE', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'1000000000002', N'C# basic', 32, 100.49, 3215.68)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (6, 4, N'COLLÈGE LASALLE', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'100000000000', N'HTML Intermedieta', 10, 99.56, 995.6)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (7, 4, N'COLLÈGE LASALLE', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'100000000000', N'HTML Intermedieta', 10, 99.56, 995.6)
INSERT [dbo].[Invoice] ([Oid], [Cid], [ClientName], [IssueDate], [DueDate], [ISBN], [BookName], [Quantity], [UnitPrice], [Total]) VALUES (8, 3, N'CONCORDIA UNIVERSITY', CAST(N'2019-04-25' AS Date), CAST(N'2019-05-25' AS Date), N'100000000000', N'HTML Intermedieta', 20, 99.56, 1991.2)
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (1, CAST(N'2019-04-14' AS Date), CAST(N'2019-04-15' AS Date), CAST(N'2019-04-14' AS Date), 3, 25, 1250, N'1000000000001')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (2, CAST(N'2019-04-14' AS Date), CAST(N'2019-04-17' AS Date), CAST(N'2019-04-16' AS Date), 3, 15, 750, N'1000000000001')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (3, CAST(N'2019-04-14' AS Date), CAST(N'2019-04-15' AS Date), CAST(N'2019-04-14' AS Date), 3, 28, 1400, N'1000000000001')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (4, CAST(N'2019-04-14' AS Date), CAST(N'2019-04-16' AS Date), CAST(N'2019-04-15' AS Date), 3, 4, 80, N'1000000000000')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (5, CAST(N'2019-04-14' AS Date), CAST(N'2019-04-30' AS Date), CAST(N'2019-04-29' AS Date), 4, 32, 3215.68, N'1000000000002')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (6, CAST(N'2019-04-18' AS Date), CAST(N'2019-04-19' AS Date), CAST(N'2019-04-18' AS Date), 4, 10, 995.6, N'100000000000')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (7, CAST(N'2019-04-18' AS Date), CAST(N'2019-04-19' AS Date), CAST(N'2019-04-18' AS Date), 4, 10, 995.6, N'100000000000')
INSERT [dbo].[Orders] ([OId], [OrderDate], [ReqDate], [ShipDate], [CId], [QoO], [Total], [ISBN]) VALUES (8, CAST(N'2019-04-18' AS Date), CAST(N'2019-04-19' AS Date), CAST(N'2019-04-18' AS Date), 3, 20, 1991.2, N'100000000000')
INSERT [dbo].[Publishers] ([PId], [PName], [WebSite]) VALUES (1, N'Rox', N'www.rox.com')
INSERT [dbo].[Publishers] ([PId], [PName], [WebSite]) VALUES (2, N'Mc Mullin Publishers', N'www.mcmullinpublishers.com')
INSERT [dbo].[Publishers] ([PId], [PName], [WebSite]) VALUES (3, N'MCGill', N'www.mqup.ca')
INSERT [dbo].[Publishers] ([PId], [PName], [WebSite]) VALUES (4, N'Dunamis Publishers', N'dunamispublishers.blogspot.com')
INSERT [dbo].[Publishers] ([PId], [PName], [WebSite]) VALUES (5, N'GPPutnams Sons', N'www.penguin.com/publishers/gpputnamssons/
')
INSERT [dbo].[Suppliers] ([SId], [SName]) VALUES (1, N'Murach')
INSERT [dbo].[Suppliers] ([SId], [SName]) VALUES (2, N'Premier Press')
INSERT [dbo].[Suppliers] ([SId], [SName]) VALUES (3, N'Wrox')
INSERT [dbo].[Suppliers] ([SId], [SName]) VALUES (4, N'Prentice Hall')
INSERT [dbo].[Suppliers] ([SId], [SName]) VALUES (5, N'Cultura')
INSERT [dbo].[Suppliers] ([SId], [SName]) VALUES (6, N'Ediouro')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1111, N'1111')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1112, N'1112')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1113, N'1113')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1114, N'1114')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1115, N'1115')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1116, N'1116')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1117, N'1117')
INSERT [dbo].[Users] ([EmpId], [Password]) VALUES (1118, N'1118')
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([CId])
REFERENCES [dbo].[Clients] ([CId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employees] ([EmpId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [HiTech] SET  READ_WRITE 
GO
