CREATE TABLE [dbo].[ethnicity] (
    [ethnicity_id]          INT           IDENTITY (1, 1) NOT NULL,
    [ethnicity_description] NVARCHAR (50) NULL,
    [ba_report_description] NVARCHAR (50) NULL,
    [harmony_description]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_ethnicity] PRIMARY KEY CLUSTERED ([ethnicity_id] ASC) WITH (FILLFACTOR = 90)
);

