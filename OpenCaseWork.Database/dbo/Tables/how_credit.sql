CREATE TABLE [dbo].[how_credit] (
    [how_credit_id]      INT      IDENTITY (1, 1) NOT NULL,
    [credit_amount]      MONEY    NULL,
    [how_credit_type_id] INT      NULL,
    [how_credit_date]    DATETIME NULL,
    [how_case_month_id]  INT      NULL,
    [tenant_id]          INT      NULL,
    CONSTRAINT [PK_how_credit] PRIMARY KEY CLUSTERED ([how_credit_id] ASC) WITH (FILLFACTOR = 90)
);

