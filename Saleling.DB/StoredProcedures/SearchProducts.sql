CREATE PROCEDURE SearchProducts
    @SearchField VARCHAR(20),
    @SearchTerm VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SearchPattern VARCHAR(102) = '%' + @SearchTerm + '%';

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
           (@SearchTerm IS NULL OR LTRIM(@SearchTerm) = '')
        OR (@SearchField = 'Name' AND p.ProductName LIKE @SearchPattern)
        OR (@SearchField = 'Category' AND c.CategoryName LIKE @SearchPattern)
        OR (@SearchField = 'Supplier' AND s.SupplierName LIKE @SearchPattern)
    ORDER BY
        p.ProductName;

END
GO