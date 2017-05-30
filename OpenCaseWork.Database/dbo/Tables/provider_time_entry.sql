CREATE TABLE [dbo].[provider_time_entry] (
    [provider_time_entry_id] INT            IDENTITY (1, 1) NOT NULL,
    [provider_id]            INT            NOT NULL,
    [event_date]             DATETIME       NULL,
    [time_entry_type_id]     INT            NOT NULL,
    [hours]                  FLOAT (53)     NULL,
    [createdt]               DATETIME       NULL,
    [updatedt]               DATETIME       NULL,
    [create_userid]          VARCHAR (10)   NULL,
    [update_userid]          VARCHAR (10)   NULL,
    [service_code_id]        INT            NULL,
    [notes]                  VARCHAR (1000) NULL,
    [minutes]                INT            NULL,
    [tenant_id]              INT            NULL,
    CONSTRAINT [PK_provider_time_entry] PRIMARY KEY CLUSTERED ([provider_time_entry_id] ASC) WITH (FILLFACTOR = 90)
);

