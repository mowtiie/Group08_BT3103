CREATE PROCEDURE sp_GenerateInventoryStockReport
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        PV.SKU,
        P.ProductName,
        CAT.CategoryName,
        PV.Size + ', ' + PV.Color AS VariantDetails,
        PV.StockQuantity,
        PV.ReorderLevel,
        CASE 
            WHEN PV.StockQuantity = 0 THEN 'Out of Stock'
            WHEN PV.StockQuantity <= PV.ReorderLevel THEN 'Low Stock (' + CAST(PV.StockQuantity AS VARCHAR) + ' left)'
            ELSE 'In Stock'
        END AS StockStatus
    FROM
        ProductVariants PV
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories CAT ON P.CategoryID = CAT.CategoryID
    WHERE
        PV.Status = 'Active'
        AND P.Status = 'Active'
    ORDER BY
        PV.StockQuantity ASC;
END
GO