CREATE TABLE [dbo].[service_type_group_relations] (
    [service_type_group_relation_id] INT IDENTITY (1, 1) NOT NULL,
    [service_type_id]                INT NULL,
    [service_type_group_id]          INT NULL,
    [tenant_id]                      INT NULL,
    CONSTRAINT [PK_service_type_group_relations] PRIMARY KEY CLUSTERED ([service_type_group_relation_id] ASC) WITH (FILLFACTOR = 90)
);

