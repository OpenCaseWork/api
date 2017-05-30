CREATE TABLE [dbo].[cfm_impairment_value] (
    [cfm_impairment_value_id] INT          IDENTITY (1, 1) NOT NULL,
    [cfm_file_id]             INT          NULL,
    [impairment]              VARCHAR (50) NULL,
    [value]                   CHAR (1)     NULL,
    [tenant_id]               INT          NULL,
    CONSTRAINT [PK_cfm_impairment_value] PRIMARY KEY CLUSTERED ([cfm_impairment_value_id] ASC) WITH (FILLFACTOR = 90)
);

