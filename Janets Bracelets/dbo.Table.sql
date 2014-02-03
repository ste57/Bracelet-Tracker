CREATE TABLE [dbo].[Table]
(
	[CustomerID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EbayID] VARCHAR(50) NOT NULL, 
    [Name] VARCHAR(50) NULL, 
    [Address] VARCHAR(MAX) NOT NULL
)
