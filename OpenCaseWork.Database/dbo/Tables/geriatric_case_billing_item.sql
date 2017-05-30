CREATE TABLE [dbo].[geriatric_case_billing_item] (
    [geriatric_case_billing_item_id] INT          IDENTITY (1, 1) NOT NULL,
    [geriatric_case_id]              INT          NULL,
    [billing_month]                  INT          NULL,
    [billing_year]                   CHAR (10)    NULL,
    [assessment]                     MONEY        NULL,
    [professional_fees]              MONEY        NULL,
    [pass_thru]                      MONEY        NULL,
    [total]                          MONEY        NULL,
    [is_paid]                        CHAR (5)     NULL,
    [hourly_rate]                    INT          NULL,
    [check_number]                   VARCHAR (20) NULL,
    [pm_hourly_rate]                 INT          NULL,
    [auto_generated]                 CHAR (1)     NULL,
    [tenant_id]                      INT          NULL
);

