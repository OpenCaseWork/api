CREATE TABLE [dbo].[provider_time_entry_type] (
    [provider_time_entry_type_id] INT          IDENTITY (1, 1) NOT NULL,
    [description]                 VARCHAR (50) NULL,
    [is_non_work]                 INT          NULL,
    [tenant_id]                   INT          NULL,
    CONSTRAINT [PK_provider_time_entry_type] PRIMARY KEY CLUSTERED ([provider_time_entry_type_id] ASC) WITH (FILLFACTOR = 90)
);

