CREATE TABLE [dbo].[city] (
    [city_id]     INT          IDENTITY (1, 1) NOT NULL,
    [city_code]   SMALLINT     NOT NULL,
    [city]        VARCHAR (50) NOT NULL,
    [city_group]  VARCHAR (50) NULL,
    [zip_code_id] INT          NULL,
    [township_id] INT          NULL,
    [town_code]   VARCHAR (5)  NULL,
    [tenant_id]   INT          NULL,
    CONSTRAINT [PK__CITY__2AD55B43] PRIMARY KEY NONCLUSTERED ([city_id] ASC) WITH (FILLFACTOR = 90)
);

