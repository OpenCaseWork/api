CREATE TABLE [dbo].[how_activity_billing_fee] (
    [how_activity_billing_fee_id] INT          IDENTITY (1, 1) NOT NULL,
    [type_id]                     INT          NULL,
    [amount]                      MONEY        NULL,
    [description]                 VARCHAR (50) NULL,
    [is_selected]                 BIT          NULL,
    [how_activity_billing_id]     INT          NOT NULL,
    [old_fee_id]                  INT          NULL,
    [tenant_id]                   INT          NULL,
    CONSTRAINT [PK_how_activity_biling_fee] PRIMARY KEY CLUSTERED ([how_activity_billing_fee_id] ASC)
);

