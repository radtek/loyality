/****** Object:  Table [prod].[BasketItems]    Script Date: 25.04.2013 9:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [prod].[BasketItems](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [nvarchar](64) NOT NULL,
	[ProductId] [nvarchar](64) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ProductsQuantity] [int] NOT NULL,
	[ProductPrice] [xml] NULL,	
 CONSTRAINT [PK_CartItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [prod].[BasketItems] ADD  CONSTRAINT [DF__CartItems__Creat__72C7A2F8]  DEFAULT (getdate()) FOR [CreatedDate]
GO