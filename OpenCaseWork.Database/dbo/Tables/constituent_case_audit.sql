CREATE TABLE [dbo].[constituent_case_audit] (
    [CONSTITUENT_CASE_AUDIT_ID] INT          IDENTITY (1, 1) NOT NULL,
    [CASE_ID]                   INT          NOT NULL,
    [CONSTITUENT_ID]            INT          NOT NULL,
    [PROVIDER_ID]               INT          NOT NULL,
    [PROVIDER_NUMBER]           INT          NOT NULL,
    [DATE_OPEN]                 DATETIME     NULL,
    [DATE_CLOSED]               DATETIME     NULL,
    [OPEN_FLAG]                 CHAR (1)     NULL,
    [REASON_FOR_CLOSE]          INT          NULL,
    [REASON_FOR_CLOSE_NAME]     VARCHAR (50) NULL,
    [INSERT_DATE]               DATETIME     NULL,
    [INSERT_USER]               VARCHAR (50) NULL,
    [UPDATE_DATE]               DATETIME     NULL,
    [UPDATE_USER]               VARCHAR (50) NULL,
    [AUDIT_BY]                  CHAR (10)    NULL,
    [AUDIT_DATE]                DATETIME     NULL,
    [AUDIT_TYPE]                CHAR (1)     NULL,
    [tenant_id]                 INT          NULL
);

