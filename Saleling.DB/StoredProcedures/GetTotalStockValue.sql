CREATE PROCEDURE GetTotalStockValue
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        ISNULL(SUM(PV.UnitsInStock * P.UnitPrice), 0.00) AS TotalStockValue
    FROM
        ProductVariants PV
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID;
END
GO