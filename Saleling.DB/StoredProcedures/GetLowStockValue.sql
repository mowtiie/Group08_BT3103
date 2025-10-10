CREATE PROCEDURE GetLowStockItemsCount
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        COUNT(PV.VariantID) AS TotalLowStockItems
    FROM
        ProductVariants PV
    WHERE
        PV.UnitsInStock < PV.ReorderLevel;
END
GO