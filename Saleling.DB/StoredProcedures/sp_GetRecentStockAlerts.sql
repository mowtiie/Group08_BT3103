CREATE PROCEDURE sp_GetRecentStockAlerts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        PV.SKU,
        P.ProductName,
        PV.Size,
        PV.Color,
        C.CategoryName AS Category,
        S.SupplierName AS Supplier,
        CASE 
            WHEN PV.StockQuantity = 0 THEN 'Out of Stock'
            WHEN PV.StockQuantity <= PV.ReorderLevel THEN CAST(PV.StockQuantity AS VARCHAR) + ' left'
            ELSE 'Sufficient'
        END AS Status
    FROM
        ProductVariants PV
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories C ON P.CategoryID = C.CategoryID
    LEFT JOIN
        Suppliers S ON P.SupplierID = S.SupplierID   
    WHERE
        PV.StockQuantity <= PV.ReorderLevel
        AND PV.Status = 'Active' 
    
    ORDER BY
        PV.StockQuantity ASC,
        P.ProductName;

END
GO