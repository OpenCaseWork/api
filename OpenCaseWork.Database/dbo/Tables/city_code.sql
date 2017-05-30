CREATE TABLE [dbo].[city_code] (
    [city_code_id]   INT          NOT NULL,
    [city_code_name] VARCHAR (50) NULL,
    [tenant_id]      INT          NULL,
    CONSTRAINT [PK_city_code] PRIMARY KEY CLUSTERED ([city_code_id] ASC) WITH (FILLFACTOR = 90)
);

