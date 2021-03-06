﻿CREATE TABLE [dbo].[MINORITY] (
    [MINORITY_CODE]         CHAR (1)     NOT NULL,
    [MINORITY_TYPE]         VARCHAR (50) NOT NULL,
    [MINORITY_ID]           INT          IDENTITY (1, 1) NOT NULL,
    [BA_REPORT_DESCRIPTION] VARCHAR (50) NULL,
    [IS_ACTIVE]             CHAR (1)     NULL,
    [HARMONY_DESCRIPTION]   VARCHAR (50) NULL,
    [tenant_id]             INT          NULL,
    CONSTRAINT [PK__MINORITY__40C49C62] PRIMARY KEY NONCLUSTERED ([MINORITY_ID] ASC) WITH (FILLFACTOR = 90)
);

