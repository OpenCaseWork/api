CREATE TABLE [dbo].[constituent_notes] (
    [constituent_note_id] INT           IDENTITY (1, 1) NOT NULL,
    [constituent_id]      INT           NOT NULL,
    [notes]               VARCHAR (200) NULL,
    [created_by]          VARCHAR (50)  NULL,
    [created_date]        DATETIME      NOT NULL,
    [updated_by]          VARCHAR (50)  NULL,
    [updated_date]        DATETIME      NOT NULL,
    CONSTRAINT [PK_constituent_notes] PRIMARY KEY CLUSTERED ([constituent_note_id] ASC) WITH (FILLFACTOR = 90)
);

