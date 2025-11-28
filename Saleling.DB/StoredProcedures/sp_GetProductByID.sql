CREATE PROCEDURE sp_GetProductByID
    @ProductID INT
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
    WHERE
        P.ProductID = @ProductID
END
GO