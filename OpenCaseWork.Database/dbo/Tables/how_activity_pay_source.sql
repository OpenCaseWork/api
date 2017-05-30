CREATE TABLE [dbo].[how_activity_pay_source] (
    [pay_source_id]   INT          IDENTITY (1, 1) NOT NULL,
    [pay_source_name] VARCHAR (50) NULL,
    [tenant_id]       INT          NULL,
    CONSTRAINT [PK_how_activity_pay_source] PRIMARY KEY CLUSTERED ([pay_source_id] ASC) WITH (FILLFACTOR = 90)
);

