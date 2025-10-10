CREATE PROCEDURE DeleteProduct
    @ProductID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SoldVariantCount INT;
    
    BEGIN TRANSACTION;

    SELECT @SoldVariantCount = COUNT(T1.VariantID)
    FROM SalesItems SI
    INNER JOIN ProductVariants T1 ON SI.VariantID = T1.VariantID
    WHERE T1.ProductID = @ProductID;

    IF @SoldVariantCount > 0
    BEGIN
        ROLLBACK TRANSACTION; 
        RAISERROR('Deletion Failed: This product or its variants have historical sales records and cannot be deleted.', 16, 1);
        RETURN;
    END
    
    DELETE I 
    FROM Inventory I
    INNER JOIN ProductVariants PV ON I.VariantID = PV.VariantID
    WHERE PV.ProductID = @ProductID;
    
    DELETE FROM ProductVariants
    WHERE ProductID = @ProductID;
    
    DELETE FROM Products
    WHERE ProductID = @ProductID;

    IF @@ROWCOUNT = 0
    BEGIN
        ROLLBACK TRANSACTION; 
        RAISERROR('The specified ProductID was not found. Deletion failed.', 16, 1);
        RETURN;
    END

    COMMIT TRANSACTION;

END
GO