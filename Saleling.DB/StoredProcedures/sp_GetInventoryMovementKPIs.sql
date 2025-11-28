CREATE PROCEDURE sp_GetInventoryMovementKPIs
    @StartDate DATETIME2,
    @EndDate DATETIME2
AS
BEGIN
    SET NOCOUNT ON;
    
    SET @EndDate = DATEADD(ms, -3, DATEADD(dd, 1, @EndDate));

    WITH MovementSummary AS (
        SELECT
            QuantityChange,
            Reason
        FROM
            Inventory
        WHERE
            ChangeDate >= @StartDate
            AND ChangeDate <= @EndDate
    )
    SELECT
        ISNULL(SUM(CASE WHEN Reason = 'Sale' THEN ABS(QuantityChange) ELSE 0 END), 0) AS TotalUnitsSold,
        ISNULL(SUM(CASE WHEN Reason = 'Initial Receipt' THEN QuantityChange ELSE 0 END), 0) AS TotalUnitsReceived,
        ISNULL(SUM(QuantityChange), 0) AS NetInventoryChange,
        ISNULL(SUM(CASE 
            WHEN Reason IN (
                'Found Stock', 
                'Physical Reconciliation', 
                'Damaged/Scrap', 
                'Shrinkage/Loss', 
                'Physical Discrepancy', 
                'System Error Correction'
            ) THEN ABS(QuantityChange) 
            ELSE 0 
        END), 0) AS TotalAdjustments
    FROM
        MovementSummary;

END
GO