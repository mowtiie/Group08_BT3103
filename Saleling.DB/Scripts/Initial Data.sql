USE Saleling.DB;
GO

SET NOCOUNT ON;
BEGIN TRANSACTION;

BEGIN TRY
    IF NOT EXISTS (SELECT 1 FROM Admin WHERE username = 'admin1')
        INSERT INTO Admin (username, password) VALUES ('admin1', 'pass1234');
    
    IF NOT EXISTS (SELECT 1 FROM Admin WHERE username = 'admin2')
        INSERT INTO Admin (username, password) VALUES ('admin2', 'pass1234');
    
    IF NOT EXISTS (SELECT 1 FROM Admin WHERE username = 'admin3')
        INSERT INTO Admin (username, password) VALUES ('admin3', 'pass1234');
    
    IF NOT EXISTS (SELECT 1 FROM Admin WHERE username = 'admin4')
        INSERT INTO Admin (username, password) VALUES ('admin4', 'pass1234');
    
    IF NOT EXISTS (SELECT 1 FROM Admin WHERE username = 'admin5')
        INSERT INTO Admin (username, password) VALUES ('admin5', 'pass1234');

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
END CATCH;
GO

SET NOCOUNT ON;
BEGIN TRANSACTION;

BEGIN TRY
    IF NOT EXISTS (SELECT 1 FROM Cashier WHERE username = 'cashier1')
        INSERT INTO Cashier (username, password) VALUES ('cashier1', 'pass5678');
    
    IF NOT EXISTS (SELECT 1 FROM Cashier WHERE username = 'cashier2')
        INSERT INTO Cashier (username, password) VALUES ('cashier2', 'pass5678');
    
    IF NOT EXISTS (SELECT 1 FROM Cashier WHERE username = 'cashier3')
        INSERT INTO Cashier (username, password) VALUES ('cashier3', 'pass5678');
    
    IF NOT EXISTS (SELECT 1 FROM Cashier WHERE username = 'cashier4')
        INSERT INTO Cashier (username, password) VALUES ('cashier4', 'pass5678');
    
    IF NOT EXISTS (SELECT 1 FROM Cashier WHERE username = 'cashier5')
        INSERT INTO Cashier (username, password) VALUES ('cashier5', 'pass5678');

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
END CATCH;
GO