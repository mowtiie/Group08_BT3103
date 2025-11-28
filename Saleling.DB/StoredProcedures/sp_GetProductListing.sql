CREATE PROCEDURE sp_GetProductListing
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.ProductID,
        P.ProductName,
        PV.VariantID,
        PV.SKU,
        PV.Size,
        PV.Color,
        PV.StockQuantity,
        PV.ReorderLevel,
        PV.SellingPrice,
        C.CategoryName AS Category,
        S.SupplierName AS Supplier
    FROM
        ProductVariants PV
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories C ON P.CategoryID = C.CategoryID
    LEFT JOIN 
        Suppliers S ON P.SupplierID = S.SupplierID
        
    WHERE
        P.Status = 'Active'
        AND PV.Status = 'Active'
    ORDER BY
        P.ProductName ASC,
        PV.SKU ASC;
END
GO