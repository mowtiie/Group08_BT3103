CREATE PROCEDURE sp_DeleteProductVariant
    @VariantID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
    DECLARE @CurrentStock INT;
    
    BEGIN TRANSACTION;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM ProductVariants WHERE VariantID = @VariantID)
        BEGIN
            RAISERROR('The VariantID does not exist.', 16, 1);
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
            RETURN;
        END

        SELECT @CurrentStock = StockQuantity
        FROM ProductVariants WITH (UPDLOCK, HOLDLOCK)
        WHERE VariantID = @VariantID;

        IF @CurrentStock > 0
        BEGIN
            RAISERROR('Cannot permanently delete VariantID %d. StockQuantity is %d. Stock must be zero before deletion.', 16, 1, @VariantID, @CurrentStock);
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
            RETURN;
        END

        IF EXISTS (SELECT 1 FROM SalesItems WHERE VariantID = @VariantID)
        BEGIN
            RAISERROR('Cannot permanently delete VariantID %d. It has existing sales records (history must be preserved). Use Soft Delete (Discontinue) instead.', 16, 1, @VariantID);
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION; 
            RETURN;
        END
        
        DELETE FROM Inventory
        WHERE VariantID = @VariantID;
        
        DELETE FROM ProductVariants
        WHERE VariantID = @VariantID;

        COMMIT TRANSACTION;
        
        SELECT 'Variant ' + CAST(@VariantID AS VARCHAR) + ' successfully and permanently deleted (Assumed typo/mistake as no sales records existed).' AS Message;

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT  
            @ErrorMessage = ERROR_MESSAGE(), 
            @ErrorSeverity = ERROR_SEVERITY(), 
            @ErrorState = ERROR_STATE();
            
        IF @ErrorSeverity = 0 SET @ErrorSeverity = 16;
            
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
        RETURN;
    END CATCH
END
GO