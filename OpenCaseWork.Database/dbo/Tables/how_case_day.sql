CREATE TABLE [dbo].[how_case_day] (
    [how_case_day_id] INT      IDENTITY (1, 1) NOT NULL,
    [case_month_id]   INT      NOT NULL,
    [day_number]      SMALLINT NOT NULL,
    [day_value]       CHAR (2) NULL,
    [day_month]       SMALLINT NOT NULL,
    [day_year]        SMALLINT NOT NULL,
    [how_type_id]     INT      NULL,
    [tenant_id]       INT      NULL,
    CONSTRAINT [PK_how_case_day] PRIMARY KEY NONCLUSTERED ([case_month_id] ASC, [day_number] ASC) WITH (FILLFACTOR = 90)
);

