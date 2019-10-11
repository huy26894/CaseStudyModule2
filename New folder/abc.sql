USE [Cafe]
GO
SET IDENTITY_INSERT [dbo].[Areas] ON 

INSERT [dbo].[Areas] ([ID], [Name], [IsDelete]) VALUES (1, N'Tầng 1', 0)
INSERT [dbo].[Areas] ([ID], [Name], [IsDelete]) VALUES (2, N'Tầng 2', 0)
INSERT [dbo].[Areas] ([ID], [Name], [IsDelete]) VALUES (3, N'Tầng 3', 0)
SET IDENTITY_INSERT [dbo].[Areas] OFF
SET IDENTITY_INSERT [dbo].[TableCoffees] ON 

INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (1, 1, N'Bàn 1', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (2, 2, N'Bàn 1', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (3, 3, N'Bàn 1', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (4, 1, N'Bàn 2', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (5, 1, N'Bàn 3', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (6, 1, N'Bàn 4', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (7, 2, N'Bàn 2', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (8, 2, N'Bàn 3', 0)
INSERT [dbo].[TableCoffees] ([ID], [AreaID], [Name], [Status]) VALUES (9, 3, N'Bàn 2', 0)
SET IDENTITY_INSERT [dbo].[TableCoffees] OFF
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (1, 1, CAST(N'2019-10-08T16:05:50.217' AS DateTime), NULL, 0, 0)
INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (2, 2, CAST(N'2019-10-08T16:05:52.507' AS DateTime), NULL, 0, 0)
INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (3, 3, CAST(N'2019-10-08T16:05:54.180' AS DateTime), NULL, 0, 0)
INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (4, 4, CAST(N'2019-10-08T16:06:03.267' AS DateTime), NULL, 0, 0)
INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (5, 5, CAST(N'2019-10-08T16:06:04.493' AS DateTime), NULL, 0, 0)
INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (6, 6, CAST(N'2019-10-08T16:06:05.587' AS DateTime), NULL, 0, 0)
INSERT [dbo].[Bills] ([ID], [TableID], [DateTimeCheckIn], [DateTimeCheckOut], [Status], [IsDelete]) VALUES (7, 7, CAST(N'2019-10-08T16:06:07.517' AS DateTime), NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Bills] OFF
SET IDENTITY_INSERT [dbo].[ProductTypes] ON 

INSERT [dbo].[ProductTypes] ([ID], [Name], [IsDelete]) VALUES (1, N'Cafe', 0)
INSERT [dbo].[ProductTypes] ([ID], [Name], [IsDelete]) VALUES (2, N'Trà Sữa', 0)
INSERT [dbo].[ProductTypes] ([ID], [Name], [IsDelete]) VALUES (3, N'Nước Ngọt', 0)
INSERT [dbo].[ProductTypes] ([ID], [Name], [IsDelete]) VALUES (4, N'Sinh Tố', 0)
INSERT [dbo].[ProductTypes] ([ID], [Name], [IsDelete]) VALUES (5, N'Kẹo', 0)
INSERT [dbo].[ProductTypes] ([ID], [Name], [IsDelete]) VALUES (6, N'Hạt', 0)
SET IDENTITY_INSERT [dbo].[ProductTypes] OFF
SET IDENTITY_INSERT [dbo].[Units] ON 

INSERT [dbo].[Units] ([ID], [Name], [IsDelete]) VALUES (1, N'Ly', 0)
INSERT [dbo].[Units] ([ID], [Name], [IsDelete]) VALUES (2, N'Gói', 0)
SET IDENTITY_INSERT [dbo].[Units] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (1, 1, 1, N'Cafe Đen', CAST(7000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (2, 1, 1, N'Cafe Sữa', CAST(10000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (3, 2, 1, N'Trà sữa Socola', CAST(47000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (4, 2, 1, N'Trà sữa Matcha', CAST(47000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (5, 2, 1, N'Sữa Tươi Đường Đen ', CAST(47000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (6, 3, 1, N'Sinh tố Bơ', CAST(17500.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (7, 3, 1, N'Sinh tố Dưa hấu', CAST(17500.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (8, 4, 2, N'Kẹo cao su', CAST(7500.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (9, 4, 2, N'Kẹo oshi ổi', CAST(5000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (10, 5, 2, N'Hạt dưa', CAST(5000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Products] ([ID], [TypeID], [UnitID], [Name], [Price], [IsDelete]) VALUES (11, 5, 2, N'Hạt hướng dương ', CAST(5000.00 AS Decimal(10, 2)), 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (1, 1, 1, 2, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (2, 1, 2, 2, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (3, 2, 3, 2, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (4, 2, 4, 1, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (5, 2, 5, 1, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (6, 3, 1, 1, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (7, 3, 3, 1, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (8, 4, 1, 1, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (9, 4, 5, 5, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (10, 4, 3, 3, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (11, 4, 2, 2, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (12, 5, 1, 1, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[BillDetails] ([ID], [BillID], [ProductID], [Number], [Price], [Total]) VALUES (13, 5, 2, 2, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
