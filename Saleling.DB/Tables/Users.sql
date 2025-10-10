CREATE TABLE [dbo].[Users]
(
	[UserID] INT PRIMARY KEY IDENTITY(1,1),
    [FullName] VARCHAR(50) NOT NULL,
    [Username] VARCHAR(50) NOT NULL,
    [Password] VARCHAR(50) NOT NULL,
    [Role] VARCHAR(10) NOT NULL
)
