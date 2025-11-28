CREATE PROCEDURE sp_GenerateSalesReport
    @StartDate DATETIME2,
    @EndDate DATETIME2,
    @ProcessedByUserID INT = NULL
AS
BEGIN
    SET @EndDate = DATEADD(ms, -3, DATEADD(dd, 1, @EndDate));

    SELECT
        S.SaleID,
        S.SaleDate,
        U.FirstName + ' ' + U.LastName AS ProcessedBy,
        P.ProductName,
        PV.Size + ', ' + PV.Color AS VariantDetails,
        CAT.CategoryName AS Category,
        PV.SKU,
        SI.Quantity,
        SI.UnitPrice,
        SI.Discount,

        SI.SubTotal AS Revenue,
        (PV.CostPrice * SI.Quantity) AS COGS,
        (SI.SubTotal - (PV.CostPrice * SI.Quantity)) AS GrossProfit,

        S.TotalAmount
    FROM
        Sales S
    INNER JOIN
        SalesItems SI ON S.SaleID = SI.SaleID
    INNER JOIN
        ProductVariants PV ON SI.VariantID = PV.VariantID
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    INNER JOIN
        Categories CAT ON P.CategoryID = CAT.CategoryID
    INNER JOIN
        Users U ON S.ProcessedByUserID = U.UserID
    WHERE
        S.SaleDate >= @StartDate
        AND S.SaleDate <= @EndDate
        AND (@ProcessedByUserID IS NULL OR S.ProcessedByUserID = @ProcessedByUserID)
    ORDER BY
        S.SaleDate DESC, S.SaleID, SI.SaleItemID;

END;
GO