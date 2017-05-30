CREATE TABLE [dbo].[ads_survey_type] (
    [ads_survey_type_id]          INT           IDENTITY (1, 1) NOT NULL,
    [ads_survey_type_description] VARCHAR (100) NULL,
    [survey_group]                VARCHAR (3)   NULL,
    [is_active]                   CHAR (1)      NULL,
    CONSTRAINT [PK_ads_survey_type] PRIMARY KEY CLUSTERED ([ads_survey_type_id] ASC) WITH (FILLFACTOR = 90)
);

