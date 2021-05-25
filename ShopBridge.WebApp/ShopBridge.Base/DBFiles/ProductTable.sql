USE [ShopBridge]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 25-05-2021 18:39:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Product' and xtype='U')
BEGIN 

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Quantity] [int] NOT NULL,
	[BaseUnit] [int] NOT NULL,
	[MRPRate] [decimal](18, 0) NOT NULL,
	[SellingPrice] [decimal](18, 0) NOT NULL,
	[LastModifiedTime] [datetime] NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
	[ProductStatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

END
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_BaseUnit] FOREIGN KEY([BaseUnit])
REFERENCES [dbo].[MeasurementUnit] ([Id])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_BaseUnit]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_ProductStatus] FOREIGN KEY([ProductStatus])
REFERENCES [dbo].[ProductStatus] ([Id])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_ProductStatus]
GO


