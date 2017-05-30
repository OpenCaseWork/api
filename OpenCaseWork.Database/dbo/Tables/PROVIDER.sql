CREATE TABLE [dbo].[PROVIDER] (
    [PROVIDER_ID]         INT           IDENTITY (1, 1) NOT NULL,
    [PROVIDER_NUMBER]     INT           NOT NULL,
    [DESCRIPTION]         VARCHAR (50)  NULL,
    [ACTIVE]              CHAR (1)      NULL,
    [BLUE_SHEET]          CHAR (1)      NULL,
    [PROVIDER_LOCATION]   VARCHAR (15)  NULL,
    [GROUP_PROVIDER]      CHAR (1)      NULL,
    [GROUP_PROVIDER_NAME] VARCHAR (100) NULL,
    [manager_id]          INT           NULL,
    [is_manager]          CHAR (1)      NULL,
    [create_date]         DATETIME      NULL,
    [update_date]         DATETIME      NULL,
    [create_user]         VARCHAR (50)  NULL,
    [update_user]         VARCHAR (50)  NULL,
    [hours_per_week]      INT           NULL,
    [manager2_id]         INT           NULL,
    [manager3_id]         INT           NULL,
    [start_date]          DATETIME      NULL,
    [term_date]           DATETIME      NULL,
    [tenant_id]           INT           NULL,
    CONSTRAINT [PK__PROVIDER__6AEFE058] PRIMARY KEY NONCLUSTERED ([PROVIDER_ID] ASC) WITH (FILLFACTOR = 90)
);

