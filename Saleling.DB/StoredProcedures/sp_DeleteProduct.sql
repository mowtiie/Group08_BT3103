CREATE PROCEDURE sp_DeleteProduct
    @ProductID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
    DECLARE @CurrentStatus VARCHAR(20);

    BEGIN TRY
        IF @ProductID IS NULL
        BEGIN
            RAISERROR('ProductID is required for DELETE command.', 16, 1);
            RETURN;
        END

        SELECT @CurrentStatus = Status FROM Products WHERE ProductID = @ProductID;

        IF @CurrentStatus IS NULL
        BEGIN
            RAISERROR('Product with the specified ID does not exist.', 16, 1);
            RETURN;
        END
        
        IF EXISTS (SELECT 1 FROM ProductVariants WHERE ProductID = @ProductID)
        BEGIN
            UPDATE Products
            SET Status = 'Archived'
            WHERE ProductID = @ProductID;
            
            UPDATE ProductVariants
            SET Status = 'Discontinued'
            WHERE ProductID = @ProductID;

            RAISERROR('Product soft-deleted (Archived) because it contains existing variants.', 16, 1) WITH NOWAIT;
            RETURN;
        END
        ELSE
        BEGIN
            DELETE FROM Products
            WHERE ProductID = @ProductID;
        END

    END TRY
    BEGIN CATCH
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(), 
            @ErrorSeverity = ERROR_SEVERITY(), 
            @ErrorState = ERROR_STATE();
        
        IF @ErrorSeverity = 0
            SET @ErrorSeverity = 16;

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
        RETURN;
    END CATCH
END
GO