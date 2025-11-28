CREATE PROCEDURE sp_GetSaleableProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        PV.VariantID,
        PV.ProductID,
        P.ProductName,
        PV.SKU,
        PV.Size,
        PV.Color,
        PV.SellingPrice,
        PV.StockQuantity,
        C.CategoryName AS Category
    FROM
        ProductVariants PV
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories C ON P.CategoryID = C.CategoryID
    WHERE
        PV.StockQuantity > 0
        AND PV.Status = 'Active'
        AND P.Status = 'Active'
    ORDER BY
        P.ProductName ASC,
        PV.Size DESC;
END
GO