CREATE TABLE [dbo].[napis_group] (
    [napis_group_id]   INT          IDENTITY (1, 1) NOT NULL,
    [napis_group_name] VARCHAR (50) NULL,
    [tenant_id]        INT          NULL,
    CONSTRAINT [PK_napis_group] PRIMARY KEY CLUSTERED ([napis_group_id] ASC) WITH (FILLFACTOR = 90)
);

