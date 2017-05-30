CREATE TABLE [dbo].[constituent_case] (
    [CASE_ID]                  INT          IDENTITY (1, 1) NOT NULL,
    [CONSTITUENT_ID]           INT          NOT NULL,
    [PROVIDER_ID]              INT          NOT NULL,
    [DATE_OPEN]                DATETIME     NULL,
    [DATE_CLOSED]              DATETIME     NULL,
    [OPEN_FLAG]                CHAR (1)     NULL,
    [REASON_FOR_CLOSE]         INT          NULL,
    [INSERT_USER]              VARCHAR (50) NULL,
    [INSERT_DATE]              DATETIME     NULL,
    [UPDATE_USER]              VARCHAR (50) NULL,
    [UPDATE_DATE]              DATETIME     NULL,
    [PROVIDER_SERVICE_TYPE_ID] INT          NULL,
    [tenant_id]                INT          NULL,
    CONSTRAINT [PK__CONSTITUENT_CASE__76619304] PRIMARY KEY NONCLUSTERED ([CASE_ID] ASC) WITH (FILLFACTOR = 90)
);

