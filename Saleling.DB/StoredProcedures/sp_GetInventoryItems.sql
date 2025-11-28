CREATE PROCEDURE sp_GetInventoryItems
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.ProductID,
        P.ProductName,
        P.Status AS ProductStatus,
        C.CategoryName AS Category,
        S.SupplierName AS Supplier,
        PV.VariantID,
        PV.SKU,
        PV.Size,
        PV.Color,
        PV.StockQuantity,
        PV.ReorderLevel,
        PV.Status AS VariantStatus
    FROM
        ProductVariants PV
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories C ON P.CategoryID = C.CategoryID
    LEFT JOIN
        Suppliers S ON P.SupplierID = S.SupplierID
    ORDER BY
        P.ProductName ASC,
        PV.SKU ASC;
END
GO