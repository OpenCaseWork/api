CREATE TABLE [dbo].[how_credit_type] (
    [how_credit_type_id] INT          IDENTITY (1, 1) NOT NULL,
    [description]        VARCHAR (20) NULL,
    [tenant_id]          INT          NULL,
    CONSTRAINT [PK_how_credit_type] PRIMARY KEY CLUSTERED ([how_credit_type_id] ASC) WITH (FILLFACTOR = 90)
);

