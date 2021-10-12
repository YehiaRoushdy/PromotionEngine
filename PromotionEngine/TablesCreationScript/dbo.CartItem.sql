CREATE TABLE [dbo].[CartItem] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Sku_Id]   INT          NULL,
	  [Cart_Id]   INT          NULL,
    [Quantity] INT          NULL,
    [Total]    DECIMAL (18) NULL,
    CONSTRAINT [FK_Cart_Sku_Id] FOREIGN KEY ([Sku_Id]) REFERENCES [dbo].[Sku] ([Id]), 
    CONSTRAINT [FK_CartItem_CartId] FOREIGN KEY ([Cart_Id]) REFERENCES [dbo].[Cart]([Id])
);

