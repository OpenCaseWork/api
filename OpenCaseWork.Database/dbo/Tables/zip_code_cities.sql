CREATE TABLE [dbo].[zip_code_cities] (
    [zip_code]   NVARCHAR (50) NOT NULL,
    [city_id]    INT           NOT NULL,
    [is_primary] BIT           NULL,
    CONSTRAINT [PK_zip_code_cities] PRIMARY KEY CLUSTERED ([zip_code] ASC, [city_id] ASC)
);

