CREATE TABLE [dbo].[red_tape_cutter_service] (
    [red_tape_cutter_service_id] INT          IDENTITY (1, 1) NOT NULL,
    [constituent_id]             INT          NOT NULL,
    [service_id]                 INT          NOT NULL,
    [service_date]               DATETIME     NOT NULL,
    [service_type_id]            INT          NULL,
    [insert_user]                VARCHAR (50) NULL,
    [insert_date]                DATETIME     NULL,
    [update_user]                VARCHAR (50) NULL,
    [update_date]                DATETIME     NULL,
    [contact_event_id]           INT          NULL,
    [position]                   INT          NULL,
    [tenant_id]                  INT          NULL,
    CONSTRAINT [PK_red_tape_cutter_service] PRIMARY KEY CLUSTERED ([red_tape_cutter_service_id] ASC) WITH (FILLFACTOR = 90)
);

