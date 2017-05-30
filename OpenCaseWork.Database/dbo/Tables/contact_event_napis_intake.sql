CREATE TABLE [dbo].[contact_event_napis_intake] (
    [contact_event_napis_intake_id] INT IDENTITY (1, 1) NOT NULL,
    [contact_event_id]              INT NOT NULL,
    [napis_intake_id]               INT NOT NULL,
    [tenant_id]                     INT NULL,
    CONSTRAINT [PK_contact_event_napis_intake] PRIMARY KEY CLUSTERED ([contact_event_napis_intake_id] ASC)
);

