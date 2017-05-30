CREATE TABLE [dbo].[security_group_security_right] (
    [security_group_id] INT NOT NULL,
    [security_right_id] INT NOT NULL,
    [tenant_id]         INT NULL,
    CONSTRAINT [PK__security_group_s__178D7CA5] PRIMARY KEY NONCLUSTERED ([security_group_id] ASC, [security_right_id] ASC) WITH (FILLFACTOR = 90)
);

