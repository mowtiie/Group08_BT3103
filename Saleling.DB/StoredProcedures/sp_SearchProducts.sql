CREATE PROCEDURE sp_SearchProducts
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
        P.Status,
        C.CategoryName,
        S.SupplierName
    FROM
        Products P
    
    INNER JOIN
        Categories C ON P.CategoryID = C.CategoryID
        
    LEFT JOIN 
        Suppliers S ON P.SupplierID = S.SupplierID
        
    LEFT JOIN
        ProductVariants PV ON P.ProductID = PV.ProductID
        
    WHERE
        (@Term IS NULL 
            OR 
            (
                @SearchFilter = 'Name' AND P.ProductName LIKE @Term
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

    GROUP BY
        P.ProductID,
        P.ProductName,
        P.Status,
        C.CategoryName,
        S.SupplierName

    ORDER BY
        P.ProductName;
END
GO