CREATE TABLE [dbo].[ads_survey_mailing] (
    [ads_survey_mailing_id]    INT           IDENTITY (1, 1) NOT NULL,
    [mailing_date]             DATETIME      NULL,
    [mailing_name]             VARCHAR (100) NULL,
    [mailing_survey_type_id]   INT           NULL,
    [mailing_response_type_id] INT           NULL,
    [item_count]               INT           NULL,
    [insert_date]              DATETIME      NULL,
    [insert_userid]            CHAR (10)     NULL,
    [update_date]              DATETIME      NULL,
    [update_userid]            CHAR (10)     NULL,
    CONSTRAINT [PK_ads_survey_mailing] PRIMARY KEY CLUSTERED ([ads_survey_mailing_id] ASC) WITH (FILLFACTOR = 90)
);

