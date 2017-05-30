CREATE TABLE [dbo].[comm_educ_event_service] (
    [id]                 INT          IDENTITY (1, 1) NOT NULL,
    [comm_educ_event_id] INT          NULL,
    [service_code_id]    INT          NULL,
    [service_code]       VARCHAR (50) NULL,
    [insert_dt]          DATETIME     NULL,
    [update_dt]          DATETIME     NULL,
    [insert_userid]      VARCHAR (50) NULL,
    [update_userid]      VARCHAR (50) NULL,
    [tenant_id]          INT          NULL,
    CONSTRAINT [PK_comm_educ_event_service] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

