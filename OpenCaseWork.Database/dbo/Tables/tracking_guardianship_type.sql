﻿CREATE TABLE [dbo].[tracking_guardianship_type] (
    [code_id]   INT          IDENTITY (1, 1) NOT NULL,
    [code_text] VARCHAR (50) NULL,
    [active]    CHAR (1)     NULL,
    [tenant_id] INT          NULL,
    CONSTRAINT [PK_tracking_guardianship_type] PRIMARY KEY CLUSTERED ([code_id] ASC) WITH (FILLFACTOR = 90)
);

