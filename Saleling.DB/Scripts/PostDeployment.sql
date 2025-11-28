USE SalelingDB;
GO

IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'sysadmin')
BEGIN
    INSERT INTO Users (FirstName, LastName, Username, HashedPassword, Role)
    VALUES
        ('System', 'Administrator', 'sysadmin', '$2b$12$dTdtrklBhYSePyoXahA4BektrlqLM4NAFKZ5MQLldnWQCxNI4NZCC', 'Admin'),
        ('John', 'Doe', 'johndoe', '$2b$12$bL9Tbg1Qn1xtwG89B2q50OC0bXZu3YDnpl/4xoCIXbegVZaY.tgKm', 'Cashier'),
        ('Jane', 'Doe', 'janedoe', '$2a$12$35od3fsRjnbXE9t.kDR3/.YpGKKGL9IY3N3CRLJyh2rfw1i.2I8A2', 'Cashier')
    PRINT 'Initial user data inserted successfully.';
END
ELSE
BEGIN
    PRINT 'User table already contains data. Skipping initial user data insertion.';
END

DECLARE @SystemAdminID INT = 1;

SET IDENTITY_INSERT Categories ON;
IF NOT EXISTS (SELECT 1 FROM Categories WHERE CategoryID = 5)
BEGIN
    DELETE FROM Categories; 
    
    INSERT INTO Categories (CategoryID, CategoryName, Description) VALUES
    (1, 'T-Shirts & Polos', 'Casual tops for everyday wear.'),
    (2, 'Denim & Jeans', 'All styles of essential denim wear.'),
    (3, 'Outerwear', 'Seasonal coats, jackets, and vests.');
    
    PRINT '3 Categories inserted successfully.';
END
SET IDENTITY_INSERT Categories OFF;
GO

SET IDENTITY_INSERT Suppliers ON;
IF NOT EXISTS (SELECT 1 FROM Suppliers WHERE SupplierID = 5)
BEGIN
    DELETE FROM Suppliers;
    
    INSERT INTO Suppliers (SupplierID, SupplierName, ContactName, Address, Phone) VALUES
    (1, 'Prime Textile Co.', 'Alex Johnson', '405 West St, LA', '555-1001'),
    (2, 'Global Apparel Corp', 'Brenda Lee', '19 Fashion Center, NY', '555-2002'),
    (3, 'Urban Footwear Ltd', 'Carlos Vega', '789 Shoe Ln, Miami', '555-3003'),
    (4, 'Accessory Hub', 'Diana King', '101 Bag Blvd, Chicago', '555-4004'),
    (5, 'Quality Basics Inc', 'Ethan Harris', '222 Plain Rd, Dallas', '555-5005');
    
    PRINT '5 Suppliers inserted successfully.';
END
SET IDENTITY_INSERT Suppliers OFF;
GO

DECLARE @WalkInCustomerID INT;
IF NOT EXISTS (SELECT 1 FROM Customers WHERE FirstName = 'Walk-In' AND LastName = 'Customer')
BEGIN
    INSERT INTO Customers (FirstName, LastName, Phone, Email, LoyaltyPoints)
    VALUES ('Walk-In', 'Customer', NULL, NULL, 0);
    SET @WalkInCustomerID = SCOPE_IDENTITY();
    PRINT 'Dedicated "Walk-In Customer" record inserted. ID: ' + CAST(@WalkInCustomerID AS VARCHAR);
END
ELSE
BEGIN
    SELECT @WalkInCustomerID = CustomerID FROM Customers WHERE FirstName = 'Walk-In' AND LastName = 'Customer';
    PRINT 'Dedicated "Walk-In Customer" record already exists. ID: ' + CAST(@WalkInCustomerID AS VARCHAR);
END
GO
DECLARE @WalkInCustomerID INT;
SELECT @WalkInCustomerID = CustomerID FROM Customers WHERE FirstName = 'Walk-In' AND LastName = 'Customer';

PRINT 'Seeding 100 Products, 500 Variants, and Initial Inventory...';

IF EXISTS (SELECT 1 FROM Products)
BEGIN
    PRINT 'Cleaning up existing product, variant, sales, and inventory data before re-seeding...';
    DELETE FROM SalesItems;
    DELETE FROM Inventory;
    DELETE FROM Sales;
    DELETE FROM ProductVariants;
    DELETE FROM Products;
END

DECLARE @Counter INT = 1;
DECLARE @MaxRecords INT = 100;
DECLARE @MinCategoryID INT = 1;
-- MaxCategoryID updated to 3
DECLARE @MaxCategoryID INT = 3; 
DECLARE @MinSupplierID INT = 1;
DECLARE @MaxSupplierID INT = 5;
DECLARE @AdminUserID INT = 1;
DECLARE @VariantsPerProduct INT = 5;

DECLARE @Sizes TABLE (SizeName VARCHAR(20));
INSERT INTO @Sizes (SizeName) VALUES 
('XS'), ('S'), ('M'), ('L'), ('XL'), ('XXL');

DECLARE @Colors TABLE (ColorName VARCHAR(50));
INSERT INTO @Colors (ColorName) VALUES 
('Red'), ('Green'), ('Blue'), ('Purple'), ('Pink'), ('Yellow'), 
('White'), ('Black'), ('Orange');

DECLARE @ProductNames TABLE (CategoryID INT, NameTemplate VARCHAR(100));
INSERT INTO @ProductNames (CategoryID, NameTemplate) VALUES
(1, 'Classic Crewneck Tee'), (1, 'Performance Polo'), (1, 'Vintage Graphic Tee'), (1, 'Soft Cotton V-Neck'),
(2, 'Slim Fit Stretch Denim'), (2, 'Dark Wash Skinny Jean'), (2, 'High-Rise Bootcut'), (2, 'Distressed Trucker Jean'),
(3, 'Lightweight Bomber Jacket'), (3, 'All-Weather Parka'), (3, 'Wool Blend Trench Coat'), (3, 'Padded Gilet Vest');

WHILE @Counter <= @MaxRecords
BEGIN
    DECLARE @RandomCategory INT = (SELECT FLOOR(RAND() * (@MaxCategoryID - @MinCategoryID + 1)) + @MinCategoryID);
    DECLARE @RandomSupplier INT = (SELECT FLOOR(RAND() * (@MaxSupplierID - @MinSupplierID + 1)) + @MinSupplierID);
    
    DECLARE @BaseCost DECIMAL(12, 4) = ROUND(RAND() * 25.00 + 15.00, 4); 
    DECLARE @BaseSellingPrice DECIMAL(12, 4) = ROUND(@BaseCost * 1.65, 4); 
    
    DECLARE @NameTemplate VARCHAR(100);
    SELECT TOP 1 @NameTemplate = NameTemplate 
    FROM @ProductNames 
    WHERE CategoryID = @RandomCategory 
    ORDER BY NEWID();
    
    DECLARE @NewProductName VARCHAR(100) = @NameTemplate + ' - P' + CAST(@Counter AS VARCHAR(3));
    DECLARE @NewProductID INT;

    INSERT INTO Products (ProductName, CategoryID, SupplierID, Status)
    VALUES (@NewProductName, @RandomCategory, @RandomSupplier, 'Active');
    
    SET @NewProductID = SCOPE_IDENTITY();

    
    DECLARE @VariantCombinations TABLE (SizeName VARCHAR(20), ColorName VARCHAR(50), Suffix CHAR(1));

    INSERT INTO @VariantCombinations (SizeName, ColorName, Suffix)
    SELECT TOP (@VariantsPerProduct) 
        s.SizeName, 
        c.ColorName, 
        CHAR(ASCII('A') + ROW_NUMBER() OVER (ORDER BY s.SizeName, c.ColorName) - 1) AS Suffix
    FROM @Sizes s
    CROSS JOIN @Colors c
    ORDER BY NEWID();

    
    DECLARE @CurrentSize VARCHAR(20);
    DECLARE @CurrentColor VARCHAR(50);
    DECLARE @CurrentSuffix CHAR(1);
    DECLARE @NewSKU VARCHAR(100);
    DECLARE @NewVariantID INT;

    DECLARE @VariantCost DECIMAL(12, 4);
    DECLARE @VariantSellingPrice DECIMAL(12, 4);

    DECLARE VariantCursor CURSOR FOR 
    SELECT SizeName, ColorName, Suffix FROM @VariantCombinations;
    
    OPEN VariantCursor;
    FETCH NEXT FROM VariantCursor INTO @CurrentSize, @CurrentColor, @CurrentSuffix;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @NewSKU = LEFT(REPLACE(@NameTemplate, ' ', ''), 4) + '-' + @CurrentSuffix + '-' + CAST(@NewProductID AS VARCHAR);

        SET @VariantCost = @BaseCost;
        SET @VariantSellingPrice = @BaseSellingPrice;

        IF @CurrentSize = 'XXL' OR @CurrentSize = 'XL'
        BEGIN
            SET @VariantCost = ROUND(@BaseCost * 1.10, 4);
            SET @VariantSellingPrice = ROUND(@BaseSellingPrice * 1.15, 4);
        END

        INSERT INTO ProductVariants (ProductID, SKU, Size, Color, CostPrice, SellingPrice, StockQuantity, ReorderLevel, Status)
        VALUES (@NewProductID, @NewSKU, @CurrentSize, @CurrentColor, @VariantCost, @VariantSellingPrice, 50, 5, 'Active');
        
        SET @NewVariantID = SCOPE_IDENTITY();
        
        INSERT INTO Inventory (VariantID, QuantityChange, Reason, ProcessedByUserID, Notes)
        VALUES (@NewVariantID, 50, 'Initial Receipt', @AdminUserID, 'Initial seed stock.');

        FETCH NEXT FROM VariantCursor INTO @CurrentSize, @CurrentColor, @CurrentSuffix;
    END

    CLOSE VariantCursor;
    DEALLOCATE VariantCursor;

    DELETE FROM @VariantCombinations;

    SET @Counter = @Counter + 1;
END

PRINT 'Successfully inserted ' + CAST(@MaxRecords AS VARCHAR) + ' products and ' + 
      CAST(@MaxRecords * @VariantsPerProduct AS VARCHAR) + ' associated variants/inventory records.';
GO