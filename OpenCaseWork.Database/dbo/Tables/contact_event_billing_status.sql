CREATE TABLE [dbo].[contact_event_billing_status] (
    [contact_event_billing_status_id] INT          IDENTITY (1, 1) NOT NULL,
    [billing_status]                  VARCHAR (50) NULL,
    [billing_status_date]             DATETIME     NULL,
    [contact_event_id]                INT          NOT NULL,
    [update_user_name]                VARCHAR (50) NULL,
    [event_provider_location]         VARCHAR (3)  NULL,
    [event_contract_code]             CHAR (3)     NULL,
    [tenant_id]                       INT          NULL,
    CONSTRAINT [PK_contact_event_billing_status] PRIMARY KEY CLUSTERED ([contact_event_billing_status_id] ASC) WITH (FILLFACTOR = 90)
);

