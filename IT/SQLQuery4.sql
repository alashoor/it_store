CREATE TABLE Location
(
		locationID int primary key identity (1,1),
		costCenter varchar(50),
        locationName varchar(50),
        unit varchar(50),
        businessArea varchar(50),
        ladiesSection BIT,
        uppurtNodeName varchar(50),
        accessPermission varchar(50),
        distanceFromSupportNode varchar(50),
        classification varchar(50),
)

CREATE TABLE Brand
(
       brandID int primary key identity (1,1),
       brandName varchar(50),
)
 
CREATE TABLE Item
(
       itemID int primary key identity (1,1),
	   brandID int foreign key references Brand (brandID),
       itemName varchar(50),
)

CREATE TABLE Model
(
       modelID int primary key identity (1,1),
	   itemID int foreign key references Item (itemID),
       modelName varchar(50),
	   weight int,
	   price int,
)

CREATE TABLE Asset
(
       assetlID int primary key identity (1,1),
	   modelID int foreign key references Model (modelID),
       serialNumber varchar(50),
       barcode varchar(50),
	   seviceTag varchar(50),
	   status varchar(50),
	   remarks varchar(50),
	   locationID int foreign key references Location (locationID),
	   timestamp date,
)

CREATE TABLE Person
(
		personID int primary key identity (1,1),
        employeeID int,
        name varchar(50),
        title varchar(50),
        department varchar(50),
        officeNumber varchar(50),
        mobileNumber varchar(50),
        email varchar(50),
)

CREATE TABLE RejectionRequests
(
       rejectionRequestsID int primary key identity (1,1),
       serialNumber varchar(50),
       barcode varchar(50),
       serviceTag varchar(50),
       businessArea varchar(50),
       justification varchar(50),
	   locationID int foreign key references Location (locationID),
	   timestamp date,
)