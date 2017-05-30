CREATE TABLE [dbo].[gap_fill_statement] (
    [gap_fill_statement_id]     INT      IDENTITY (1, 1) NOT NULL,
    [respite_event_gap_fill_id] INT      NULL,
    [gap_fill_check_request_id] INT      NULL,
    [print_date]                DATETIME NULL,
    [created_date]              DATETIME NULL,
    [tenant_id]                 INT      NULL,
    CONSTRAINT [PK_gap_fill_statement] PRIMARY KEY CLUSTERED ([gap_fill_statement_id] ASC) WITH (FILLFACTOR = 90)
);

