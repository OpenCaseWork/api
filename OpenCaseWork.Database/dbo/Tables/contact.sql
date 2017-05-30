CREATE TABLE [dbo].[contact] (
    [contact_id]      INT           IDENTITY (1, 1) NOT NULL,
    [parent_id]       INT           NOT NULL,
    [contact_type_id] INT           NOT NULL,
    [contact_text]    VARCHAR (100) NULL,
    [contact_text_2]  VARCHAR (50)  NULL,
    [created_date]    DATETIME      NULL,
    [created_by]      VARCHAR (50)  NULL,
    [updated_date]    DATETIME      NULL,
    [updated_by]      VARCHAR (50)  NULL,
    [contact_notes]   VARCHAR (100) NULL,
    [extension]       VARCHAR (10)  NULL,
    CONSTRAINT [PK_contact] PRIMARY KEY CLUSTERED ([contact_id] ASC) WITH (FILLFACTOR = 90)
);

