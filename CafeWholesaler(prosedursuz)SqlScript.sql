USE [CafeWholesalerDb]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 24/07/2023 12:44:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [varchar](50) NULL,
	[AdminPassword] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 24/07/2023 12:44:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[CustomerAddress] [varchar](max) NULL,
	[CompanyName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 24/07/2023 12:44:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[ProductPrice] [money] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24/07/2023 12:44:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[IsFinished] [bit] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 24/07/2023 12:44:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[UnitsInStock] [int] NULL,
	[CategoryName] [varchar](50) NULL,
	[Price] [money] NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminID], [AdminName], [AdminPassword]) VALUES (1, N'Fatmanur', N'1111')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (1, N'lale', N'lalalalalalalalala', N'lale')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (2, N'lale', N'lalalalalalalalala', N'lale')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (3, N'Fatmanur', N'hayal kahvesi', N'hayal')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (4, N'Muhammet', N'Mecidiyeköy/Istanbul', N'minnosSoftware')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (5, N'Tarkan', N'Dünya', N'Kuzukuzultdsti')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (6, N'Fatmanur Yikilmaz', N'Istanbul', N'YKLMZ DESIGN')
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerAddress], [CompanyName]) VALUES (7, N'Aden Arven', N'Karaköy/Istanbul', N'OldTimes Cafe Shop')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (1, 2, 4, 6, NULL)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (2, 4, 7, 6, NULL)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (3, 5, 8, 5, 300.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (4, 2, 9, 6, 0.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (5, 4, 9, 5, 0.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (6, 5, 9, 3, 300.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (7, 4, 10, 5, 0.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (8, 5, 10, 5, 300.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (9, 5, 11, 5, 300.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (10, 2, 11, 2, 0.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (11, 7, 15, 4, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (12, 6, 15, 5, 50.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (13, 9, 16, 2, 40.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (14, 7, 16, 2, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (17, 7, 22, 5, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (18, 6, 22, 5, 50.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (19, 6, 25, 3, 50.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (20, 6, 27, 5, 50.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (21, 6, 29, 3, 50.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (22, 10, 29, 5, 30.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (24, 7, 30, 20, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (25, 9, 30, 20, 40.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (29, 7, 32, 50, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (30, 10, 32, 50, 30.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (31, 14, 33, 10, 40.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (32, 11, 33, 10, 100.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (34, 7, 33, 20, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (35, 6, 33, 50, 50.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (36, 13, 33, 1, 500.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (37, 15, 34, 100, 5.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (38, 7, 35, 3, 110.0000)
INSERT [dbo].[OrderDetails] ([OrderDetailsID], [ProductID], [OrderID], [Count], [ProductPrice]) VALUES (39, 6, 35, 2, 50.0000)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (1, 1, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (2, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (3, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (4, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (5, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (6, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (7, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (8, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (9, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (10, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (11, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (12, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (13, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (14, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (15, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (16, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (17, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (18, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (19, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (20, 4, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (21, 1, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (22, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (23, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (24, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (25, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (26, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (27, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (28, 2, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (29, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (30, 6, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (31, 5, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (32, 7, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (33, 7, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (34, 3, 0)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [IsFinished]) VALUES (35, 2, 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (2, N'm', 2, N'Tatlilar', NULL, 0)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (4, N'hghgh', 6, N'Tatlilar', NULL, 0)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (5, N'kahkah', 5, N'Kahveler', 300.0000, 0)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (6, N'Börek', 3, N'tuzlular', 50.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (7, N'Cheesecake', 2, N'Tatlilar', 110.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (8, N'ince belli çay', 2, N'Çaylar', 10.0000, 0)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (9, N'türk kahvesi', 1, N'Kahveler', 40.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (10, N'galeta', 2, N'tuzlular', 30.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (11, N'Demlik Poset Çay', 100, N'Çaylar', 100.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (12, N'kilo fistikli baklava', 1, N'Tatlilar', 400.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (13, N'kiloluk çekirdek kahve', 1, N'Kahveler', 500.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (14, N'tost çesitleri', 1, N'tuzlular', 40.0000, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [UnitsInStock], [CategoryName], [Price], [isActive]) VALUES (15, N'seker', 5, N'Tatlilar', 5.0000, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customer]
GO
