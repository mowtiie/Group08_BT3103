CREATE PROCEDURE sp_ProcessSaleTransaction
(
    @CustomerID INT,
    @ProcessedByUserID INT,
    @TotalAmount DECIMAL(10, 2),
    @SaleItems udt_SaleItemType READONLY
)
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (
        SELECT 1 
        FROM ProductVariants PV
        INNER JOIN @SaleItems SI ON PV.VariantID = SI.VariantID
        WHERE PV.StockQuantity < SI.Quantity
    )
    BEGIN
        RAISERROR('Sale failed: Insufficient stock for one or more items.', 16, 1);
        RETURN;
    END

    BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @NewSaleID INT;

        INSERT INTO Sales (CustomerID, ProcessedByUserID, TotalAmount)
        VALUES (@CustomerID, @ProcessedByUserID, @TotalAmount);
        
        SET @NewSaleID = SCOPE_IDENTITY();

        INSERT INTO SalesItems (SaleID, VariantID, Quantity, UnitPrice, Discount, SubTotal)
        SELECT 
            @NewSaleID, 
            VariantID, 
            Quantity, 
            UnitPrice, 
            Discount, 
            SubTotal
        FROM @SaleItems;

        DECLARE @VariantID INT;
        DECLARE @Quantity INT;

        DECLARE ItemCursor CURSOR LOCAL FORWARD_ONLY FOR 
        SELECT VariantID, Quantity FROM @SaleItems;
        
        OPEN ItemCursor;
        FETCH NEXT FROM ItemCursor INTO @VariantID, @Quantity;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            UPDATE ProductVariants
            SET StockQuantity = StockQuantity - @Quantity
            WHERE VariantID = @VariantID;
            
            INSERT INTO Inventory (VariantID, QuantityChange, Reason, ProcessedByUserID, TransactionReferenceID, Notes)
            VALUES (@VariantID, -@Quantity, 'Sale', @ProcessedByUserID, @NewSaleID, 'Customer sale transaction.');

            FETCH NEXT FROM ItemCursor INTO @VariantID, @Quantity;
        END

        CLOSE ItemCursor;
        DEALLOCATE ItemCursor;

        COMMIT TRANSACTION;
        
        SELECT @NewSaleID AS SaleID;

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END
GO