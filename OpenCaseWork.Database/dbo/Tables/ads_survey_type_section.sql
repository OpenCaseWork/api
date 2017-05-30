CREATE TABLE [dbo].[ads_survey_type_section] (
    [ads_survey_type_section_id] INT IDENTITY (1, 1) NOT NULL,
    [section_number]             INT NULL,
    [ads_survey_type_id]         INT NULL,
    CONSTRAINT [PK_ads_survey_type_section] PRIMARY KEY CLUSTERED ([ads_survey_type_section_id] ASC) WITH (FILLFACTOR = 90)
);

