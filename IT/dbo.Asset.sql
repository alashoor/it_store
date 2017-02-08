CREATE TABLE [dbo].[Asset] (
    [assetlID]     INT          IDENTITY (1, 1) NOT NULL,
    [modelID]      INT          NULL,
    [serialNumber] VARCHAR (50) NULL,
    [barcode]      VARCHAR (50) NULL,
    [seviceTag]    VARCHAR (50) NULL,
    [status]       VARCHAR (50) NULL,
    [remarks]      VARCHAR (50) NULL,
    [locationID]   INT          NULL,
    [timestamp]    DATE         NULL DEFAULT getDate(),
    [ticketNumber] VARCHAR (50) NULL,
    [userName]     VARCHAR (50) NULL,
    [DHLPolicy]    VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([assetlID] ASC),
    FOREIGN KEY ([modelID]) REFERENCES [dbo].[Model] ([modelID]),
    FOREIGN KEY ([locationID]) REFERENCES [dbo].[Location] ([locationID])
);

