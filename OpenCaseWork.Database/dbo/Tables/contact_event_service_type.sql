CREATE TABLE [dbo].[contact_event_service_type] (
    [contact_event_service_type_id] INT           IDENTITY (1, 1) NOT NULL,
    [contact_event_id]              INT           NOT NULL,
    [service_type_id]               INT           NULL,
    [update_dt]                     DATETIME      NULL,
    [update_by]                     VARCHAR (10)  NULL,
    [other_description]             VARCHAR (100) NULL,
    [insert_dt]                     DATETIME      NULL,
    [tenant_id]                     INT           NULL
);

