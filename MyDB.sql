USE [master]
GO
/****** Object:  Database [FinalDB_IP]    Script Date: 2/6/2020 7:40:42 PM ******/
CREATE DATABASE [FinalDB_IP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalDB_IP', FILENAME = N'/var/opt/mssql/data/FinalDB_IP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinalDB_IP_log', FILENAME = N'/var/opt/mssql/data/FinalDB_IP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FinalDB_IP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalDB_IP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinalDB_IP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinalDB_IP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinalDB_IP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinalDB_IP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinalDB_IP] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinalDB_IP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinalDB_IP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinalDB_IP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinalDB_IP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinalDB_IP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinalDB_IP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinalDB_IP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinalDB_IP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinalDB_IP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinalDB_IP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FinalDB_IP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinalDB_IP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinalDB_IP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinalDB_IP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinalDB_IP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinalDB_IP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinalDB_IP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinalDB_IP] SET RECOVERY FULL 
GO
ALTER DATABASE [FinalDB_IP] SET  MULTI_USER 
GO
ALTER DATABASE [FinalDB_IP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinalDB_IP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinalDB_IP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinalDB_IP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FinalDB_IP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FinalDB_IP', N'ON'
GO
ALTER DATABASE [FinalDB_IP] SET QUERY_STORE = OFF
GO
USE [FinalDB_IP]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2/6/2020 7:40:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2/6/2020 7:40:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[price] [decimal](18, 0) NULL,
	[categoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([id], [title]) VALUES (1, N'One')
GO
INSERT [dbo].[Categories] ([id], [title]) VALUES (2, N'Two')
GO
INSERT [dbo].[Categories] ([id], [title]) VALUES (3, N'Three')
GO
INSERT [dbo].[Categories] ([id], [title]) VALUES (4, N'Four')
GO
INSERT [dbo].[Categories] ([id], [title]) VALUES (5, N'Five')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (1, N'My Product', CAST(5 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (2, N'Not Your Product', CAST(61234 AS Decimal(18, 0)), 1)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (3, N'His Product', CAST(2412 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (4, N'Her Product', CAST(12 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (5, N'Our Product', CAST(23 AS Decimal(18, 0)), 4)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (6, N'Not Their Product', CAST(11123 AS Decimal(18, 0)), 3)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (7, N'Test Product', CAST(3941 AS Decimal(18, 0)), 2)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (8, N'Useful Product', CAST(295 AS Decimal(18, 0)), 4)
GO
INSERT [dbo].[Products] ([id], [title], [price], [categoryId]) VALUES (9, N'Ordinary Product', CAST(2951 AS Decimal(18, 0)), 4)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([categoryId])
REFERENCES [dbo].[Categories] ([id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [FinalDB_IP] SET  READ_WRITE 
GO
