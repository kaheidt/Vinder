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
	[BodyDescription] VARCHAR(200) NULL, 
	[TransmissionDescription] VARCHAR(200) NULL, 
	[ExteriorColor] VARCHAR(50) NULL, 
	[InteriorColor] VARCHAR(50) NULL, 
	[InteriorType] VARCHAR(50) NULL, 
	[NewUsed] VARCHAR(10) NULL, 
	CONSTRAINT [PK_Vehicles] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Vehicles_Dealers] FOREIGN KEY ([DealerId]) REFERENCES [dbo].[Dealers]([Id])
);