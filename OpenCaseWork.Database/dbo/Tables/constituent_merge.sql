CREATE TABLE [dbo].[constituent_merge] (
    [constituent_merge_id]  INT          IDENTITY (1, 1) NOT NULL,
    [source_constituent_id] INT          NULL,
    [target_constituent_id] INT          NULL,
    [username]              VARCHAR (50) NULL,
    [merge_date]            DATETIME     NULL,
    [tenant_id]             INT          NULL
);

