CREATE TABLE [dbo].[service_code_types] (
    [service_code_type_id] INT          IDENTITY (1, 1) NOT NULL,
    [service_type]         VARCHAR (50) NULL,
    [tenant_id]            INT          NULL
);

