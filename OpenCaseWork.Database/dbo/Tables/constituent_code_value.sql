CREATE TABLE [dbo].[constituent_code_value] (
    [constituent_code_value_id] INT      IDENTITY (1, 1) NOT NULL,
    [constituent_id]            INT      NOT NULL,
    [code_value_id]             INT      NOT NULL,
    [code_id]                   INT      NOT NULL,
    [code_value_date]           DATETIME NULL,
    [tenant_id]                 INT      NULL,
    CONSTRAINT [PK_constituent_code_value] PRIMARY KEY CLUSTERED ([constituent_code_value_id] ASC) WITH (FILLFACTOR = 90)
);

