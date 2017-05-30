CREATE TABLE [dbo].[napis_intake_program] (
    [napis_intake_program_id] INT          IDENTITY (1, 1) NOT NULL,
    [program_id]              INT          NULL,
    [program_name]            VARCHAR (50) NULL,
    [abbreviation]            VARCHAR (50) NULL,
    [active]                  CHAR (1)     NULL,
    [tenant_id]               INT          NULL,
    CONSTRAINT [PK_napis_intake_program] PRIMARY KEY CLUSTERED ([napis_intake_program_id] ASC)
);

