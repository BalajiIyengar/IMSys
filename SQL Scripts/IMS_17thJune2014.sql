USE [master]
GO
/****** Object:  Database [IMS]    Script Date: 17-06-2014 00:27:34 ******/
CREATE DATABASE [IMS] ON  PRIMARY 
( NAME = N'IMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLSERVEREXPRESS\MSSQL\DATA\IMS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLSERVEREXPRESS\MSSQL\DATA\IMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IMS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [IMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [IMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IMS] SET  MULTI_USER 
GO
ALTER DATABASE [IMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IMS] SET DB_CHAINING OFF 
GO
USE [IMS]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 17-06-2014 00:27:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [bigint] NOT NULL,
	[CategoryName] [varchar](100) NOT NULL,
	[isDiscontinued] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 17-06-2014 00:27:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[CustomerId] [bigint] NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[Address] [varchar](125) NULL,
	[Deposit] [bigint] NULL,
	[LastName] [varchar](50) NULL,
	[PhoneNumber] [varchar](12) NULL,
	[EmailId] [varchar](50) NULL,
	[Balance] [bigint] NULL,
 CONSTRAINT [PK_CustomerDetails] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DailyPurchase]    Script Date: 17-06-2014 00:27:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DailyPurchase](
	[CustomerId] [bigint] NOT NULL,
	[DateOfPurchase] [datetime] NOT NULL,
	[PurchaseAmount] [bigint] NOT NULL,
	[ItemsPurchased] [varchar](500) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 17-06-2014 00:27:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [bigint] NOT NULL,
	[CategoryId] [bigint] NOT NULL,
	[ProductName] [varchar](100) NOT NULL,
	[isDiscontinued] [bit] NOT NULL,
	[Quantity] [bigint] NOT NULL,
	[Product Details] [varchar](500) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [isDiscontinued]) VALUES (1, N'bags', 0)
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [isDiscontinued]) VALUES (2, N'footwear', 0)
INSERT [dbo].[CustomerDetails] ([CustomerId], [CustomerName], [Address], [Deposit], [LastName], [PhoneNumber], [EmailId], [Balance]) VALUES (1, N'Balaji', N'KoparKhairne', 1000, N'Iyengar', N'9769974346', N'devitsfangs@gmail.com', 0)
INSERT [dbo].[CustomerDetails] ([CustomerId], [CustomerName], [Address], [Deposit], [LastName], [PhoneNumber], [EmailId], [Balance]) VALUES (2, N'Rajesh', N'Ghatkopar', 0, N'Vishwa', N'', N'', 0)
INSERT [dbo].[CustomerDetails] ([CustomerId], [CustomerName], [Address], [Deposit], [LastName], [PhoneNumber], [EmailId], [Balance]) VALUES (3, N'Ashton', N'Thane', 0, N'Mendes', N'', N'', NULL)
INSERT [dbo].[CustomerDetails] ([CustomerId], [CustomerName], [Address], [Deposit], [LastName], [PhoneNumber], [EmailId], [Balance]) VALUES (4, N'Viral', N'Charni Road', 0, N'Mehta', N'', N'', 0)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [isDiscontinued], [Quantity], [Product Details]) VALUES (1, 1, N'liviya bags', 0, 0, NULL)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [isDiscontinued], [Quantity], [Product Details]) VALUES (1, 2, N'puma shoes', 0, 0, NULL)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [isDiscontinued], [Quantity], [Product Details]) VALUES (2, 1, N'nike bags', 0, 0, NULL)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [isDiscontinued], [Quantity], [Product Details]) VALUES (2, 2, N'adidas shoes', 0, 0, NULL)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [isDiscontinued], [Quantity], [Product Details]) VALUES (3, 1, N'wiki bags', 0, 12, N'lastProductId')
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [isDiscontinued], [Quantity], [Product Details]) VALUES (4, 1, N'wiki bags new', 0, 12, N'Wiki Bags New')
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_isDiscontinued]  DEFAULT ((0)) FOR [isDiscontinued]
GO
ALTER TABLE [dbo].[CustomerDetails] ADD  CONSTRAINT [DF_CustomerDetails_Balance]  DEFAULT ((0)) FOR [Balance]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_isDiscontinued]  DEFAULT ((0)) FOR [isDiscontinued]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Count]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[DailyPurchase]  WITH CHECK ADD  CONSTRAINT [FK_DailyPurchase_CustomerDetails] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CustomerDetails] ([CustomerId])
GO
ALTER TABLE [dbo].[DailyPurchase] CHECK CONSTRAINT [FK_DailyPurchase_CustomerDetails]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Categories]
GO
USE [master]
GO
ALTER DATABASE [IMS] SET  READ_WRITE 
GO
