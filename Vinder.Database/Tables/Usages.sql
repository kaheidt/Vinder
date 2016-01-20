CREATE TABLE [dbo].[Usages]
(
	[Id] INT NOT NULL IDENTITY, 
	[Year] INT NULL, 
	[Make] VARCHAR(50) NULL, 
	[Model] VARCHAR(50) NULL, 
	[Action] VARCHAR(50) NULL, 
	[UserId] INT NULL,
	CONSTRAINT [PK_Usages] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Usages_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users]([Id])
);