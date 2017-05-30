CREATE TABLE [dbo].[constituent_how_program] (
    [constituent_how_program_id] INT      IDENTITY (1, 1) NOT NULL,
    [constituent_id]             INT      NOT NULL,
    [how_program_id]             INT      NOT NULL,
    [first_call_date]            DATETIME NULL,
    [first_day_date]             DATETIME NULL,
    [close_date]                 DATETIME NULL,
    [close_reason]               INT      NULL,
    [referral_source]            INT      NULL,
    [tenant_id]                  INT      NULL
);

