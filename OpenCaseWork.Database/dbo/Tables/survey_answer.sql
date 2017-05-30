CREATE TABLE [dbo].[survey_answer] (
    [survey_answer_id]       INT           IDENTITY (1, 1) NOT NULL,
    [survey_response_id]     INT           NOT NULL,
    [survey_question_id]     INT           NOT NULL,
    [survey_type_section_id] INT           NULL,
    [question_number]        INT           NULL,
    [question_text]          VARCHAR (200) NULL,
    [answer_value]           INT           NULL,
    [report_answer_value]    INT           NULL,
    CONSTRAINT [PK_ads_survey_answer] PRIMARY KEY CLUSTERED ([survey_answer_id] ASC) WITH (FILLFACTOR = 90)
);

