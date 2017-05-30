CREATE TABLE [dbo].[child] (
    [child_id]       INT          IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (50) NULL,
    [birth_date]     DATETIME     NULL,
    [constituent_id] INT          NULL,
    [gender]         INT          NULL,
    [insert_date]    DATETIME     NULL,
    [insert_user]    CHAR (10)    NULL,
    [update_date]    DATETIME     NULL,
    [update_user]    CHAR (10)    NULL,
    [tenant_id]      INT          NULL,
    CONSTRAINT [PK_child] PRIMARY KEY CLUSTERED ([child_id] ASC) WITH (FILLFACTOR = 90)
);

