```SQL
use master;
DROP DATABASE BD1;
CREATE DATABASE [BD1] ON PRIMARY
	( 
	NAME = N'BD1', 
	FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BD1.mdf' , 
	SIZE = 8192KB , 
	FILEGROWTH = 65536KB 
	)
 LOG ON 
	( 
	NAME = N'BD1_log', 
	FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BD1_log.ldf' , 
	SIZE = 8192KB , 
	FILEGROWTH = 65536KB 
	)
GO

select * from sys.sysdatabases

use AdventureWorks2017
go
select * from Person.Person; select * from Production.Product
select * from Person.Person for XML Auto

select * from Person.AddressType
```

```SQL
USE [RPI_DEV] => se connecte au server SQL
GO

/****** Object:  Table [dbo].[Table_1]    Script Date: 06/03/2023 11:50:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Libellé] [nchar](50) NULL,
	[Villz] [bigint] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
```