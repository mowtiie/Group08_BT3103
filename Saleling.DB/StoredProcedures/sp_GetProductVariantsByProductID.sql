CREATE PROCEDURE sp_GetProductVariantsByProductID
    @ProductID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        PV.VariantID,
        PV.ProductID,
        PV.SKU,
        PV.Size,
        PV.Color,
        PV.CostPrice,
        PV.SellingPrice,
        PV.StockQuantity,
        PV.ReorderLevel,
        PV.Status
    FROM
        ProductVariants PV
    WHERE
        PV.ProductID = @ProductID
END
GO