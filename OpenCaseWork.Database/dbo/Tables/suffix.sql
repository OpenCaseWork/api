﻿CREATE TABLE [dbo].[suffix] (
    [SUFFIX_ID]   SMALLINT     IDENTITY (1, 1) NOT NULL,
    [SUFFIX_TEXT] VARCHAR (20) NOT NULL,
    [tenant_id]   INT          NULL,
    CONSTRAINT [PK__SUFFIX__44952D46] PRIMARY KEY NONCLUSTERED ([SUFFIX_ID] ASC) WITH (FILLFACTOR = 90)
);

