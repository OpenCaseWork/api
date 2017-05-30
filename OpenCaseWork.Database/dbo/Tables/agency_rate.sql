CREATE TABLE [dbo].[agency_rate] (
    [agency_rate_id]   INT          IDENTITY (1, 1) NOT NULL,
    [agency_id]        INT          NULL,
    [rate_category]    CHAR (3)     NULL,
    [rate_description] VARCHAR (50) NOT NULL,
    [rate]             FLOAT (53)   NULL,
    [fiscal_year_id]   INT          NULL,
    [rate_type]        CHAR (1)     NULL,
    [hour_equivalent]  FLOAT (53)   NULL,
    [is_active]        BIT          NULL,
    [insert_by]        CHAR (10)    NULL,
    [insert_date]      DATETIME     NULL,
    [update_by]        CHAR (10)    NULL,
    [update_date]      DATETIME     NULL,
    [tenant_id]        INT          NULL,
    CONSTRAINT [PK_agency_rate] PRIMARY KEY NONCLUSTERED ([agency_rate_id] ASC) WITH (FILLFACTOR = 90)
);

