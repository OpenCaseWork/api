CREATE TABLE [dbo].[geriatric_case_billing_detail] (
    [geriatric_case_billing_detail_id] INT           IDENTITY (1, 1) NOT NULL,
    [geriatric_case_billing_item_id]   INT           NOT NULL,
    [detail_date]                      DATETIME      NULL,
    [detail_service_id]                INT           NULL,
    [detail_minutes]                   INT           NULL,
    [detail_amount]                    MONEY         NULL,
    [detail_type_id]                   INT           NULL,
    [detail_description]               VARCHAR (100) NULL,
    [detail_hourly_rate]               INT           NULL,
    [detail_pm_hourly_rate]            INT           NULL,
    [tenant_id]                        INT           NULL
);

