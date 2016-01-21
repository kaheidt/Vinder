/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
:r .\Seed.dbo.Users.sql
:r .\Seed.dbo.Profiles.sql
:r .\Seed.dbo.ProfileDetails.sql
:r .\Seed.dbo.UserProfiles.sql

:r .\Seed.dbo.Dealers.sql
:r .\Seed.dbo.Vehicles.sql