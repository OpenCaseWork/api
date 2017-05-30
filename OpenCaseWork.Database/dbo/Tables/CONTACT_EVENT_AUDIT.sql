CREATE TABLE [dbo].[CONTACT_EVENT_AUDIT] (
    [CONTACT_EVENT_AUDIT_ID]     INT        IDENTITY (1, 1) NOT NULL,
    [CONTACT_EVENT_ID]           INT        NOT NULL,
    [CONSTITUENT_ID]             INT        NOT NULL,
    [MINUTES]                    FLOAT (53) NOT NULL,
    [CONTACTS]                   INT        NOT NULL,
    [SERVICE_CODE_ID]            INT        NULL,
    [PROVIDER_ID]                INT        NULL,
    [EVENT_DATE]                 DATETIME   NULL,
    [SERVICE_DATE]               DATETIME   NULL,
    [SOURCE]                     INT        NULL,
    [GERIATRIC_CASE_EXPORT_FLAG] CHAR (1)   NULL,
    [CREATED_BY]                 CHAR (10)  NULL,
    [CREATED_DATE]               DATETIME   NULL,
    [UPDATED_BY]                 CHAR (10)  NULL,
    [UPDATED_DATE]               DATETIME   NULL,
    [AUDIT_TYPE]                 CHAR (1)   NULL,
    [AUDIT_BY]                   CHAR (10)  NULL,
    [AUDIT_DATE]                 DATETIME   NULL,
    [tenant_id]                  INT        NULL
);

