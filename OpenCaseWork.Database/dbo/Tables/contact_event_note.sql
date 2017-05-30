CREATE TABLE [dbo].[contact_event_note] (
    [contact_event_note_id] INT            IDENTITY (1, 1) NOT NULL,
    [contact_event_id]      INT            NOT NULL,
    [note]                  VARCHAR (8000) NULL,
    [insert_date]           DATETIME       NOT NULL,
    [update_date]           DATETIME       NOT NULL,
    [insert_user]           CHAR (10)      NOT NULL,
    [update_user]           CHAR (10)      NOT NULL,
    [tenant_id]             INT            NULL,
    CONSTRAINT [PK_contact_event_note] PRIMARY KEY CLUSTERED ([contact_event_note_id] ASC) WITH (FILLFACTOR = 90)
);

