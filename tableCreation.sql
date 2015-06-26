CREATE TABLE [db].[tblLogging] (
    [ApplicationName]       VARCHAR (100) NOT NULL,
    [IdentifierType] VARCHAR (100) NOT NULL,
    [Identifier]     VARCHAR (50)  NOT NULL,
    [EventID]               INT           NOT NULL,
    [Routine]               VARCHAR (100) NOT NULL,
    [LocationID]            INT           NULL,
    [CreatedDT]             DATETIME      NOT NULL,
    [CreatedByID]           INT           NOT NULL,
    CONSTRAINT [PK_tblLogging] PRIMARY KEY CLUSTERED ([IdentifierType] ASC, [Identifier] ASC, [CreatedDT] ASC, [CreatedByID] ASC),
    CONSTRAINT [FK_tblLogging_tblEvent] FOREIGN KEY ([EventID]) REFERENCES [LIS].[tblEvent] ([ID]),
    CONSTRAINT [FK_tblLogging_tblLocation] FOREIGN KEY ([LocationID]) REFERENCES [LIS].[tblLocation] ([ID]),
    CONSTRAINT [FK_tblLogging_tblUser] FOREIGN KEY ([CreatedByID]) REFERENCES [LIS].[tblUser] ([ID])
);