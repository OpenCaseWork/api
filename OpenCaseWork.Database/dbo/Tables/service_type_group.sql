CREATE TABLE [dbo].[service_type_group] (
    [service_type_group_id] INT          IDENTITY (1, 1) NOT NULL,
    [group_name]            VARCHAR (50) NULL,
    [tenant_id]             INT          NULL,
    CONSTRAINT [PK_service_type_group] PRIMARY KEY CLUSTERED ([service_type_group_id] ASC) WITH (FILLFACTOR = 90)
);

