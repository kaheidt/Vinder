SET IDENTITY_INSERT dbo.Dealers ON;

INSERT INTO dbo.Dealers (Id, Name, [Address], City, [State], PostalCode, GeoLocation)
VALUES	(1,'Broadway Ashland','2700 S Ashland Ave','Green Bay','WI','19341',GEOGRAPHY::Point(44.503211,-88.067350,4326)),
        (2,'Van Campen Dodge Chrysler Jeep','601 West 3rd Street','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326)),
		(3,'Todd Hunzeker Ford','166 W 2nd S','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326)),
		(4,'Terryville Chevrolet','302 MAIN ST','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326)),
		(5,'Chase Auto Plex','2410 N. I-35 E','Green Bay','WI','54304',GEOGRAPHY::Point(44.503211,-88.067350,4326)),
		(6,'Loganville Ford','3460 Highway 78','Lancaster','TX','75134',GEOGRAPHY::Point(32.618452,-96.780593,4326)),
		(7,'Munday Mazda','555 Fm 1960 Rd W','Loganville','GA','30052',GEOGRAPHY::Point(33.810339,-83.891909,4326)),
		(8,'A-Pro Auto Sales','1155 Cripple Creek Dr',NULL,NULL,'77090',GEOGRAPHY::Point(32.6336187,-97.1006119,4326)),
		(9,'Bill Rapp Superstore','3449 Burnet Ave','Lawrenceville','GA','30043',GEOGRAPHY::Point(34.009393,-84.001553,4326)),
		(10,'Sloan Ford','415 W Lincoln Hwy','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326)),
		(11,'Town Motors','305 W Lincoln Hwy','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326)),
		(12,'Roberts Chevrolet','421 W. Lincoln Highway','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326)),
		(13,'Exton Nissan','200 W Lincoln Hwy','Exton','PA','19341',GEOGRAPHY::Point(40.040047,-75.636825,4326));

SET IDENTITY_INSERT dbo.Dealers OFF;