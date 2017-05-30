CREATE TABLE [dbo].[how_activity_program] (
    [how_activity_program_id] INT          NOT NULL,
    [program_name]            VARCHAR (50) NULL,
    [program_type_id]         INT          NULL,
    [sort_order]              INT          NULL,
    [active]                  CHAR (1)     NULL,
    [tenant_id]               INT          NULL,
    CONSTRAINT [PK_how_activity_program] PRIMARY KEY CLUSTERED ([how_activity_program_id] ASC) WITH (FILLFACTOR = 90)
);

