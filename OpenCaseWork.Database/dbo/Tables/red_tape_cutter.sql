CREATE TABLE [dbo].[red_tape_cutter] (
    [red_tape_cutter_id]    INT           IDENTITY (1, 1) NOT NULL,
    [constituent_id]        INT           NULL,
    [red_tape_cutter_date]  DATETIME      NULL,
    [housing]               INT           NULL,
    [education]             INT           NULL,
    [dhhs_poverty_level]    INT           NULL,
    [referred_from_title_3] INT           NULL,
    [outreach_only]         INT           NULL,
    [bec_complete]          INT           NULL,
    [translator_used]       INT           NULL,
    [homebound]             INT           NULL,
    [description]           VARCHAR (100) NULL,
    [referrals]             VARCHAR (100) NULL,
    [tenant_id]             INT           NULL,
    CONSTRAINT [PK_red_tape_cutter] PRIMARY KEY CLUSTERED ([red_tape_cutter_id] ASC) WITH (FILLFACTOR = 90)
);

