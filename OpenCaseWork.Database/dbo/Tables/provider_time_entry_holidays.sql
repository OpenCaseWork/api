CREATE TABLE [dbo].[provider_time_entry_holidays] (
    [provider_time_entry_holiday_id] INT          IDENTITY (1, 1) NOT NULL,
    [holiday_date]                   DATETIME     NULL,
    [created_date]                   DATETIME     NULL,
    [created_by]                     VARCHAR (50) NULL,
    [tenant_id]                      INT          NULL,
    CONSTRAINT [PK_provider_time_entry_holidays] PRIMARY KEY CLUSTERED ([provider_time_entry_holiday_id] ASC)
);

