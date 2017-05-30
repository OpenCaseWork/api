﻿CREATE TABLE [dbo].[CONTACT_EVENT] (
    [CONTACT_EVENT_ID]           INT        IDENTITY (1, 1) NOT NULL,
    [CONSTITUENT_ID]             INT        NOT NULL,
    [MINUTES]                    FLOAT (53) NOT NULL,
    [CONTACTS]                   INT        NOT NULL,
    [SERVICE_CODE_ID]            INT        NULL,
    [PROVIDER_ID]                INT        NOT NULL,
    [EVENT_DATE]                 DATETIME   NOT NULL,
    [SERVICE_DATE]               DATETIME   NULL,
    [SOURCE]                     INT        NULL,
    [GERIATRIC_CASE_EXPORT_FLAG] CHAR (1)   NULL,
    [CREATED_BY]                 CHAR (10)  NULL,
    [CREATED_DATE]               DATETIME   NULL,
    [UPDATED_BY]                 CHAR (10)  NULL,
    [UPDATED_DATE]               DATETIME   NULL,
    [FACE_TO_FACE]               CHAR (1)   NULL,
    [TRANSACTION_ID]             INT        NOT NULL,
    [tenant_id]                  INT        NULL,
    CONSTRAINT [PK__CONTACT_EVENT__7755B73D] PRIMARY KEY NONCLUSTERED ([CONTACT_EVENT_ID] ASC) WITH (FILLFACTOR = 90)
);

