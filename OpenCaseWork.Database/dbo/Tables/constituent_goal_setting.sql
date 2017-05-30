CREATE TABLE [dbo].[constituent_goal_setting] (
    [constituent_goal_setting_id] INT       IDENTITY (1, 1) NOT NULL,
    [constituent_id]              INT       NULL,
    [assessment_date]             DATETIME  NULL,
    [provider_id]                 INT       NULL,
    [insert_user]                 CHAR (10) NULL,
    [insert_date]                 DATETIME  NULL,
    [tenant_id]                   INT       NULL,
    CONSTRAINT [PK_constituent_goal_setting] PRIMARY KEY CLUSTERED ([constituent_goal_setting_id] ASC) WITH (FILLFACTOR = 90)
);

