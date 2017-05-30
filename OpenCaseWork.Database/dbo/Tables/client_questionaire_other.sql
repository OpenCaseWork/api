CREATE TABLE [dbo].[client_questionaire_other] (
    [questionaire_other_id]   INT              IDENTITY (1, 1) NOT NULL,
    [questionaire_other_guid] UNIQUEIDENTIFIER NULL,
    [questionaire_id]         INT              NULL,
    [type_id]                 INT              NULL,
    [caregiver_stress]        VARCHAR (10)     NULL,
    [other_stress]            VARCHAR (10)     NULL,
    [other_mental_health]     VARCHAR (10)     NULL,
    [social_support]          VARCHAR (10)     NULL,
    [legal_issues]            VARCHAR (10)     NULL,
    [financial_issues]        VARCHAR (10)     NULL,
    [hearing]                 VARCHAR (10)     NULL,
    [chronic]                 VARCHAR (10)     NULL,
    [home_safety]             VARCHAR (10)     NULL,
    [spirituality]            VARCHAR (10)     NULL,
    [tenant_id]               INT              NULL,
    CONSTRAINT [PK_client_questionaire_other] PRIMARY KEY CLUSTERED ([questionaire_other_id] ASC)
);

