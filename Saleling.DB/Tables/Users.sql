CREATE TABLE [dbo].[Users]
(
	[UserID] INT PRIMARY KEY IDENTITY(1,1),
    [FirstName] VARCHAR(100) NOT NULL,
    [LastName] VARCHAR(100) NOT NULL,
    [Username] VARCHAR(100) NOT NULL,
    [HashedPassword] VARCHAR(100) NOT NULL,
    [Role] VARCHAR(10) NOT NULL
)
