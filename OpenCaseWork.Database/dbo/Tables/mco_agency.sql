CREATE TABLE [dbo].[mco_agency] (
    [mco_agency_id] INT          IDENTITY (1, 1) NOT NULL,
    [agency_name]   VARCHAR (50) NULL,
    [active]        BIT          NULL,
    [tenant_id]     INT          NULL
);

