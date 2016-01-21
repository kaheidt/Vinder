USE [VINder];
GO

SET IDENTITY_INSERT dbo.ProfileDetails ON

MERGE dbo.ProfileDetails AS [target]
USING ( VALUES (1,1,'Year','2015',2),
               (2,1,'Make','Audi',1),
			   (3,1,'Model','TT',1),
			   (4,1,'Year','2015',1),
			   (5,1,'Make','Jeep',1),
			   (6,1,'Model','Grand Cherokee',1),
			   (7,1,'Year','2015',-1),
			   (8,1,'Make','Ford',-1),
			   (9,1,'Model','F-150',-1))
			   AS [source] (Id, ProfileId, [Type], Value, Score)
ON [target].Id = [source].Id
WHEN MATCHED AND [target].ProfileId != [source].ProfileId
			  OR [target].[Type] != [source].[Type]
			  OR [target].Value != [source].Value
			  OR [target].Score != [source].Score
	THEN UPDATE SET [target].ProfileId = [source].ProfileId,
                    [target].[Type] = [source].[Type],
                    [target].Value = [source].Value,
                    [target].Score = [source].Score
WHEN NOT MATCHED
	THEN	INSERT (Id, ProfileId, [Type], Value, Score)
			VALUES (Id, ProfileId, [Type], Value, Score);

SET IDENTITY_INSERT dbo.ProfileDetails OFF