CREATE PROCEDURE sp_GetSaleReceiptDetails
(
    @SaleID INT
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        S.SaleID,
        S.SaleDate,
        S.TotalAmount,
        
        C.CustomerID,
        C.FirstName AS CustomerFirstName,
        C.LastName AS CustomerLastName,
        C.LoyaltyPoints,
        
        U.FirstName AS CashierFirstName,
        U.LastName AS CashierLastName
    FROM 
        Sales S
    INNER JOIN 
        Customers C ON S.CustomerID = C.CustomerID
    INNER JOIN 
        Users U ON S.ProcessedByUserID = U.UserID
    WHERE 
        S.SaleID = @SaleID;

    SELECT
        SI.SaleItemID,
        SI.Quantity,
        SI.UnitPrice,
        SI.Discount,
        SI.SubTotal,
        
        PV.SKU,
        P.ProductName,
        PV.Size,
        PV.Color
    FROM 
        SalesItems SI
    INNER JOIN 
        ProductVariants PV ON SI.VariantID = PV.VariantID
    INNER JOIN
        Products P ON PV.ProductID = P.ProductID
    WHERE 
        SI.SaleID = @SaleID
    ORDER BY 
        SI.SaleItemID;

END
GO