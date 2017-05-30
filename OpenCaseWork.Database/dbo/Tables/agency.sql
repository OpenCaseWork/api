CREATE TABLE [dbo].[agency] (
    [agency_id]             INT           IDENTITY (1, 1) NOT NULL,
    [agency_name]           VARCHAR (100) NULL,
    [agency_contact_person] VARCHAR (100) NULL,
    [agency_address]        VARCHAR (100) NULL,
    [agency_city]           VARCHAR (50)  NULL,
    [agency_phone]          CHAR (10)     NULL,
    [agency_fax]            CHAR (10)     NULL,
    [agency_state]          CHAR (2)      NULL,
    [agency_zip]            CHAR (9)      NULL,
    [is_active]             CHAR (1)      NULL,
    [tenant_id]             INT           NULL,
    CONSTRAINT [PK_agency] PRIMARY KEY NONCLUSTERED ([agency_id] ASC) WITH (FILLFACTOR = 90)
);

