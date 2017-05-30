CREATE TABLE [dbo].[provider_time_entry_type_hours] (
    [provider_time_entry_type_hours_id] INT        IDENTITY (1, 1) NOT NULL,
    [provider_time_entry_type_id]       INT        NOT NULL,
    [hours]                             FLOAT (53) NULL,
    [tenant_id]                         INT        NULL,
    CONSTRAINT [PK_provider_time_entry_type_hours] PRIMARY KEY CLUSTERED ([provider_time_entry_type_hours_id] ASC) WITH (FILLFACTOR = 90)
);

