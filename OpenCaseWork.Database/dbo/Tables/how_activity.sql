CREATE TABLE [dbo].[how_activity] (
    [how_activity_id]    INT          IDENTITY (1, 1) NOT NULL,
    [activity_name]      VARCHAR (50) NULL,
    [is_active]          CHAR (1)     NULL,
    [default_program_id] INT          NULL,
    [tenant_id]          INT          NULL,
    CONSTRAINT [PK_how_activity] PRIMARY KEY CLUSTERED ([how_activity_id] ASC) WITH (FILLFACTOR = 90)
);

