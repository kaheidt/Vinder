CREATE TABLE [dbo].[ProfileDetails]
(
	[Id] INT NOT NULL IDENTITY,
	[ProfileId] INT NULL, 
	[Type] VARCHAR(50) NULL, 
	[Value] VARCHAR(50) NULL, 
	[Score] INT NULL,
	CONSTRAINT [PK_ProfileDetails] PRIMARY KEY ([Id])
);