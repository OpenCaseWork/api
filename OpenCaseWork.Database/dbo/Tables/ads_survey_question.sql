CREATE TABLE [dbo].[ads_survey_question] (
    [ads_survey_question_id]         INT           IDENTITY (1, 1) NOT NULL,
    [ads_survey_type_id]             INT           NULL,
    [ads_survey_type_section_id]     INT           NULL,
    [question_number]                INT           NULL,
    [question_text]                  VARCHAR (200) NULL,
    [reverse_answer_value_in_report] CHAR (1)      NULL,
    [max_answer_value]               INT           NULL,
    [is_active]                      INT           NULL,
    CONSTRAINT [PK_adult_day_services_question] PRIMARY KEY CLUSTERED ([ads_survey_question_id] ASC) WITH (FILLFACTOR = 90)
);

