CREATE TABLE [dbo].[security_right] (
    [security_right_id]   INT           IDENTITY (1, 1) NOT NULL,
    [security_right_name] VARCHAR (100) NOT NULL,
    [tenant_id]           INT           NULL,
    CONSTRAINT [PK__security_right__13BCEBC1] PRIMARY KEY NONCLUSTERED ([security_right_id] ASC) WITH (FILLFACTOR = 90)
);

