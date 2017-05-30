CREATE TABLE [dbo].[cfm_ccp_service] (
    [cfm_ccp_service_id] INT          IDENTITY (1, 1) NOT NULL,
    [cfm_file_id]        INT          NULL,
    [service_date]       DATETIME     NULL,
    [type]               VARCHAR (50) NULL,
    [units_per_month]    VARCHAR (50) NULL,
    [provider]           VARCHAR (50) NULL,
    [tenant_id]          INT          NULL,
    CONSTRAINT [PK_cfm_ccp_service] PRIMARY KEY CLUSTERED ([cfm_ccp_service_id] ASC) WITH (FILLFACTOR = 90)
);

