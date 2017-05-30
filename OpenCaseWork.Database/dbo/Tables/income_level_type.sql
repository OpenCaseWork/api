CREATE TABLE [dbo].[income_level_type] (
    [income_level_type_id] INT          IDENTITY (1, 1) NOT NULL,
    [description]          VARCHAR (50) NULL,
    [active]               CHAR (1)     NULL,
    [tenant_id]            INT          NULL,
    CONSTRAINT [PK_income_level_type] PRIMARY KEY CLUSTERED ([income_level_type_id] ASC) WITH (FILLFACTOR = 90)
);

