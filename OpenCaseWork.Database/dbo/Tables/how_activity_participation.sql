CREATE TABLE [dbo].[how_activity_participation] (
    [how_activity_participation_id] INT       IDENTITY (1, 1) NOT NULL,
    [activity_date]                 DATETIME  NOT NULL,
    [how_activity_id]               INT       NOT NULL,
    [constituent_id]                INT       NOT NULL,
    [score]                         INT       NULL,
    [declined]                      CHAR (1)  NULL,
    [insert_date]                   DATETIME  NULL,
    [insert_by]                     CHAR (10) NULL,
    [update_date]                   DATETIME  NULL,
    [update_by]                     CHAR (10) NULL,
    [tenant_id]                     INT       NULL,
    CONSTRAINT [PK_how_activity_participation] PRIMARY KEY CLUSTERED ([how_activity_participation_id] ASC) WITH (FILLFACTOR = 90)
);

