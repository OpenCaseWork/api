﻿CREATE TABLE [dbo].[SERVICE_CODES] (
    [SERVICE_CODE_ID]          INT           IDENTITY (96, 1) NOT NULL,
    [SERVICE_CODE]             INT           NOT NULL,
    [SERVICE_TYPE]             VARCHAR (50)  NOT NULL,
    [SERVICE_DESCRIPTION]      VARCHAR (50)  NOT NULL,
    [ACTIVE]                   CHAR (1)      NULL,
    [UNITED_WAY_CATEGORY]      VARCHAR (20)  NULL,
    [CAREGIVER]                CHAR (1)      NULL,
    [SERVICE_CODE_PARENT_CODE] INT           NULL,
    [TITLE3_CATEGORY]          VARCHAR (50)  NULL,
    [AGE_OPTIONS_CATEGORY]     VARCHAR (50)  NULL,
    [WEEKLY_BLUE_SHEET]        CHAR (1)      NULL,
    [IS_SUBCODE]               CHAR (1)      NULL,
    [SERVICE_TYPE_GROUP_ID]    INT           NULL,
    [Notes]                    VARCHAR (500) NULL,
    [AGE_OPTIONS_CATEGORY_2]   VARCHAR (50)  NULL,
    [AGE_OPTIONS_CATEGORY_3]   VARCHAR (50)  NULL,
    [AO_CAREGIVER_REQUIRED]    CHAR (1)      NULL,
    [tenant_id]                INT           NULL,
    CONSTRAINT [PK__SERVICE_CODES__0E391C95] PRIMARY KEY NONCLUSTERED ([SERVICE_CODE_ID] ASC) WITH (FILLFACTOR = 90)
);

