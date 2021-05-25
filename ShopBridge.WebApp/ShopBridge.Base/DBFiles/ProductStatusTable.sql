USE [ShopBridge]
GO

/****** Object:  Table [dbo].[ProductStatus]    Script Date: 25-05-2021 18:40:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProductStatus' and xtype='U')
BEGIN 

CREATE TABLE [dbo].[ProductStatus](
	[Id] [int] NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

GO

INSERT INTO ProductStatus(Id,Description)
Values
(1,'Instock'),
(2,'Sold'),
(3,'OutOfStock'),
(4,'Received')



