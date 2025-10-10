CREATE TABLE [dbo].[Categories]
(
	[CategoryID] INT PRIMARY KEY IDENTITY(1,1),
    [CategoryName] VARCHAR(50) NOT NULL,
    [Description] NVARCHAR(MAX)
)
