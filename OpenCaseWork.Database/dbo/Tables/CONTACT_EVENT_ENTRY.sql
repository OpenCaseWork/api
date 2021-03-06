﻿CREATE TABLE [dbo].[CONTACT_EVENT_ENTRY] (
    [CONTACT_EVENT_ENTRY_ID]      INT           IDENTITY (1, 1) NOT NULL,
    [CONSTITUENT_ID]              INT           NOT NULL,
    [MINUTES]                     FLOAT (53)    NOT NULL,
    [CONTACTS]                    INT           NOT NULL,
    [SERVICE_CODE_ID]             INT           NULL,
    [PROVIDER_ID]                 INT           NOT NULL,
    [EVENT_DATE]                  DATETIME      NOT NULL,
    [SERVICE_DATE]                DATETIME      NULL,
    [ITEM_DATE]                   DATETIME      NULL,
    [WEEK_ID]                     INT           NULL,
    [CREATED_BY]                  CHAR (10)     NULL,
    [CREATED_DATE]                DATETIME      NULL,
    [UPDATED_BY]                  CHAR (10)     NULL,
    [UPDATED_DATE]                DATETIME      NULL,
    [FACE_TO_FACE]                CHAR (1)      NULL,
    [APPROVED]                    CHAR (1)      NULL,
    [APRPOVED_DATE]               DATETIME      NULL,
    [CONTACT_EVENT_ID]            INT           NULL,
    [COMMENT]                     VARCHAR (250) NULL,
    [CONTACT_EVENT_ENTRY_WEEK_ID] INT           NULL,
    [tenant_id]                   INT           NULL,
    CONSTRAINT [PK_CONTACT_EVENT_ENTRY] PRIMARY KEY CLUSTERED ([CONTACT_EVENT_ENTRY_ID] ASC) WITH (FILLFACTOR = 90)
);

