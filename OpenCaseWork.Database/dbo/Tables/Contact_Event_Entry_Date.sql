CREATE TABLE [dbo].[Contact_Event_Entry_Date] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [EntryDate]  DATETIME     NULL,
    [UpdateUser] VARCHAR (10) NULL,
    [UpdateDate] DATETIME     CONSTRAINT [DF_Contact_Event_Cutoff_UpdateDate] DEFAULT (getdate()) NULL,
    [tenant_id]  INT          NULL,
    CONSTRAINT [PK_ContactEventCutoff] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90)
);

