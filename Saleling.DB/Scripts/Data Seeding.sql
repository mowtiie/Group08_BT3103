-- =========================================================================
--              CREATION OF USERS (2 Admin and 3 Cashier)
-- =========================================================================

IF NOT EXISTS (SELECT 1 FROM Users)
BEGIN
    INSERT INTO Users (FirstName, LastName, Username, HashedPassword, Role)
    VALUES
        ('System', 'Administrator', 'sysadmin', '$2b$12$2tYmn/Y10JVmarUW/UQCqeV7yF/S/i8gWkKFUdRqZf3v3GK0rgmrW', 'Admin'),
        ('Vrixzandro', 'Eliponga', 'vrix.eliponga23', '$2b$12$67vcm/kNQzfaDr5QPYE9yuf5nC1DgHU2dKcu61MXlJasNOJlpDd2e', 'Admin'),
        ('John', 'Doe', 'john.doe', '$2b$12$QIVhyPt31ylPQc6VpGzPfOuFfUlPZdphLBU9EXANVlDcmM7GcmjyO', 'Cashier'),
        ('James Carl', 'Villalobos', 'james.carl44', '$2b$12$DJ6Qrjk27x96i5zDVkWDzuXtrWJMtQrcHMTRTo8bYmgF3fKKYyftC', 'Cashier'),
        ('Mark Kerwin', 'Ballelos', 'mark.kerwin84', '$2b$12$CzXttXQ0V81O7yvjQaRPnO/qZvGnMzhOHM.6WVqjdgqBqz98zRj7.', 'Cashier'),
        ('Adrienne', 'Jalocon', 'adrienne.jalocon42', '$2b$12$.DE5JVVKtxJaOT6mX6cPLOou/Uf/fa9ERR94KU3psSqdDMjxYSzui', 'Cashier');
    PRINT 'Initial user data inserted successfully.';
END
ELSE
BEGIN
    PRINT 'User table already contains data. Skipping initial data insertion.';
END