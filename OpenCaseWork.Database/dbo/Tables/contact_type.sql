CREATE TABLE [dbo].[contact_type] (
    [contact_type_id] INT            IDENTITY (1, 1) NOT NULL,
    [description]     NVARCHAR (100) NULL,
    [sequence]        INT            NULL,
    [is_phone]        BIT            NULL,
    CONSTRAINT [PK_contact_type] PRIMARY KEY CLUSTERED ([contact_type_id] ASC) WITH (FILLFACTOR = 90)
);

