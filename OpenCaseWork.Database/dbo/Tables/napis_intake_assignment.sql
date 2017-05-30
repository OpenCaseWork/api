CREATE TABLE [dbo].[napis_intake_assignment] (
    [napis_intake_assignment_id] INT          IDENTITY (1, 1) NOT NULL,
    [provider_id]                INT          NULL,
    [napis_intake_id]            INT          NULL,
    [constituent_case_id]        INT          NULL,
    [provider_service_type]      VARCHAR (50) NULL,
    [assignment_date]            DATETIME     NULL,
    [is_viewed]                  BIT          NULL,
    [acknowledge_date]           DATETIME     NULL,
    [tenant_id]                  INT          NULL
);

