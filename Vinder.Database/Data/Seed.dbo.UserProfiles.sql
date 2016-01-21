USE [VINder];
GO

MERGE dbo.UserProfiles AS [target]
USING ( VALUES (5, 1))
			   AS [source] (UserId, ProfileId)
ON  [target].UserId = [source].UserId
AND [target].ProfileId = [source].ProfileId
WHEN NOT MATCHED
	THEN	INSERT (UserId, ProfileId)
			VALUES (UserId, ProfileId)
WHEN NOT MATCHED BY SOURCE
	THEN	DELETE;