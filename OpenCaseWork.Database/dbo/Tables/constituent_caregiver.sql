CREATE TABLE [dbo].[constituent_caregiver] (
    [constituent_caregiver_id]       INT       IDENTITY (1, 1) NOT NULL,
    [constituent_id]                 INT       NOT NULL,
    [recipient_constituent_id]       INT       NOT NULL,
    [is_primary]                     CHAR (1)  NULL,
    [caregiver_relationship_type_id] INT       NULL,
    [insert_date]                    DATETIME  NULL,
    [insert_userid]                  CHAR (10) NULL,
    [update_date]                    DATETIME  NULL,
    [update_userid]                  CHAR (10) NULL,
    [start_date]                     DATETIME  NULL,
    [end_date]                       DATETIME  NULL,
    [tenant_id]                      INT       NULL,
    CONSTRAINT [PK_constituent_caregiver] PRIMARY KEY CLUSTERED ([constituent_caregiver_id] ASC) WITH (FILLFACTOR = 90)
);

