CREATE TABLE [dbo].[napis_form] (
    [napis_form_id]       INT            IDENTITY (1, 1) NOT NULL,
    [napis_group_id]      INT            NOT NULL,
    [constituent_id]      INT            NULL,
    [action_id]           INT            NULL,
    [open_to_provider_id] INT            NULL,
    [status_id]           INT            NULL,
    [update_date]         DATETIME       NULL,
    [create_date]         DATETIME       NULL,
    [update_userid]       VARCHAR (10)   NULL,
    [create_userid]       VARCHAR (10)   NULL,
    [notes]               VARCHAR (2000) NULL,
    [tenant_id]           INT            NULL,
    CONSTRAINT [PK_napis_form] PRIMARY KEY CLUSTERED ([napis_form_id] ASC) WITH (FILLFACTOR = 90)
);

