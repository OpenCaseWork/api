CREATE TABLE [dbo].[fiscal_year] (
    [fiscal_year_id]          INT          IDENTITY (1, 1) NOT NULL,
    [fiscal_year_description] VARCHAR (10) NULL,
    [start_date]              DATETIME     NULL,
    [end_date]                DATETIME     NULL,
    [hour_limit]              INT          NULL,
    [dollar_limit]            INT          NULL,
    [active]                  CHAR (1)     NULL,
    [gap_fill_limit]          INT          NULL,
    [tenant_id]               INT          NULL,
    CONSTRAINT [PK_fiscal_year] PRIMARY KEY CLUSTERED ([fiscal_year_id] ASC) WITH (FILLFACTOR = 90)
);

