CREATE TABLE [dbo].[comm_educ_event_time] (
    [id]                 INT          IDENTITY (1, 1) NOT NULL,
    [comm_educ_event_id] INT          NULL,
    [provder_id]         INT          NULL,
    [provider_number]    VARCHAR (10) NULL,
    [travel_minutes]     INT          NULL,
    [planning_minutes]   INT          NULL,
    [program_minutes]    INT          NULL,
    [insert_dt]          DATETIME     NULL,
    [update_dt]          DATETIME     NULL,
    [insert_userid]      VARCHAR (50) NULL,
    [update_userid]      VARCHAR (50) NULL,
    [total_minutes]      INT          NULL,
    [tenant_id]          INT          NULL,
    CONSTRAINT [PK_comm_educ_event_time] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

