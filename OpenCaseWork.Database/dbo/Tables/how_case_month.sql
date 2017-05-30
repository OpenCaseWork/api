CREATE TABLE [dbo].[how_case_month] (
    [case_month_id]              INT           IDENTITY (1, 1) NOT NULL,
    [how_case_id]                INT           NOT NULL,
    [case_year]                  SMALLINT      NOT NULL,
    [case_month]                 SMALLINT      NOT NULL,
    [rate]                       FLOAT (53)    NOT NULL,
    [additional_fee]             FLOAT (53)    NULL,
    [additional_fee_description] VARCHAR (100) NULL,
    [total_amount]               FLOAT (53)    NULL,
    [credit_amount]              FLOAT (53)    NULL,
    [is_paid]                    CHAR (1)      NULL,
    [check_number]               VARCHAR (20)  NULL,
    [how_type_id]                INT           NOT NULL,
    [tenant_id]                  INT           NULL,
    CONSTRAINT [PK_how_case_month] PRIMARY KEY CLUSTERED ([how_case_id] ASC, [case_year] ASC, [case_month] ASC, [how_type_id] ASC) WITH (FILLFACTOR = 90)
);

