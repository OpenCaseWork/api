CREATE TABLE [dbo].[napis_intake_contact_event] (
    [CONTACT_EVENT_ID] INT            IDENTITY (1, 1) NOT NULL,
    [CONSTITUENT_ID]   INT            NOT NULL,
    [MINUTES]          FLOAT (53)     NOT NULL,
    [CONTACTS]         INT            NOT NULL,
    [SERVICE_CODE_ID]  INT            NULL,
    [PROVIDER_ID]      INT            NOT NULL,
    [EVENT_DATE]       DATETIME       NOT NULL,
    [SERVICE_DATE]     DATETIME       NULL,
    [CREATED_BY]       CHAR (10)      NULL,
    [CREATED_DATE]     DATETIME       NULL,
    [UPDATED_BY]       CHAR (10)      NULL,
    [UPDATED_DATE]     DATETIME       NULL,
    [NOTES]            VARCHAR (8000) NULL,
    [SERVICE_TYPE_ID]  INT            NULL,
    [NAPIS_INTAKE_ID]  INT            NOT NULL,
    [ACTION_PENDING]   BIT            NULL,
    [tenant_id]        INT            NULL,
    CONSTRAINT [PK__CONTACT_EVENT__7755B73D1] PRIMARY KEY NONCLUSTERED ([CONTACT_EVENT_ID] ASC) WITH (FILLFACTOR = 90)
);

