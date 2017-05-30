CREATE TABLE [dbo].[constituent_face_to_face] (
    [constituent_face_to_face_id] INT       IDENTITY (1, 1) NOT NULL,
    [constituent_id]              INT       NULL,
    [assessment_date]             DATETIME  NULL,
    [provider_id]                 INT       NULL,
    [insert_user]                 CHAR (10) NULL,
    [insert_date]                 DATETIME  NULL,
    [tenant_id]                   INT       NULL,
    CONSTRAINT [PK_constituent_face_to_face] PRIMARY KEY CLUSTERED ([constituent_face_to_face_id] ASC) WITH (FILLFACTOR = 90)
);

