CREATE TABLE [dbo].[PassengersTbl] (
    [P_ID]   INT          IDENTITY (1, 1) NOT NULL,
    [PName]  VARCHAR (50) NOT NULL,
    [MobNo]  INT          NOT NULL,
    [FCode]  VARCHAR (50) NOT NULL,
    [FSrc]   VARCHAR (50) NOT NULL,
    [FDest]  VARCHAR (50) NOT NULL,
    [FDate]  DATE         NOT NULL,
    [FTime]  TIME (7)     NOT NULL,
    [FCap]   INT          NOT NULL,
    [FClass] VARCHAR (50) NOT NULL,
    [TPrice] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([P_ID] ASC)
);

