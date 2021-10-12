CREATE TABLE [dbo].[Promotion] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Total]         DECIMAL (18) NULL,
    [PromotionName] VARCHAR (50) NULL,
    CONSTRAINT [PK__Promotio__3214EC0710E08E0E] PRIMARY KEY CLUSTERED ([Id] ASC)
);

