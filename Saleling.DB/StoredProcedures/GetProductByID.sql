CREATE PROCEDURE GetProductByID
    @ProductID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        p.ProductID,
        p.ProductName,
        c.CategoryName AS Category,
        s.SupplierName AS Supplier,
        p.UnitPrice AS BasePrice,
        p.Description
    FROM
        Products p
    INNER JOIN 
        Categories c ON p.CategoryID = c.CategoryID
    LEFT JOIN 
        Suppliers s ON p.SupplierID = s.SupplierID
    WHERE
        p.ProductID = @ProductID

END
GO