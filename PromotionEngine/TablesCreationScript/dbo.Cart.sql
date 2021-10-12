CREATE TABLE [dbo].[Cart] (
    [Id]         INT           NOT NULL,
    [Order_Date] DATETIME2 (7) NULL,
    [Total]      DECIMAL (18)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

