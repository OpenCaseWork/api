CREATE TABLE [dbo].[provider_service_types] (
    [provider_service_type_id] INT          NULL,
    [name]                     VARCHAR (50) NULL,
    [display_name]             VARCHAR (50) NULL,
    [active]                   CHAR (1)     NULL,
    [is_napis]                 CHAR (1)     NULL,
    [tenant_id]                INT          NULL
);

