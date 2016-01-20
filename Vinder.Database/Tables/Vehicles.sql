CREATE TABLE [dbo].[Vehicles]
(
	[Id] INT NOT NULL IDENTITY,
	[DealerId] INT NULL, 
	[Vin] CHAR(17) NULL, 
	[StockNumber] VARCHAR(20) NULL, 
	[ModelYear] INT NULL, 
	[Make] VARCHAR(50) NULL, 
	[Model] VARCHAR(50) NULL, 
	[Series] VARCHAR(45) NULL, 
	[Odometer] INT NULL, 
	[Price] INT NULL,
	CONSTRAINT [PK_Vehicles] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Vehicles_Dealers] FOREIGN KEY ([DealerId]) REFERENCES [dbo].[Dealers]([Id])
);