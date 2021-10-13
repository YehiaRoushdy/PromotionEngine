CREATE TABLE [dbo].[Sku] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Sku]   VARCHAR (1)  NULL,
    [Price] DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

