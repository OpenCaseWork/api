CREATE TABLE [dbo].[how_fee] (
    [how_fee_id]        INT      IDENTITY (1, 1) NOT NULL,
    [fee_amount]        MONEY    NULL,
    [how_fee_type_id]   INT      NULL,
    [how_fee_date]      DATETIME NULL,
    [how_case_month_id] INT      NULL,
    [tenant_id]         INT      NULL
);

