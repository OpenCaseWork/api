CREATE TABLE [dbo].[service_types] (
    [service_type_id]           INT          IDENTITY (1, 1) NOT NULL,
    [service_type_name]         VARCHAR (50) NULL,
    [service_type_abbreviation] VARCHAR (50) NOT NULL,
    [type]                      VARCHAR (50) NULL,
    [active]                    CHAR (1)     NULL,
    [report_category]           VARCHAR (50) NULL,
    [sequence]                  INT          NULL,
    [tenant_id]                 INT          NULL
);

