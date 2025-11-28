CREATE PROCEDURE sp_GetProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.ProductID,
        P.ProductName,
        C.CategoryName,
        S.SupplierName,
        P.Status
    FROM
        Products P
    INNER JOIN
        Categories C ON P.CategoryID = C.CategoryID
    LEFT JOIN
        Suppliers S ON P.SupplierID = S.SupplierID
    LEFT JOIN
        ProductVariants PV ON P.ProductID = PV.ProductID
    GROUP BY
        P.ProductID, P.ProductName, C.CategoryName, S.SupplierName, P.Status
    ORDER BY
        P.ProductName;
END
GO