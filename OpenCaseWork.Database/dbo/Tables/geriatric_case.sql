CREATE TABLE [dbo].[geriatric_case] (
    [geriatric_case_id]        INT           IDENTITY (1, 1) NOT NULL,
    [provider_id]              INT           NULL,
    [constituent_id]           INT           NULL,
    [bill_to]                  VARCHAR (100) NULL,
    [address]                  VARCHAR (100) NULL,
    [city]                     VARCHAR (100) NULL,
    [state]                    CHAR (2)      NULL,
    [zip_code]                 CHAR (5)      NULL,
    [zip_code_4]               CHAR (4)      NULL,
    [active]                   INT           NULL,
    [address_2]                VARCHAR (100) NULL,
    [provider_credentials]     VARCHAR (50)  NULL,
    [secondary_constituent_id] INT           NULL,
    [tenant_id]                INT           NULL
);

