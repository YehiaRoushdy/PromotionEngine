CREATE TABLE [dbo].[Cart] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [OrderDate] DATETIME2 (7) NULL,
    [Total]      DECIMAL (18)  NULL,
    CONSTRAINT [PK__Cart__3214EC074220B565] PRIMARY KEY CLUSTERED ([Id] ASC)
);

