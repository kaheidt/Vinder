CREATE TABLE [dbo].[Profiles]
(
	[Id] INT NOT NULL IDENTITY, 
	[Name] VARCHAR(50) NULL, 
	[Description] NVARCHAR(MAX) NULL, 
	[MinYear] INT NULL, 
	[MaxYear] INT NULL, 
	[MinOdometer] INT NULL, 
	[MaxOdometer] INT NULL, 
	[MinPrice] INT NULL, 
	[MaxPrice] INT NULL
	CONSTRAINT [PK_Profiles] PRIMARY KEY ([Id])
);