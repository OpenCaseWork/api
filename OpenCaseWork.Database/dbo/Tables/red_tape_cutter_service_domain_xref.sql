CREATE TABLE [dbo].[red_tape_cutter_service_domain_xref] (
    [xref_id]      INT          IDENTITY (1, 1) NOT NULL,
    [service_code] VARCHAR (50) NULL,
    [service_id]   INT          NULL,
    [tenant_id]    INT          NULL
);

