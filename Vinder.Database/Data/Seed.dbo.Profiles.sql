USE [VINder];
GO

SET IDENTITY_INSERT dbo.Profiles ON;

MERGE dbo.Profiles AS [target]
USING ( VALUES (1, 'Default Profile'))
			   AS [source] (Id, Name)
ON [target].Id = [source].Id
WHEN MATCHED AND [target].Name != [source].Name
	THEN UPDATE SET [target].Name = [source].Name
WHEN NOT MATCHED
	THEN	INSERT (Id, Name)
			VALUES (Id, Name);

SET IDENTITY_INSERT dbo.Profiles OFF;