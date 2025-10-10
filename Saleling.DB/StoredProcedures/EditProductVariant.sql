CREATE PROCEDURE EditProductVariant
    @VariantID INT,
    @SKU VARCHAR(50),
    @Size VARCHAR(10),
    @Color VARCHAR(20),
    @ReorderLevel INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1 
        FROM ProductVariants 
        WHERE SKU = @SKU 
          AND VariantID <> @VariantID
    )
    BEGIN
        RAISERROR('A variant with the SKU "%s" already exists.', 16, 1, @SKU);
        RETURN;
    END

    UPDATE ProductVariants
    SET
        SKU = @SKU,
        Size = @Size,
        Color = @Color,
        ReorderLevel = @ReorderLevel
    WHERE
        VariantID = @VariantID;
        
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('The specified VariantID was not found. Update failed.', 16, 1);
        RETURN;
    END

END
GO