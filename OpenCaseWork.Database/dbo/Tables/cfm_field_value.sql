CREATE TABLE [dbo].[cfm_field_value] (
    [cfm_field_value_id] INT          IDENTITY (1, 1) NOT NULL,
    [cfm_file_id]        INT          NULL,
    [field]              VARCHAR (50) NULL,
    [value]              VARCHAR (50) NULL,
    [type]               VARCHAR (50) NULL,
    [tenant_id]          INT          NULL,
    CONSTRAINT [PK_cfm_field_value] PRIMARY KEY CLUSTERED ([cfm_field_value_id] ASC) WITH (FILLFACTOR = 90)
);

