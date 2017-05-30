CREATE TABLE [dbo].[income_level_settings] (
    [income_level_settings_id] INT         IDENTITY (1, 1) NOT NULL,
    [year]                     INT         NULL,
    [category_code]            VARCHAR (5) NULL,
    [income_level_code]        VARCHAR (5) NULL,
    [less_or_equal]            INT         NULL,
    [more_than]                INT         NULL,
    [tenant_id]                INT         NULL
);

