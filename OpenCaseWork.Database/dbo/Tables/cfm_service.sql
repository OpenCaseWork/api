CREATE TABLE [dbo].[cfm_service] (
    [cfm_service_id]      INT           IDENTITY (1, 1) NOT NULL,
    [cfm_file_id]         INT           NULL,
    [service_code]        VARCHAR (200) NULL,
    [constituent_id]      INT           NULL,
    [billing_code]        VARCHAR (3)   NULL,
    [insert_date]         DATETIME      NULL,
    [insert_user]         VARCHAR (50)  NULL,
    [source_service_code] VARCHAR (300) NULL,
    [cfm_audit_id]        INT           NULL,
    [action_desc]         VARCHAR (200) NULL,
    [tenant_id]           INT           NULL
);

