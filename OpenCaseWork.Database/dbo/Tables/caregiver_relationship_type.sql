CREATE TABLE [dbo].[caregiver_relationship_type] (
    [caregiver_relationship_type_id] INT          IDENTITY (1, 1) NOT NULL,
    [name]                           VARCHAR (50) NULL,
    [tenant_id]                      INT          NULL,
    CONSTRAINT [PK_caregiver_relationship_type] PRIMARY KEY CLUSTERED ([caregiver_relationship_type_id] ASC) WITH (FILLFACTOR = 90)
);

