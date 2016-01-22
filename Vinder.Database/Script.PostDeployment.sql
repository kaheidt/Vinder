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
:r .\Data\Seed.dbo.Users.sql
:r .\Data\Seed.dbo.Profiles.sql
:r .\Data\Seed.dbo.ProfileDetails.sql
:r .\Data\Seed.dbo.UserProfiles.sql

:r .\Data\Seed.dbo.Dealers.sql
:r .\Data\Seed.dbo.Vehicles.sql