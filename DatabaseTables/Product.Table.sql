CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] INT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Price] MONEY NULL, 
    [Image] IMAGE NULL
)
