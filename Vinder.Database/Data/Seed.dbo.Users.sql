USE [VINder];
GO

SET IDENTITY_INSERT dbo.Users ON;

MERGE dbo.Users AS [target]
USING ( VALUES (1,'Joshi','Suvarna','sjoshi',NULL,NULL,NULL,NEWID()),
			   (2,'Dutta','Sarmistha','sdutta',NULL,NULL,NULL,NEWID()),
			   (3,'Heidt','Kevin','kheidt',NULL,NULL,NULL,NEWID()),
			   (4,'Cappelletti','TJ','tcappelletti',NULL,NULL,NULL,NEWID()),
			   (5,'Koduru','Haritha','hkoduru',NULL,NULL,NULL,NEWID()))
			   AS [source] (Id, LastName, FirstName, UserName, [Password], Email, Phone, UniqueId)
ON [target].Id = [source].Id
WHEN MATCHED AND [target].LastName != [source].LastName
              OR [target].FirstName != [source].FirstName
              OR [target].UserName != [source].UserName
              OR [target].[Password] != [source].[Password]
              OR [target].Email != [source].Email
              OR [target].Phone  != [source].Phone
	THEN UPDATE SET [target].LastName = [source].LastName,
				    [target].FirstName = [source].FirstName,
				    [target].UserName = [source].UserName,
				    [target].[Password] = [source].[Password],
				    [target].Email = [source].Email,
				    [target].Phone  = [source].Phone
WHEN NOT MATCHED
	THEN	INSERT (Id, LastName, FirstName, UserName, [Password], Email, Phone, UniqueId)
			VALUES (Id, LastName, FirstName, UserName, [Password], Email, Phone, UniqueId);

SET IDENTITY_INSERT dbo.Users OFF;