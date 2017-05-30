CREATE TABLE [dbo].[cfm_adl_value] (
    [cfm_adl_id]  INT          IDENTITY (1, 1) NOT NULL,
    [cfm_file_id] INT          NOT NULL,
    [type]        VARCHAR (50) NULL,
    [a_value]     VARCHAR (10) NULL,
    [b_value]     VARCHAR (10) NULL,
    [name]        VARCHAR (50) NULL,
    [tenant_id]   INT          NULL,
    CONSTRAINT [PK_cfm_adl_value] PRIMARY KEY CLUSTERED ([cfm_adl_id] ASC) WITH (FILLFACTOR = 90)
);

