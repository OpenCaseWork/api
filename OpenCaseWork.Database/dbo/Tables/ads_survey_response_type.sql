CREATE TABLE [dbo].[ads_survey_response_type] (
    [ads_survey_response_type_id] INT          IDENTITY (1, 1) NOT NULL,
    [description]                 VARCHAR (50) NULL,
    CONSTRAINT [PK_ads_survey_response_type] PRIMARY KEY CLUSTERED ([ads_survey_response_type_id] ASC) WITH (FILLFACTOR = 90)
);

