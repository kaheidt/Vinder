CREATE TABLE [dbo].[Dealers]
(
	[Id] INT NOT NULL IDENTITY, 
	[Name] VARCHAR(50) NULL, 
	[Address] VARCHAR(1000) NULL, 
	[City] VARCHAR(100) NULL, 
	[State] CHAR(2) NULL, 
	[PotalCode] VARCHAR(9) NULL, 
	[GeoLocation] [sys].[geography] NULL,
	CONSTRAINT [PK_Dealers] PRIMARY KEY ([Id])
);