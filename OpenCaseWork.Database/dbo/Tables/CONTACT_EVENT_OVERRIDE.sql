﻿CREATE TABLE [dbo].[CONTACT_EVENT_OVERRIDE] (
    [ID]                  INT           IDENTITY (1, 1) NOT NULL,
    [CONTACT_EVENT_ID]    INT           NULL,
    [CONSTITUENT_ID]      INT           NOT NULL,
    [OLD_CONSTITUENT_ID]  INT           NOT NULL,
    [MINUTES]             FLOAT (53)    NOT NULL,
    [OLD_MINUTES]         FLOAT (53)    NOT NULL,
    [CONTACTS]            INT           NOT NULL,
    [OLD_CONTACTS]        INT           NOT NULL,
    [SERVICE_CODE_ID]     INT           NULL,
    [OLD_SERVICE_CODE_ID] INT           NULL,
    [PROVIDER_ID]         INT           NOT NULL,
    [OLD_PROVIDER_ID]     INT           NOT NULL,
    [EVENT_DATE]          DATETIME      NOT NULL,
    [OLD_EVENT_DATE]      DATETIME      NOT NULL,
    [SERVICE_DATE]        DATETIME      NULL,
    [OLD_SERVICE_DATE]    DATETIME      NULL,
    [SERVICE_TYPE_ID]     INT           NULL,
    [OVERRIDE_REASON]     VARCHAR (300) NULL,
    [OLD_SERVICE_TYPE_ID] INT           NULL,
    [CREATED_BY]          CHAR (10)     NULL,
    [CREATED_DATE]        DATETIME      NULL,
    [UPDATED_BY]          CHAR (10)     NULL,
    [UPDATED_DATE]        DATETIME      NULL,
    [tenant_id]           INT           NULL
);
