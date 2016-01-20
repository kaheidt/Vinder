CREATE TABLE [dbo].[UserProfiles]
(
	[UserId] INT NOT NULL, 
	[ProfileId] INT NOT NULL,
	CONSTRAINT [PK_UserProfiles] PRIMARY KEY ([UserId], [ProfileId]),
	CONSTRAINT [FK_UserProfiles_Profiles] FOREIGN KEY ([ProfileId]) REFERENCES [dbo].[Profiles]([Id]),
	CONSTRAINT [FK_UserProfiles_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users]([Id]),
);