CREATE TABLE [dbo].[respite_event] (
    [respite_event_id]        INT        IDENTITY (1, 1) NOT NULL,
    [respite_event_class_id]  INT        NULL,
    [respite_event_type_id]   INT        NULL,
    [respite_category_id]     INT        NULL,
    [provider_id]             INT        NULL,
    [constituent_id]          INT        NULL,
    [agency_id]               INT        NULL,
    [respite_event_amount]    FLOAT (53) NULL,
    [respite_event_hours]     FLOAT (53) NULL,
    [respite_event_status_id] INT        NULL,
    [created_date]            DATETIME   NULL,
    [created_by]              CHAR (20)  NULL,
    [reviewed_date]           DATETIME   NULL,
    [reviewed_by]             CHAR (20)  NULL,
    [paid_date]               DATETIME   NULL,
    [paid_by]                 CHAR (20)  NULL,
    [fiscal_year_id]          INT        NULL,
    [location_id]             INT        NULL,
    [first_date]              DATETIME   NULL,
    [tenant_id]               INT        NULL,
    CONSTRAINT [PK_respite_event] PRIMARY KEY NONCLUSTERED ([respite_event_id] ASC) WITH (FILLFACTOR = 90)
);

