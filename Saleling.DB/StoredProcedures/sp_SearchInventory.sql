CREATE PROCEDURE sp_SearchInventory
    @SearchFilter NVARCHAR(10) = NULL,    
    @SearchTerm NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Term NVARCHAR(52) = NULL;
    IF @SearchTerm IS NOT NULL AND LTRIM(RTRIM(@SearchTerm)) <> ''
    BEGIN
        SET @Term = '%' + LTRIM(RTRIM(@SearchTerm)) + '%';
    END

    SELECT
        P.ProductID,
        P.ProductName,
        P.Status AS ProductStatus,
        PV.VariantID,
        PV.SKU,
        PV.Size,
        PV.Color,
        PV.StockQuantity,
        PV.ReorderLevel,
        PV.Status AS VariantStatus,
        PV.CostPrice,
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
        (@Term IS NULL 
            OR 
            (
                @SearchFilter = 'Name' AND P.ProductName LIKE @Term
            )
            OR 
            (
                @SearchFilter = 'SKU' AND PV.SKU LIKE @Term
            )
            OR
            (
                @SearchFilter = 'Category' AND C.CategoryName LIKE @Term
            )
            OR
            (
                @SearchFilter = 'Supplier' AND ISNULL(S.SupplierName, '') LIKE @Term
            )
        )
        OR (@SearchFilter IS NULL AND @Term IS NOT NULL AND (
                P.ProductName LIKE @Term
                OR C.CategoryName LIKE @Term
                OR ISNULL(S.SupplierName, '') LIKE @Term
            ))
    ORDER BY
        P.ProductName ASC,
        PV.SKU ASC;
END
GO