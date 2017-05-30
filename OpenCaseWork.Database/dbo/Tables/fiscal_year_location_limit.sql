CREATE TABLE [dbo].[fiscal_year_location_limit] (
    [fiscal_year_limit_id] INT   IDENTITY (1, 1) NOT NULL,
    [location_id]          INT   NULL,
    [title3B_amount]       MONEY NULL,
    [title3E_amount]       MONEY NULL,
    [fiscal_year_id]       INT   NULL,
    [gap_fill_amount]      MONEY NULL,
    [tenant_id]            INT   NULL,
    CONSTRAINT [PK_fiscal_year_limit] PRIMARY KEY CLUSTERED ([fiscal_year_limit_id] ASC) WITH (FILLFACTOR = 90)
);

