CREATE PROCEDURE sp_GetInventoryLogs
    @VariantID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        I.InventoryID,
        I.VariantID,
        I.QuantityChange,
        I.ChangeDate,
        I.Reason,
        I.TransactionReferenceID,
        I.Notes,
        U.FirstName + ' ' + U.LastName AS Processor,
        U.Role

    FROM
        Inventory I
    INNER JOIN
        Users U ON I.ProcessedByUserID = U.UserID

    WHERE
        I.VariantID = @VariantID

    ORDER BY
        I.ChangeDate DESC;
END
GO