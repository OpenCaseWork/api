CREATE TABLE [dbo].[constituent_marital_status] (
    [constituent_marital_status_id] INT          IDENTITY (1, 1) NOT NULL,
    [marital_status_id]             INT          NULL,
    [constituent_id]                INT          NULL,
    [marital_status_date]           DATETIME     NULL,
    [significant_other]             VARCHAR (50) NULL,
    [tenant_id]                     INT          NULL,
    CONSTRAINT [PK_constituent_marital_status] PRIMARY KEY CLUSTERED ([constituent_marital_status_id] ASC) WITH (FILLFACTOR = 90)
);

