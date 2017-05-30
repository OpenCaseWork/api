CREATE TABLE [dbo].[ads_survey_response] (
    [ads_survey_response_id]      INT          IDENTITY (1, 1) NOT NULL,
    [ads_survey_type_id]          INT          NULL,
    [ads_survey_response_type_id] INT          NULL,
    [ads_survey_mailing_id]       INT          NULL,
    [person_code]                 VARCHAR (10) NULL,
    [response_date]               DATETIME     NULL,
    [insert_user]                 CHAR (10)    NULL,
    [insert_date]                 DATETIME     NULL,
    [update_user]                 CHAR (10)    NULL,
    [Update_date]                 DATETIME     NULL,
    CONSTRAINT [PK_adult_day_services_questionnaire] PRIMARY KEY CLUSTERED ([ads_survey_response_id] ASC) WITH (FILLFACTOR = 90)
);

