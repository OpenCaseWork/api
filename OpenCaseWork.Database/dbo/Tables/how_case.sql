CREATE TABLE [dbo].[how_case] (
    [how_case_id]    INT           IDENTITY (1, 1) NOT NULL,
    [constituent_id] INT           NOT NULL,
    [bill_to]        VARCHAR (100) NULL,
    [address]        VARCHAR (100) NULL,
    [address_2]      VARCHAR (100) NULL,
    [city]           VARCHAR (100) NULL,
    [state]          CHAR (2)      NULL,
    [zip_code]       CHAR (5)      NULL,
    [zip_code_4]     CHAR (4)      NULL,
    [active]         SMALLINT      NULL,
    [billing_rate]   FLOAT (53)    NULL,
    [how_type_id]    INT           NULL,
    [tenant_id]      INT           NULL
);

