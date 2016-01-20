﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL IDENTITY,
	[UniqueId] UNIQUEIDENTIFIER NOT NULL, 
	[LastName] VARCHAR(45) NULL, 
	[FirstName] VARCHAR(45) NULL, 
	[UserName] VARCHAR(45) NULL, 
	[Password] VARCHAR(45) NULL, 
	[Email] VARCHAR(200) NULL, 
	[Phone] CHAR(10) NULL,
	CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);