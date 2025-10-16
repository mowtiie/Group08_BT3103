CREATE PROCEDURE GetOutOfStockItemsCount
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        COUNT(PV.VariantID) AS TotalOutOfStockItems
    FROM
        ProductVariants PV
    WHERE
        PV.UnitsInStock = 0;
END
GO