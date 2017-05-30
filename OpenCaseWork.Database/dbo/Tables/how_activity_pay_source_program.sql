CREATE TABLE [dbo].[how_activity_pay_source_program] (
    [how_activity_pay_source_program_id] INT IDENTITY (1, 1) NOT NULL,
    [how_activity_pay_source_id]         INT NULL,
    [how_activity_program_id]            INT NULL,
    [tenant_id]                          INT NULL,
    CONSTRAINT [PK_how_activity_pay_source_program] PRIMARY KEY CLUSTERED ([how_activity_pay_source_program_id] ASC)
);

