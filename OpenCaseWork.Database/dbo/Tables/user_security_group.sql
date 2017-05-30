CREATE TABLE [dbo].[user_security_group] (
    [user_security_group_id] INT IDENTITY (1, 1) NOT NULL,
    [user_id]                INT NULL,
    [security_group_id]      INT NULL,
    [tenant_id]              INT NULL,
    CONSTRAINT [PK_user_security_group] PRIMARY KEY CLUSTERED ([user_security_group_id] ASC) WITH (FILLFACTOR = 90)
);

