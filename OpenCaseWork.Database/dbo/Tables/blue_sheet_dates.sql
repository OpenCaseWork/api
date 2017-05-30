CREATE TABLE [dbo].[blue_sheet_dates] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [month]        VARCHAR (255) NULL,
    [month_number] INT           NULL,
    [year_number]  INT           NULL,
    [week_number]  INT           NULL,
    [start_date]   INT           NULL,
    [end_date]     INT           NULL,
    [tenant_id]    INT           NULL,
    CONSTRAINT [PK_blue_sheet_dates] PRIMARY KEY CLUSTERED ([id] ASC) WITH (FILLFACTOR = 90)
);

