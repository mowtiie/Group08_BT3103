CREATE PROCEDURE sp_GenerateInventoryMovementReport
    @StartDate DATETIME2,
    @EndDate DATETIME2
AS
BEGIN
    SET @EndDate = DATEADD(ms, -3, DATEADD(dd, 1, @EndDate));

    SELECT
        I.ChangeDate,
        PV.SKU,
        P.ProductName,
        CAT.CategoryName AS Category,
        PV.Size + ', ' + PV.Color AS VariantDetails,
        I.Reason,
        I.QuantityChange,
        U.FirstName + ' ' + U.LastName AS ProcessedBy,
        I.TransactionReferenceID,
        I.Notes
    FROM
        Inventory I
    INNER JOIN
        ProductVariants PV ON I.VariantID = PV.VariantID
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories CAT ON P.CategoryID = CAT.CategoryID
    INNER JOIN
        Users U ON I.ProcessedByUserID = U.UserID
    WHERE
        I.ChangeDate >= @StartDate
        AND I.ChangeDate <= @EndDate
    ORDER BY
        I.ChangeDate DESC, P.ProductName, PV.SKU;
END
GO