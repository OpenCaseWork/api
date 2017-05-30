CREATE TABLE [dbo].[security_group] (
    [security_group_id]   INT           IDENTITY (1, 1) NOT NULL,
    [security_group_name] VARCHAR (100) NOT NULL,
    [tenant_id]           INT           NULL,
    CONSTRAINT [PK__security_group__11D4A34F] PRIMARY KEY NONCLUSTERED ([security_group_id] ASC) WITH (FILLFACTOR = 90)
);

