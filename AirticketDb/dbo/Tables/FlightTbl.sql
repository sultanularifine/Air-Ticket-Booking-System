CREATE TABLE [dbo].[FlightTbl] (
    [f_id]   INT          IDENTITY (1, 1) NOT NULL,
    [fcode]  VARCHAR (50) NOT NULL,
    [fsrc]   VARCHAR (50) NOT NULL,
    [fDest]  VARCHAR (50) NOT NULL,
    [fDate]  DATE         NOT NULL,
    [fTime]  TIME (7)     NOT NULL,
    [fCap]   INT          NOT NULL,
    [fClass] VARCHAR (50) NOT NULL,
    [fPrice] INT          NOT NULL,
    CONSTRAINT [PK_FlightTbl] PRIMARY KEY CLUSTERED ([f_id] ASC)
);

