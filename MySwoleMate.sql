/****** Object:  Database [MySwoleMate]    Script Date: 3/18/2016 1:47:57 PM ******/
CREATE DATABASE [MySwoleMate]
GO
USE [MySwoleMate]
GO
/****** Object:  Table [dbo].[Trainee]    Script Date: 3/18/2016 1:47:57 PM ******/
CREATE TABLE [dbo].[Trainee](
	[TraineeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Height] [int] NOT NULL,
	[Weight] [int] NOT NULL,
	[CellNbr] [char](10) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_Trainee] PRIMARY KEY CLUSTERED 
(
	[TraineeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
