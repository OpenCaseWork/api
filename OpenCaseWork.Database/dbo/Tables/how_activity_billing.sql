CREATE TABLE [dbo].[how_activity_billing] (
    [how_activity_billing_id] INT           IDENTITY (1, 1) NOT NULL,
    [override_program_id]     INT           NULL,
    [notes]                   VARCHAR (250) NULL,
    [insert_date]             DATETIME      NULL,
    [update_date]             DATETIME      NULL,
    [insert_by]               VARCHAR (50)  NULL,
    [update_by]               VARCHAR (50)  NULL,
    [program_id]              INT           NULL,
    [pay_source_id]           INT           NULL,
    [billing_date]            DATETIME      NULL,
    [constituent_id]          INT           NULL,
    [revised_by]              VARCHAR (50)  NULL,
    [revised_date]            DATETIME      NULL,
    [how_case_day_id]         INT           NULL,
    [is_deleted]              BIT           NULL,
    [tenant_id]               INT           NULL,
    CONSTRAINT [PK_how_activity_billing] PRIMARY KEY CLUSTERED ([how_activity_billing_id] ASC) WITH (FILLFACTOR = 90)
);

