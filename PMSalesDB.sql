USE [PMSalesDB]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6/2/2025 10:35:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](500) NOT NULL,
	[SName] [varchar](500) NULL,
	[LName] [varchar](500) NULL,
	[Phone1] [varchar](50) NOT NULL,
	[Phone2] [varchar](50) NULL,
	[Phone3] [varchar](50) NULL,
	[Email1] [varchar](100) NULL,
	[Email2] [varchar](100) NULL,
	[Address] [varchar](100) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[product1] [varchar](100) NULL,
	[qty1] [int] NULL,
	[product2] [varchar](100) NULL,
	[qty2] [int] NULL,
	[product3] [varchar](100) NULL,
	[qty3] [int] NULL,
	[product4] [varchar](100) NULL,
	[qty4] [int] NULL,
	[product5] [varchar](100) NULL,
	[qty5] [int] NULL,
	[product6] [varchar](100) NULL,
	[qty6] [int] NULL,
	[product7] [varchar](100) NULL,
	[qty7] [int] NULL,
	[product8] [varchar](50) NULL,
	[qty8] [int] NULL,
	[TotalAmount] [money] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](500) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[Category] [varchar](100) NULL,
	[Company] [varchar](100) NULL,
	[Size] [varchar](50) NULL,
	[OtherInfo] [varchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[ProductCost] [varchar](50) NULL,
	[ForwarderCost] [varchar](50) NULL,
	[CourierCustomer] [varchar](50) NULL,
	[CostCreatedDate] [varchar](50) NULL,
	[CostUpdatedDate] [varchar](50) NULL,
 CONSTRAINT [PK__Products__B40CC6ED9540AE01] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SaleDetailID] [int] NOT NULL,
	[TotalAmount] [decimal](10, 2) NOT NULL,
	[SaleDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Sales__1EE3C41F575B6C32] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDetails]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetails](
	[SaleDetailID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[SecondName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Serial Number] [varchar](100) NULL,
	[Address] [varchar](500) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[Contact No 1] [varchar](50) NOT NULL,
	[Contact No 2] [varchar](50) NULL,
	[Contact No 3] [varchar](50) NULL,
	[Email 1] [varchar](100) NULL,
	[Email 2] [varchar](100) NULL,
	[Item 1] [varchar](100) NULL,
	[Qty 1] [nchar](10) NULL,
	[Item 2] [varchar](100) NULL,
	[Qty 2] [nchar](10) NULL,
	[Item 3] [varchar](100) NULL,
	[Qty 3] [nchar](10) NULL,
	[Item 4] [varchar](100) NULL,
	[Qty 4] [nchar](10) NULL,
	[Item 5] [varchar](100) NULL,
	[Qty 5] [nchar](10) NULL,
	[Item 6] [varchar](100) NULL,
	[Qty 6] [nchar](10) NULL,
	[Item 7] [varchar](100) NULL,
	[Qty 7] [nchar](10) NULL,
	[Item 8] [varchar](100) NULL,
	[Qty 8] [nchar](10) NULL,
	[Total Price] [decimal](10, 2) NOT NULL,
	[Warranty DueDate] [varchar](100) NULL,
	[Warranty Claims] [varchar](50) NULL,
	[Product Status] [int] NULL,
	[Product Warranty Status] [int] NULL,
	[Confirm Orders] [int] NULL,
	[Returned Orders] [int] NULL,
	[Created Date] [datetime] NOT NULL,
	[Updated Date] [datetime] NULL,
 CONSTRAINT [PK__SalesDet__70DB141E661E6AB8] PRIMARY KEY CLUSTERED 
(
	[SaleDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status_ConfirmProduct]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status_ConfirmProduct](
	[id] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ProductStatus] [varchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Status_ConfirmProduct] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status_Warranty]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status_Warranty](
	[id] [int] NOT NULL,
	[WarrantyClaimId] [int] NOT NULL,
	[WarrantyStatus] [varchar](50) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_Status_Warranty] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF__Customers__Creat__173876EA]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF__Products__Create__145C0A3F]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF__Sales__SaleDate__1B0907CE]  DEFAULT (getdate()) FOR [SaleDate]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Role]='Manager' OR [Role]='Sales' OR [Role]='Admin'))
GO
/****** Object:  StoredProcedure [dbo].[GET_ALL_CONFIRMED_SALES_REPORTS]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get Sales Reports in the SalesDetails table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   18/05/2025  Created  
***********************************************************************
*/

CREATE PROCEDURE [dbo].[GET_ALL_CONFIRMED_SALES_REPORTS]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        --SELECT 
        --    SaleDetailID,
        --    FirstName,
        --    SecondName,
        --    LastName,
        --    Address,
        --    City,
        --    [Contact No 1],
        --    [Contact No 2],
        --    [Contact No 3],
        --    [Email 1],
        --    [Email 2],
        --    [Item 1],
        --    [Qty 1],
        --    [Item 2],
        --    [Qty 2],
        --    [Item 3],
        --    [Qty 3],
        --    [Item 4],
        --    [Qty 4],
        --    [Item 5],
        --    [Qty 5],
        --    [Item 6],
        --    [Qty 6],
        --    [Item 7],
        --    [Qty 7],
        --    [Item 8],
        --    [Qty 8],
        --    [Total Price],
        --    [Warranty DueDate],
        --    [Warranty Claims],
        --    [Product Status],
        --    [Product Warranty Status],
        --    [Confirm Orders],
        --    [Returned Orders],
        --    [Created Date],
        --    [Updated Date]
        --FROM SalesDetails WITH (NOLOCK) Order by [Created Date] desc;

		SELECT 
            SaleDetailID,
            FirstName,
            SecondName,
            LastName,
            Address,
            City,
            [Contact No 1],
            [Contact No 2],
            [Contact No 3],
            [Email 1],
            [Email 2],
            [Item 1],
            [Qty 1],
            [Item 2],
            [Qty 2],
            [Item 3],
            [Qty 3],
            [Item 4],
            [Qty 4],
            [Item 5],
            [Qty 5],
            [Item 6],
            [Qty 6],
            [Item 7],
            [Qty 7],
            [Item 8],
            [Qty 8],
            [Total Price],
            [Warranty DueDate],
            [Warranty Claims],
            CASE [Product Status]
				WHEN 1 THEN 'Confirmed'
				WHEN 2 THEN 'Pending'
				WHEN 3 THEN 'Rejected'
				ELSE ''
			END AS [Product Status],
			CASE [Product Warranty Status]
				WHEN 1 THEN 'Warranty not claimed'
				WHEN 2 THEN 'First warranty claim'
				WHEN 3 THEN 'Second warranty claim'
				WHEN 4 THEN 'Third warranty claim'
				ELSE ''
			END AS [Product Warranty Status],
            [Confirm Orders],
            [Returned Orders],
            [Created Date],
            [Updated Date]
        FROM SalesDetails WITH (NOLOCK) Order by [Created Date] desc;
    END TRY
    BEGIN CATCH
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[GET_AVAILABLE_ALL_PRODUCT_NAMES]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get the name of products in the Product table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   19/04/2025  Created  
***********************************************************************
*/

Create PROCEDURE [dbo].[GET_AVAILABLE_ALL_PRODUCT_NAMES]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Simply return the name of products
        SELECT ProductName FROM Products WITH(NOLOCK);
    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GET_NUMBER_OF_CUSTOMERS]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get the number of customers in the Customers table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   18/04/2025  Created  
***********************************************************************
*/

CREATE PROCEDURE [dbo].[GET_NUMBER_OF_CUSTOMERS]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Simply return the count of customers
        SELECT COUNT(*) AS TotalCustomers FROM Customers WITH(NOLOCK);
    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GET_NUMBER_OF_PRODUCTS]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get the number of items in the Products table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   20/04/2025  Created  
***********************************************************************
*/

Create PROCEDURE [dbo].[GET_NUMBER_OF_PRODUCTS]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Simply return the count of products
        SELECT COUNT(*) AS ProductName FROM Products WITH(NOLOCK);
    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GET_NUMBER_OF_RETURN_PRODUCTS]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get the number of ReturnedProducts in the SalesDetails table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   20/05/2025  Created  
***********************************************************************
*/

cREATE PROCEDURE [dbo].[GET_NUMBER_OF_RETURN_PRODUCTS]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Simply return the count of ReturnProducts
        SELECT COUNT(*) AS ReturnProducts from SalesDetails WITH(NOLOCK) where [Returned Orders] = 1 ;
    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GET_NUMBER_OF_SALES]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get the number of Sales in the SalesDetails table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   18/05/2025  Created  
***********************************************************************
*/

CREATE PROCEDURE [dbo].[GET_NUMBER_OF_SALES]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Simply return the count of customers
        SELECT COUNT(*) AS TotalSales FROM SalesDetails WITH(NOLOCK) Where [Confirm Orders] = 1;
    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GET_PROFIT_OF_PRODUCTS]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
*********************************************************************************************
Purpose/Comments:   Retrieve the profit values for products from the Products table
*********************************************************************************************
Version History
**************************
Ver 1.0  Nadun   26/05/2025  Created  
*********************************************************************************************
*/

CREATE PROCEDURE [dbo].[GET_PROFIT_OF_PRODUCTS]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT 
			ProductName, 
			(Price - ProductCost - ForwarderCost - CourierCustomer) AS Profit
		FROM 
			Products WITH (NOLOCK);

    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[PM_INSERT_CONFIRMED_SALES]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan
Copyright:          KeeleSoft Limited
*****************************************************************************
Purpose/Comments:   Insert Confirmed sales record into SalesDetails table
*****************************************************************************
Version History
**************************
Ver 1.0  Nadun   18/05/2025  Created
*****************************************************************************
*/

CREATE PROCEDURE [dbo].[PM_INSERT_CONFIRMED_SALES]
    @fname           VARCHAR(50),
    @sname           VARCHAR(50) = NULL,
    @lname           VARCHAR(50) = NULL,
    @address         VARCHAR(500),
    @city            VARCHAR(100),
    @phone1          VARCHAR(50),
    @phone2          VARCHAR(50) = NULL,
    @phone3          VARCHAR(50) = NULL,
    @email1          VARCHAR(100) = NULL,
    @email2          VARCHAR(100) = NULL,
    @item1           VARCHAR(100) = NULL,
    @qty1            NCHAR(10) = NULL,
    @item2           VARCHAR(100) = NULL,
    @qty2            NCHAR(10) = NULL,
    @item3           VARCHAR(100) = NULL,
    @qty3            NCHAR(10) = NULL,
    @item4           VARCHAR(100) = NULL,
    @qty4            NCHAR(10) = NULL,
    @item5           VARCHAR(100) = NULL,
    @qty5            NCHAR(10) = NULL,
    @item6           VARCHAR(100) = NULL,
    @qty6            NCHAR(10) = NULL,
	@item7           VARCHAR(100) = NULL,
    @qty7            NCHAR(10) = NULL,
	@item8           VARCHAR(100) = NULL,
    @qty8            NCHAR(10) = NULL,
    @totalprice      DECIMAL(10,2),
    @warrantyduedate VARCHAR(100),
    @warrantyclaims  VARCHAR(50) = NULL,
    @prodstatus      INT,
    @prodwarrantystatus INT = NULL,
    @confirmorders   INT,
    @returnedorders  INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRANSACTION;

    BEGIN TRY

    INSERT INTO SalesDetails(
        FirstName, SecondName, LastName, Address, City,
        [Contact No 1], [Contact No 2], [Contact No 3],
        [Email 1], [Email 2],
        [Item 1], [Qty 1], [Item 2], [Qty 2],
        [Item 3], [Qty 3], [Item 4], [Qty 4],
        [Item 5], [Qty 5], [Item 6], [Qty 6],
		[Item 7], [Qty 7],[Item 8], [Qty 8],
        [Total Price], [Warranty DueDate], [Warranty Claims],
        [Product Status], [Product Warranty Status],
        [Confirm Orders], [Returned Orders], [Created Date]
    )
    VALUES (
        @fname, @sname, @lname, @address, @city,
        @phone1, @phone2, @phone3,
        @email1, @email2,
        @item1, @qty1, @item2, @qty2,
        @item3, @qty3, @item4, @qty4,
        @item5, @qty5, @item6, @qty6,
		@item7, @qty7,@item8, @qty8,
        @totalprice, @warrantyduedate, @warrantyclaims,
        @prodstatus, @prodwarrantystatus,
        @confirmorders, @returnedorders, GETDATE()
    );

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[PM_INSERT_CUSTOMER]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan
Copyright:          KeeleSoft Limited
***********************************************************************
Purpose/Comments:   Insert Customer record into Customers table
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   07/04/2025  Created
***********************************************************************
*/

CREATE PROCEDURE [dbo].[PM_INSERT_CUSTOMER]
    @fname           VARCHAR(500),
	@sname           VARCHAR(500) = NULL,
	@lname           VARCHAR(500) = NULL,
    @phone1         VARCHAR(50) = NULL,
    @phone2         VARCHAR(50) = NULL,
    @phone3         VARCHAR(50) = NULL,
    @email1         VARCHAR(100) = NULL,
    @email2         VARCHAR(100) = NULL,
    @address        VARCHAR(100),
    @city           VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Customers  
        (
            FName, 
			SName,
			LName,
            Phone1, 
            Phone2,
            Phone3,
            Email1,
            Email2,
            Address,
            City,
            CreatedDate
        )
        VALUES 
        (
            @fname, 
			@sname,
			@lname,
            @phone1,
            @phone2,
            @phone3,
            @email1,
            @email2,
            @address,
            @city,
			GETDATE()
        );

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[PM_INSERT_FULL_PRODUCT_ENTRY]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan
Copyright:          KeeleSoft Limited
***********************************************************************
Purpose/Comments:   Insert fullproduct record into Product table
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   05/05/2025  Created
***********************************************************************
*/

CREATE PROCEDURE [dbo].[PM_INSERT_FULL_PRODUCT_ENTRY]
    @product1 VARCHAR(100),
    @qty1 INT,
    @product2 VARCHAR(100),
    @qty2 INT,
    @product3 VARCHAR(100),
    @qty3 INT,
    @product4 VARCHAR(100),
    @qty4 INT,
    @product5 VARCHAR(100),
    @qty5 INT,
    @product6 VARCHAR(100),
    @qty6 INT,
    @product7 VARCHAR(100),
    @qty7 INT,
    @product8 VARCHAR(100),
    @qty8 INT,
    @TotalAmount VARCHAR(50)
AS
BEGIN
    SET NOCOUNT OFF;
	BEGIN TRANSACTION;

    BEGIN TRY

    INSERT INTO [PMSalesDB].[dbo].[Product] (
        [product1], [qty1],
        [product2], [qty2],
        [product3], [qty3],
        [product4], [qty4],
        [product5], [qty5],
        [product6], [qty6],
        [product7], [qty7],
        [product8], [qty8],
        [TotalAmount], [CreatedDate]
    )
    VALUES (
        @product1, @qty1,
        @product2, @qty2,
        @product3, @qty3,
        @product4, @qty4,
        @product5, @qty5,
        @product6, @qty6,
        @product7, @qty7,
        @product8, @qty8,
        @TotalAmount, GETDATE()
    );

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[PM_INSERT_PRODUCT]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan
Copyright:          KeeleSoft Limited
***********************************************************************
Purpose/Comments:   Insert Product record into Products table
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   30/04/2025  Created
***********************************************************************
*/

CREATE PROCEDURE [dbo].[PM_INSERT_PRODUCT]
    @ProductName NVARCHAR(500),
    @Category NVARCHAR(100),
    @Stock INT,
    @Price DECIMAL(18, 2),
    @Company NVARCHAR(100),
    @Size NVARCHAR(50),
    @OtherInfo NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
    INSERT INTO Products (ProductName, Category, Stock, Price, Company, Size, OtherInfo)
    VALUES (@ProductName, @Category, @Stock, @Price, @Company, @Size, @OtherInfo);
COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END;

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_PRODUCT_NAMES_AND_PRICES]    Script Date: 6/2/2025 10:35:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
Created By:         Nadun Tilan  
Copyright:          KeeleSoft Limited  
***********************************************************************
Purpose/Comments:   Get name of products & price in the Product table  
***********************************************************************
Version History
**************************
Ver 1.0  Nadun   19/04/2025  Created  
***********************************************************************
*/

Create PROCEDURE [dbo].[SELECT_ALL_PRODUCT_NAMES_AND_PRICES]
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Simply return the name of products
        SELECT ProductName,Price FROM Products WITH(NOLOCK);
    END TRY
    BEGIN CATCH
        -- Log error details
        INSERT INTO ErrorLog 
        (
            ErrorMessage, 
            ErrorProcedure, 
            ErrorSeverity, 
            ErrorState, 
            ErrorLine, 
            ApplicationName,
            ErrorDateTime
        )
        VALUES 
        (
            ERROR_MESSAGE(), 
            ERROR_PROCEDURE(), 
            ERROR_SEVERITY(), 
            ERROR_STATE(), 
            ERROR_LINE(), 
            APP_NAME(),
            GETDATE()
        );
    END CATCH
END
GO
