﻿CREATE TABLE [dbo].[TOWNSHIP] (
    [township_id]   INT           IDENTITY (1, 1) NOT NULL,
    [TOWNSHIP_CODE] CHAR (1)      NOT NULL,
    [TOWNSHIP_NAME] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK__TOWNSHIP__2DB1C7EE] PRIMARY KEY NONCLUSTERED ([township_id] ASC) WITH (FILLFACTOR = 90)
);

