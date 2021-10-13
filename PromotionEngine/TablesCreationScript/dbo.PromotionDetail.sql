CREATE TABLE [dbo].[PromotionDetail] (
    [Id]           INT          NOT NULL,
    [Promotion_Id] INT          NULL,
    [Sku_Id]       INT          NULL,
    [Quantity]     INT   NULL,
    [Price]        DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Sku_Id] FOREIGN KEY ([Sku_Id]) REFERENCES [dbo].[Sku] ([Id]),
    CONSTRAINT [FK_Promotion_Id] FOREIGN KEY ([Promotion_Id]) REFERENCES [dbo].[Promotion] ([Id])
);

