CREATE TABLE [dbo].[mco_vendor] (
    [mco_vendor_id]   INT          IDENTITY (1, 1) NOT NULL,
    [mco_vendor_name] VARCHAR (50) NULL,
    [is_active]       CHAR (1)     NULL,
    [tenant_id]       INT          NULL
);

