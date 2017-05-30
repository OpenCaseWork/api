CREATE TABLE [dbo].[constituent_income_level] (
    [constituent_income_level_id] INT IDENTITY (1, 1) NOT NULL,
    [constituent_id]              INT NOT NULL,
    [income_level_type_id]        INT NULL,
    [income_level_id]             INT NULL,
    [tenant_id]                   INT NULL,
    CONSTRAINT [PK_constituent_income_level] PRIMARY KEY CLUSTERED ([constituent_income_level_id] ASC) WITH (FILLFACTOR = 90)
);

