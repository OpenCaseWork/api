﻿CREATE TABLE [dbo].[cfm_file] (
    [cfm_file_id]             INT           IDENTITY (1, 1) NOT NULL,
    [run_date]                DATETIME      NULL,
    [client_update_date]      DATETIME      NULL,
    [file_name]               VARCHAR (50)  NULL,
    [original_xml]            TEXT          NULL,
    [constituent_xml]         TEXT          NULL,
    [action]                  VARCHAR (50)  NULL,
    [reason]                  VARCHAR (50)  NULL,
    [case_manager]            VARCHAR (50)  NOT NULL,
    [case_manager_code]       VARCHAR (80)  NULL,
    [client_id]               VARCHAR (50)  NULL,
    [last_name]               VARCHAR (50)  NULL,
    [first_name]              VARCHAR (50)  NULL,
    [address_line_1]          VARCHAR (50)  NULL,
    [address_line_2]          VARCHAR (50)  NULL,
    [zip_code]                VARCHAR (50)  NULL,
    [phone_number]            VARCHAR (50)  NULL,
    [birth_date]              DATETIME      NULL,
    [sex]                     VARCHAR (50)  NULL,
    [township]                VARCHAR (50)  NULL,
    [race]                    VARCHAR (50)  NULL,
    [english_spoken]          VARCHAR (50)  NULL,
    [language]                VARCHAR (50)  NULL,
    [marital_status]          VARCHAR (50)  NULL,
    [living_arrangement]      VARCHAR (50)  NULL,
    [living_status]           VARCHAR (50)  NULL,
    [type_of_housing]         VARCHAR (50)  NULL,
    [nursing_facility_status] VARCHAR (50)  NULL,
    [family_size]             VARCHAR (50)  NULL,
    [sixty_plus]              VARCHAR (50)  NULL,
    [number_receiving_ccp]    VARCHAR (50)  NULL,
    [spouse_residence]        VARCHAR (50)  NULL,
    [medicaid_number]         VARCHAR (50)  NULL,
    [billing_code]            VARCHAR (100) NULL,
    [county_code]             VARCHAR (50)  NULL,
    [case_manager_header]     VARCHAR (50)  NULL,
    [cfm_audit_id]            INT           NULL,
    [status]                  VARCHAR (50)  NULL,
    [open_date]               DATETIME      NULL,
    [complete_date]           DATETIME      NULL,
    [username]                VARCHAR (50)  NULL,
    [notes]                   VARCHAR (250) NULL,
    [eccpis_number]           VARCHAR (20)  NULL,
    [rin_number]              VARCHAR (20)  NULL,
    [constituent_id]          INT           NULL,
    [old_provider_type]       VARCHAR (10)  NULL,
    [new_provider_type]       VARCHAR (10)  NULL,
    [tenant_id]               INT           NULL,
    CONSTRAINT [PK_cfm_file] PRIMARY KEY CLUSTERED ([cfm_file_id] ASC) WITH (FILLFACTOR = 90)
);

