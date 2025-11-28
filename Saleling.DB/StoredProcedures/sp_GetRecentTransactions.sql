CREATE PROCEDURE sp_GetRecentTransactions
    @ProcessedByUserID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        S.SaleID,
        S.SaleDate,
        S.TotalAmount,
        U.FirstName + ' ' + U.LastName AS Cashier,
        C.FirstName + ' ' + C.LastName AS Customer
    FROM
        Sales S
    INNER JOIN
        Users U ON S.ProcessedByUserID = U.UserID
    LEFT JOIN
        Customers C ON S.CustomerID = C.CustomerID
    WHERE
        (@ProcessedByUserID IS NULL OR S.ProcessedByUserID = @ProcessedByUserID)
        AND CAST(S.SaleDate AS DATE) = CAST(GETDATE() AS DATE)
    ORDER BY
        S.SaleDate DESC;
END
GO