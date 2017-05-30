CREATE TABLE [dbo].[code] (
    [code_id]    INT          IDENTITY (1, 1) NOT NULL,
    [code_class] VARCHAR (30) NULL,
    [code_text]  VARCHAR (50) NULL,
    [code_value] VARCHAR (50) NULL,
    [is_active]  BIT          NULL,
    [sort_order] INT          NULL,
    [tenant_id]  INT          NULL,
    CONSTRAINT [PK__code__3D7E1B63] PRIMARY KEY NONCLUSTERED ([code_id] ASC) WITH (FILLFACTOR = 90)
);

