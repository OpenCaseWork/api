CREATE TABLE [dbo].[user] (
    [user_id]        INT           IDENTITY (1, 1) NOT NULL,
    [first_name]     VARCHAR (100) NULL,
    [last_name]      VARCHAR (100) NULL,
    [constituent_id] INT           NULL,
    [user_name]      VARCHAR (20)  NULL,
    [password]       VARCHAR (8)   NULL,
    [location_id]    INT           NULL,
    [logon_location] CHAR (1)      NULL,
    [nt_user_id]     VARCHAR (20)  NULL,
    [tenant_id]      INT           NULL,
    CONSTRAINT [PK__user__0FEC5ADD] PRIMARY KEY NONCLUSTERED ([user_id] ASC) WITH (FILLFACTOR = 90)
);

