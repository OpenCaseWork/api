CREATE TABLE [dbo].[respite_statement] (
    [respite_statement_id]     INT      IDENTITY (1, 1) NOT NULL,
    [respite_event_id]         INT      NOT NULL,
    [respite_check_request_id] INT      NOT NULL,
    [print_date]               DATETIME NULL,
    [created_date]             DATETIME NULL,
    [tenant_id]                INT      NULL,
    CONSTRAINT [PK_respite_statement] PRIMARY KEY CLUSTERED ([respite_statement_id] ASC) WITH (FILLFACTOR = 90)
);

