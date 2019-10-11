
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description:	Danh Sách Khu Vực
-- =============================================
CREATE PROCEDURE Areas_GetAll
AS	
BEGIN
	SELECT [ID]
      ,[Name]   
    FROM [dbo].[Areas]
	WHERE IsDelete = 0
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description:	Danh Sách Khu Vực Theo ID
-- =============================================
CREATE PROCEDURE Areas_GetByID
(
	@Id INT
)
AS	
BEGIN
	
	SELECT [ID]
      ,[Name]
    FROM [dbo].[Areas]
	WHERE ID = @Id AND IsDelete = 0
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Xóa Khu Vực
-- =============================================
CREATE PROCEDURE Areas_Delete
(
	@Id INT
)
AS	
BEGIN
	DECLARE @Soban INT
	SELECT @Soban = COUNT(ID) FROM dbo.TableCoffees
		WHERE AreaID =@Id

		IF(@Soban <=0) 
			UPDATE dbo.Areas SET IsDelete = 1 WHERE ID = @Id;
		ELSE 
			PRINT	'Bạn Phải Xóa các bàn trong Vùng trước'		
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Sửa Khu Vực
-- =============================================
CREATE PROCEDURE Areas_Update
(
	@Id INT,
	@Name NVARCHAR(100)	
)
AS	
BEGIN
	UPDATE dbo.Areas
	SET Name = @Name
	WHERE ID = @Id
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Tạo Khu Vực
-- =============================================
CREATE PROCEDURE Areas_Add
(	
	@Name NVARCHAR(100)	
)
AS	
BEGIN
	INSERT INTO dbo.Areas
	        ( Name ,
			  IsDelete)
	VALUES  ( @Name ,
			  0)		
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Danh Sách Bàn
-- =============================================
CREATE PROCEDURE TableCoffees_GetAll

AS	
BEGIN
	SELECT ID,
		   AreaID,
		   Name,
		   Status,
		   CASE 
				WHEN Status = 0 THEN 'Trống' 
				WHEN Status = 1 THEN 'Có Khách'
				WHEN Status = 2 THEN 'Đã Đặt'
		   END  
	FROM dbo.TableCoffees
END
GO

-- =============================================
-- Author:		NGÔ TÁ SINH
-- Create date: 07-10-2019
-- Description: ADD TABLE TABLECOFFEES ByID Area
-- =============================================
-- Chú Ý Cái Khi tạo bàn mới theo khu vực phải làm sao bắt được AreaID vì vậy cẩn thận dể sinh ra lỗi vì khi khởi tạo không có 
-- AreaID truyền vào trực tiếp.
CREATE PROC TableCoffees_AddByID
(
	@AreaID INT,
	@Name NVARCHAR(100)
)
AS	
BEGIN
	IF(NOT EXISTS(SELECT Name FROM dbo.TableCoffees WHERE AreaID = @AreaID AND Name LIKE @Name)) 
		BEGIN	
			INSERT INTO [dbo].[TableCoffees]			
					([Name])
			VALUES
					(@Name)
		END
	ELSE
		PRINT 'Bàn Này Đã Có Trong Khu Vực'
END	
GO	

-- =============================================
-- Author:		NGÔ TÁ SINH
-- Create date: 07-10-2019
-- Description: ADD TABLE TABLECOFFEES
-- =============================================
-- Giống như trên nhưng Cái này chúng ta phải tạo select option để chọn AreaID
CREATE PROC TableCoffees_Add
(
	@AreaID INT,
	@Name NVARCHAR(100)
)
AS	
BEGIN
	IF(NOT EXISTS(SELECT Name FROM dbo.TableCoffees WHERE AreaID = @AreaID AND Name LIKE @Name)) 
		BEGIN	
			INSERT INTO [dbo].[TableCoffees]			
					(Name,
					AreaID
					)
			VALUES
					(@Name,
					@AreaID
					)
		END
	ELSE
		PRINT 'Bàn Này Đã Có Trong Khu Vực'
END	
GO	

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Danh Sách Bàn Theo ID
-- =============================================
CREATE PROCEDURE TableCoffees_GetByID
(
	@Id INT
)
AS	
BEGIN	
	SELECT ID,
		   AreaID,
		   Name,
		   Status,
		   CASE 
				WHEN Status = 0 THEN 'Trống' 
				WHEN Status = 1 THEN 'Có Khách'
				WHEN Status = 2 THEN 'Đã Đặt'
		   END          
	FROM dbo.TableCoffees
	WHERE ID = @Id
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Xóa Bàn 
-- =============================================
CREATE PROCEDURE TableCoffees_Delete
(
	@Id INT
)
AS	
BEGIN	
	DELETE FROM dbo.TableCoffees
	WHERE ID = @Id
END
GO

-- =============================================
-- Author:		NGÔ TÁ SINH 
-- Create date: 07-10-2019
-- Description: Sửa Bàn 
-- =============================================
CREATE PROCEDURE TableCoffees_Update
(
	@Id INT,
	@AreaID INT,
	@Name NVARCHAR(100),
	@Status INT
)

AS	
BEGIN
	UPDATE dbo.TableCoffees
	SET AreaID = @AreaID,
		Name = @Name,
		Status = @Status
	WHERE ID = @Id AND NOT EXISTS(SELECT Name FROM dbo.TableCoffees WHERE AreaID = @AreaID AND Name LIKE @Name)
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Lấy Danh Sách Bàn Theo Khu Vực 
-- =============================================
CREATE PROCEDURE TableCoffees_GetByIdArea
(
	@Id INT	
)
AS	
BEGIN	
	SELECT ID,
	       AreaID,
		   Name,
		   Status,
		   CASE 
				WHEN Status = 0 THEN 'Trống' 
				WHEN Status = 1 THEN 'Có Khách'
				WHEN Status = 2 THEN 'Đã Đặt'
		   END
	FROM dbo.TableCoffees
	WHERE AreaID = @Id 
    	
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Lấy Danh Sách Bàn còn trống 
-- =============================================
CREATE PROCEDURE TableCoffees_GetEmptyTable

AS	
BEGIN
		
	SELECT ID,
	       AreaID,
		   Name,
		   Status,
				CASE 
					WHEN Status = 0 THEN 'Trống'
				END	  
	FROM dbo.TableCoffees
	WHERE Status = 0 
    	
END

GO
-- =============================================
-- Author:		NGÔ TÁ SINH 
-- Create date: 07-10-2019
-- Description: Đặt bàn 
-- =============================================
CREATE PROCEDURE TableCoffees_Tobook
(
	@Id INT
)

AS	
BEGIN
	UPDATE dbo.TableCoffees
	SET 
		Status = 2
	WHERE ID = @Id AND Status=0
END
GO
-- =============================================
-- Author:		NGÔ TÁ SINH 
-- Create date: 07-10-2019
-- Description: Hủy Đặt bàn
-- =============================================
CREATE PROCEDURE TableCoffees_ToCanBook
(
	@Id INT
)

AS	
BEGIN 
	UPDATE dbo.TableCoffees
	SET 
		Status = 0
	WHERE ID = @Id AND Status = 2
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Lấy Danh Sách Bàn có khách 
-- =============================================
CREATE PROCEDURE TableCoffees_GetNotEmptyTable

AS	
BEGIN
		
	SELECT ID,
	       AreaID,
		   Name,
		   Status,
				CASE 
					WHEN Status = 1 THEN 'Có Khách'
				END	    
	FROM dbo.TableCoffees
	WHERE Status = 1
    	
END
GO

-- =============================================
-- Author:		Huy Nguyễn 
-- Create date: 07-10-2019
-- Description: Lấy Danh Sách Bàn đã đặt 
-- =============================================
CREATE PROCEDURE TableCoffees_GetBookedATable

AS	
BEGIN
		
	SELECT ID,
	       AreaID,
		   Name,
		   Status,
				CASE 
					WHEN Status = 2 THEN 'Đã Đặt'
				END	    	  
	FROM dbo.TableCoffees
	WHERE Status = 2
END
GO

-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get All Unit>
-- =============================================
CREATE PROCEDURE dbo.Unit_GetAll
AS
BEGIN
	SELECT [ID],
			[NAME]
	FROM dbo.Units WHERE IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Unit By Id>
-- =============================================
CREATE PROCEDURE dbo.Unit_GetById
(
	@Id INT
)
AS
BEGIN
	SELECT [ID],
			[NAME]
	FROM dbo.Units 
	WHERE IsDelete = 0 and ID = @Id
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Unit Update,>
-- =============================================
CREATE PROCEDURE dbo.Unit_Update
(
	@Id INT,
	@Name NVARCHAR(100)
)
AS
BEGIN
	UPDATE Units SET Name = @Name
	WHERE ID = @Id and IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Delete Unit,>
-- =============================================
CREATE PROCEDURE dbo.Unit_Delete
(
	@Id INT
)
AS
BEGIN
	UPDATE Units SET IsDelete = 1
	WHERE ID = @Id and IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Add Unit,>
-- =============================================
CREATE PROCEDURE dbo.Unit_Add
(
	@Name nvarchar(100)
)
AS
BEGIN
	INSERT INTO dbo.Units(Name)
	VALUES (@Name)
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get All ProductTypes,>
-- =============================================
CREATE PROCEDURE dbo.ProductTypes_GetAll

AS
BEGIN
	SELECT [ID],
			[NAME]
	FROM dbo.ProductTypes 
	WHERE	 IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get ProductTypes By Id,>
-- =============================================
CREATE PROCEDURE dbo.ProductTypes_GetById
(
	@Id INT
)
AS
BEGIN
	SELECT [ID],
			[NAME]
	FROM dbo.ProductTypes 
	WHERE	 IsDelete = 0 and ID = @Id
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get ProductTypes Update,>
-- =============================================
CREATE PROCEDURE dbo.ProductTypes_Update
(
	@Id INT,
	@Name NVARCHAR(100)
)
AS
BEGIN
	UPDATE ProductTypes SET Name = @Name
	WHERE ID = @Id and IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get ProductTypes Unit,>
-- =============================================
CREATE PROCEDURE dbo.ProductTypes_Delete
(
	@Id INT
)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE ProductTypes SET IsDelete = 1
	WHERE ID = @Id and IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get ProductTypes Add,>
-- =============================================
CREATE PROCEDURE dbo.ProductTypes_Add
(
	@Name NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO dbo.ProductTypes(Name)
	VALUES (@Name)
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get All Bill,>
-- =============================================
CREATE PROCEDURE dbo.Bills_GetAll
AS
BEGIN
SELECT [ID]
      ,[TableID]
      ,[DateTimeCheckIn]
      ,[DateTimeCheckOut]
      ,[Status]
	  ,CASE 
			WHEN Status = 0 THEN 'Chưa Thanh Toán'
			WHEN Status = 1 THEN 'Đã Thanh Toán'
			WHEN Status = 2 THEN 'Bàn đã sửa Bill'
		END
  FROM [dbo].[Bills] WHERE IsDelete = 0
END
GO


-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Bill By Id,>
-- =============================================
CREATE PROCEDURE dbo.Bills_GetById
(
	@Id INT
)
AS
BEGIN
SELECT 
	   [TableID]
      ,[DateTimeCheckIn]
      ,[DateTimeCheckOut]
      ,[Status]
	  ,CASE 
			WHEN Status = 0 THEN 'Chưa Thanh Toán'
			WHEN Status = 1 THEN 'Đã Thanh Toán'
			WHEN Status = 2 THEN 'Bill đã sữa chữa'
		END
  FROM [dbo].[Bills] WHERE  ID = @Id and IsDelete = 0
END
GO
-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Delete Bill,>
-- =============================================
CREATE PROCEDURE dbo.Bills_Delete
(
	@Id int
)
AS
BEGIN
	UPDATE dbo.Bills SET IsDelete = 0
	WHERE ID = @Id AND IsDelete = 0 AND	Status = 1
END
GO

-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Update Bill,>
-- =============================================
CREATE PROCEDURE dbo.Bills_Update
(
	@Id INT,
	@tableId INT,
	@datetimeCheckIn DATETIME,
	@dateTimeCheckOut DATETIME,
	@Status INT
)
AS
BEGIN
	UPDATE dbo.Bills 
	SET TableID = @tableId,
		DateTimeCheckIn = @datetimeCheckIn,
		DateTimeCheckOut = @dateTimeCheckOut,
		Status = @Status	
	WHERE ID = @Id 
END

GO	

-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Bill By Status Đã thanh toán,>
-- =============================================
CREATE PROCEDURE dbo.Bills_IsPayment
(
	@Status INT
)
AS
BEGIN
	SELECT 
	   [TableID]
      ,[DateTimeCheckIn]
      ,[DateTimeCheckOut]
      ,[Status]
	  ,CASE 
			WHEN Status = 1 THEN 'Đã Thanh Toán'
		END
  FROM [dbo].[Bills] WHERE  Status = 1 and IsDelete = 0
END
GO
-- =============================================
-- Author:	NGÔ TÁ SINH
-- Create date: 07/10/2019
-- Description:	Get By ID BillDetails
-- =============================================
CREATE PROCEDURE BillDetails_AddBills
(
	@TAbleID INT
)
AS	
BEGIN	
	IF EXISTS(SELECT * FROM dbo.TableCoffees WHERE	ID=@TAbleID  AND Status=0)
		BEGIN
			INSERT INTO dbo.Bills
			        ( DateTimeCheckIn,
					TableID)
			VALUES  (GETDATE(),
					@TAbleID);
			UPDATE dbo.TableCoffees 
			SET Status =1;
		END	
	ELSE
		PRINT 'Bàn đã có khách'
END	
GO	



-- =============================================
-- Author:		<Hoang Bao>
-- Create date: 07-10-2019
-- Description:	<Get Bill By Status chưa thanh toán,>
-- =============================================
CREATE PROCEDURE dbo.Bills_IsNotPayment
(
	@Status INT
)
AS
BEGIN
SELECT 
	   [TableID]
      ,[DateTimeCheckIn]
      ,[DateTimeCheckOut]
      ,[Status]
	  ,CASE 
			WHEN Status = 0 Then 'Chưa Thanh Toán'
		END
  FROM [dbo].[Bills] WHERE  Status = 0 and IsDelete = 0
END
GO


-- =============================================
-- Author:		<Dang Phong>
-- Create date: <07/10/2019>
-- Description:	<Add Products>
-- =============================================
CREATE PROCEDURE [dbo].[Products_Add]
	@TypeID INT,
	@UnitID INT,
	@Price DECIMAL(10,2),
	@Name NVARCHAR(100)
AS	
BEGIN

INSERT INTO [dbo].[Products]
           ([TypeID]
           ,[UnitID]
           ,[Name]
		   ,[Price]
           ,[IsDelete])
     VALUES
           (@TypeID
           ,@UnitID
           ,@Name
		   ,@Price
           ,0)
END
GO	
-- =============================================
-- Author:		<Dang Phong>
-- Create date: <07/10/2019>
-- Description:	<Delete Products>
-- =============================================
CREATE PROCEDURE [dbo].[Products_Delete]
	@Id INT
AS	
BEGIN
UPDATE [dbo].[Products]
	SET	IsDelete = 1
WHERE ID = @Id
END

GO	
-- =============================================
-- Author:		<Dang Phong>
-- Create date: <07/10/2019>
-- Description:	<Get All Products>
-- =============================================
CREATE PROCEDURE [dbo].[Products_GetAll]

AS	
BEGIN
	SELECT [ID]
		,[TypeID]
		,[UnitID]
		,[Name]
		,[Price]
		,[IsDelete]
	FROM [dbo].[Products]
	WHERE IsDelete=0
END
GO	

-- =============================================
-- Author:		<Dang Phong>
-- Create date: <07/10/2019>
-- Description:	<Get Products By ID>
-- =============================================
CREATE PROCEDURE [dbo].[Products_GetByID]
(
	@Id INT
)
AS	
BEGIN
	SELECT [ID]
      ,[TypeID]
      ,[UnitID]
      ,[Name]
	  ,[Price]
      ,[IsDelete]
  FROM [dbo].[Products]

WHERE IsDelete=0 AND  ID = @Id
END
GO	
-- =============================================
-- Author:		<Dang Phong>
-- Create date: <07/10/2019>
-- Description:	<Update Products>
-- =============================================
CREATE PROCEDURE [dbo].[Products_Update]
(
	@Id INT,
	@TypeID INT,
	@UnitID INT,
	@Name NVARCHAR(100),
	@Price DECIMAL(10,2)
)
AS	
BEGIN
	UPDATE [dbo].[Products]
	SET	TypeID =@TypeID,
		UnitID =@UnitID,
		Name = @Name,
		Price = @Price
	WHERE ID = @Id
 END

 GO	
-- -- =============================================
---- Author:	NGÔ TÁ SINH
---- Create date: 07/10/2019
---- Description:	Get All BillDetails
---- =============================================
--CREATE PROCEDURE BillDetails_GetAll

--AS	
--BEGIN
--	SELECT [ID]
--		,[BillID]
--		,[ProductID]
--		,[Number]
--		,[Price]
--		,[Total]
--	FROM [dbo].[BillDetails]
-- END

 GO	

-- =============================================
-- Author:	NGÔ TÁ SINH
-- Create date: 07/10/2019
-- Description:	Get By ID BillDetails
-- =============================================
CREATE PROCEDURE BillDetails_GetByIDBills
(
	@ID int
)
AS	
BEGIN
	SELECT [ID]
		,[BillID]
		,[ProductID]
		,[Number]
		,[Price]
		,[Total]
	FROM [dbo].[BillDetails]
	WHERE	BillID=@ID
 END
 GO	
 -- =============================================
-- Author:	NGÔ TÁ SINH
-- Create date: 07/10/2019
-- Description:	Get By ID BillDetails
-- =============================================
CREATE PROCEDURE BillDetails_AddByIDBills
(
	@BillID INT,
	@ProductID INT,
	@Number INT
)
AS	
BEGIN
	DECLARE @Price DECIMAL(10,2);
	DECLARE @Total DECIMAL(10,2);
	SET @Price = (SELECT Price FROM dbo.Products WHERE	ID = @ProductID)
	SET @Total = @Number * @Price 

	INSERT INTO [dbo].[BillDetails]
           ([BillID]
           ,[ProductID]
           ,[Number]
           ,[Price]
           ,[Total])
     VALUES
           (@BillID
           ,@ProductID
           ,@Number
           ,@Price
           ,@Total)
 END
 GO	

  -- =============================================
-- Author:	NGÔ TÁ SINH
-- Create date: 07/10/2019
-- Description:Delete BillDetails
-- =============================================
CREATE PROCEDURE BillDetails_Delete
(
	@ID INT
)
AS	
BEGIN
	DELETE FROM dbo.BillDetails 
	WHERE ID=@ID
 END


