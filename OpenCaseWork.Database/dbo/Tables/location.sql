CREATE TABLE [dbo].[location] (
    [location_id]          INT          IDENTITY (1, 1) NOT NULL,
    [location_name]        VARCHAR (50) NULL,
    [is_class_location]    CHAR (10)    NULL,
    [location_description] VARCHAR (50) NULL,
    [is_respite_location]  CHAR (1)     NULL,
    [tenant_id]            INT          NULL,
    CONSTRAINT [PK_location] PRIMARY KEY CLUSTERED ([location_id] ASC) WITH (FILLFACTOR = 90)
);

