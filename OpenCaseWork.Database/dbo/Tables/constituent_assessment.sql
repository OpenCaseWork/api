CREATE TABLE [dbo].[constituent_assessment] (
    [constituent_assessment_id] INT          IDENTITY (1, 1) NOT NULL,
    [constituent_id]            INT          NULL,
    [assessment_date]           DATETIME     NULL,
    [provider_id]               INT          NULL,
    [insert_user]               VARCHAR (10) NULL,
    [insert_date]               DATETIME     NULL,
    [tenant_id]                 INT          NULL,
    CONSTRAINT [PK_constituent_assessment] PRIMARY KEY CLUSTERED ([constituent_assessment_id] ASC) WITH (FILLFACTOR = 90)
);

