CREATE TABLE [dbo].[how_billing_month] (
    [how_billing_month_id] INT          IDENTITY (1, 1) NOT NULL,
    [month]                INT          NULL,
    [year]                 INT          NULL,
    [is_frozen]            BIT          NULL,
    [insert_user]          VARCHAR (10) NULL,
    [update_user]          VARCHAR (10) NULL,
    [insert_date]          DATETIME     NULL,
    [update_date]          DATETIME     NULL,
    [tenant_id]            INT          NULL,
    CONSTRAINT [PK_how_billing_month] PRIMARY KEY CLUSTERED ([how_billing_month_id] ASC)
);

