CREATE PROCEDURE DeleteProductVariant
    @VariantID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRANSACTION;

    IF EXISTS (SELECT 1 FROM SalesItems WHERE VariantID = @VariantID)
    BEGIN
        ROLLBACK TRANSACTION; 

        RAISERROR('Deletion Failed: This product variant has historical sales records and cannot be deleted.', 16, 1);
    END
    
    DELETE FROM Inventory
    WHERE VariantID = @VariantID;
    
    DELETE FROM ProductVariants
    WHERE VariantID = @VariantID;
    
    IF @@ROWCOUNT = 0
    BEGIN
        ROLLBACK TRANSACTION; 
        RAISERROR('The specified VariantID was not found. Deletion failed.', 16, 1);
        RETURN;
    END

    COMMIT TRANSACTION;

END
GO
