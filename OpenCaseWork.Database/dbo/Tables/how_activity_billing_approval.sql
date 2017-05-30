CREATE TABLE [dbo].[how_activity_billing_approval] (
    [how_activity_billing_approval_id] INT          IDENTITY (1, 1) NOT NULL,
    [billing_date]                     DATETIME     NULL,
    [approval_by]                      VARCHAR (50) NULL,
    [approval_date]                    DATETIME     NULL,
    [complete_by]                      VARCHAR (50) NULL,
    [complete_date]                    DATETIME     NULL,
    [tenant_id]                        INT          NULL,
    CONSTRAINT [PK_how_activity_billing_approval] PRIMARY KEY CLUSTERED ([how_activity_billing_approval_id] ASC) WITH (FILLFACTOR = 90)
);

