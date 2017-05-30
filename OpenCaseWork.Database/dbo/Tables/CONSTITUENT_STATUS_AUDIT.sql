﻿CREATE TABLE [dbo].[CONSTITUENT_STATUS_AUDIT] (
    [CONSTITUENT_STAUS_AUDIT_ID] INT       IDENTITY (1, 1) NOT NULL,
    [UNQ_ID]                     INT       NOT NULL,
    [CONSTITUENT_ID]             INT       NOT NULL,
    [CONSTITUENT_TYPE_CODE]      CHAR (2)  NULL,
    [START_DATE]                 DATETIME  NULL,
    [END_DATE]                   DATETIME  NULL,
    [CONSTITUENT_TYPE_ID]        INT       NULL,
    [CREATED_BY]                 CHAR (10) NULL,
    [CREATED_DATE]               DATETIME  NULL,
    [UPDATED_BY]                 CHAR (10) NULL,
    [UPDATED_DATE]               DATETIME  NULL,
    [AUDIT_BY]                   CHAR (10) NULL,
    [AUDIT_TYPE]                 CHAR (1)  NULL,
    [AUDIT_DATE]                 DATETIME  NULL,
    [tenant_id]                  INT       NULL
);

