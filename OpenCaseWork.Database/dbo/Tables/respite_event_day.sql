CREATE TABLE [dbo].[respite_event_day] (
    [respite_event_day_id] INT          IDENTITY (1, 1) NOT NULL,
    [respite_event_id]     INT          NULL,
    [agency_rate_id]       INT          NULL,
    [rate]                 FLOAT (53)   NULL,
    [hours]                FLOAT (53)   NULL,
    [agency_worker]        VARCHAR (50) NULL,
    [amount]               FLOAT (53)   NULL,
    [created_by]           CHAR (20)    NULL,
    [created_date]         DATETIME     NULL,
    [updated_by]           CHAR (20)    NULL,
    [updated_date]         DATETIME     NULL,
    [service_date]         DATETIME     NULL,
    [tenant_id]            INT          NULL,
    CONSTRAINT [PK_respite_event_day] PRIMARY KEY NONCLUSTERED ([respite_event_day_id] ASC) WITH (FILLFACTOR = 90)
);

