CREATE TABLE [dbo].[income_level] (
    [income_level_id] INT          IDENTITY (1, 1) NOT NULL,
    [description]     VARCHAR (50) NULL,
    [code]            VARCHAR (2)  NULL,
    [tenant_id]       INT          NULL,
    CONSTRAINT [PK_income_level] PRIMARY KEY CLUSTERED ([income_level_id] ASC) WITH (FILLFACTOR = 90)
);

