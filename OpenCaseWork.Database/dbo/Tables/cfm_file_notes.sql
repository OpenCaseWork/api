CREATE TABLE [dbo].[cfm_file_notes] (
    [cfm_file_notes_id] INT            IDENTITY (1, 1) NOT NULL,
    [cfm_file_id]       INT            NULL,
    [notes]             VARCHAR (1000) NULL,
    [insert_user]       VARCHAR (20)   NULL,
    [insert_date]       DATETIME       NULL,
    [file_status]       VARCHAR (50)   NULL,
    [tenant_id]         INT            NULL
);

