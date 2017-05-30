CREATE TABLE [dbo].[constituent_tracking_program] (
    [constituent_tracking_program_id] INT IDENTITY (1, 1) NOT NULL,
    [constituent_id]                  INT NULL,
    [code_id]                         INT NULL,
    [program_type_id]                 INT NULL,
    [tenant_id]                       INT NULL,
    CONSTRAINT [PK_constituent_svss_program] PRIMARY KEY CLUSTERED ([constituent_tracking_program_id] ASC) WITH (FILLFACTOR = 90)
);

