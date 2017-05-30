CREATE TABLE [dbo].[CONTACT_EVENT_ENTRY_WEEK] (
    [CONTACT_EVENT_ENTRY_WEEK_ID] INT       IDENTITY (1, 1) NOT NULL,
    [PROVIDER_ID]                 INT       NOT NULL,
    [WEEK_ID]                     INT       NOT NULL,
    [CREATED_BY]                  CHAR (10) NULL,
    [CREATED_DATE]                DATETIME  NULL,
    [UPDATED_BY]                  CHAR (10) NULL,
    [UPDATED_DATE]                DATETIME  NULL,
    [APPROVED_BY]                 CHAR (10) NULL,
    [APPROVED]                    CHAR (1)  NULL,
    [APPROVED_DATE]               DATETIME  NULL,
    [SUBMITTED_DATE]              DATETIME  NULL,
    [tenant_id]                   INT       NULL,
    CONSTRAINT [PK_CONTACT_EVENT_ENTRY_WEEK] PRIMARY KEY CLUSTERED ([CONTACT_EVENT_ENTRY_WEEK_ID] ASC) WITH (FILLFACTOR = 90)
);

