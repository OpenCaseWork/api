CREATE TABLE [dbo].[income_level_category] (
    [income_level_category_id] INT          IDENTITY (1, 1) NOT NULL,
    [category]                 VARCHAR (50) NULL,
    [code]                     VARCHAR (2)  NULL,
    [tenant_id]                INT          NULL
);

