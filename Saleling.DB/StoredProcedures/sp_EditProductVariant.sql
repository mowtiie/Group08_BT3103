CREATE PROCEDURE sp_EditProductVariant
    @VariantID INT,
    @ProductID INT,
    @SKU VARCHAR(100),
    @Size VARCHAR(20),
    @Color VARCHAR(50),
    @CostPrice DECIMAL(10, 2),
    @SellingPrice DECIMAL(10, 2),
    @ReorderLevel INT,
    @Status VARCHAR(20) = 'Active'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;

    BEGIN TRANSACTION;

    BEGIN TRY
        
        IF NOT EXISTS (SELECT 1 FROM ProductVariants WHERE VariantID = @VariantID)
        BEGIN
            RAISERROR('The target VariantID does not exist.', 16, 1);
        END

        IF NOT EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
        BEGIN
            RAISERROR('The parent ProductID does not exist.', 16, 1);
        END

        IF EXISTS (SELECT 1 FROM ProductVariants WHERE SKU = @SKU AND VariantID <> @VariantID)
        BEGIN
            RAISERROR('The provided SKU is already in use by another variant.', 16, 1);
        END

        IF @SellingPrice < @CostPrice
        BEGIN
            RAISERROR('Selling Price cannot be less than Cost Price. Selling at a loss is not permitted.', 16, 1);
        END

        UPDATE ProductVariants
        SET 
            ProductID = @ProductID,
            SKU = @SKU,
            Size = @Size,
            Color = @Color,
            CostPrice = @CostPrice,
            SellingPrice = @SellingPrice,
            ReorderLevel = @ReorderLevel,
            Status = @Status
        WHERE 
            VariantID = @VariantID;

        COMMIT TRANSACTION;

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(), 
            @ErrorSeverity = ERROR_SEVERITY(), 
            @ErrorState = ERROR_STATE();
            
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
        
    END CATCH
END
GO
