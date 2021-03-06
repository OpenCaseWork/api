﻿CREATE TABLE [dbo].[napis_intake_constituent] (
    [napis_intake_constituent_id]   INT          IDENTITY (1, 1) NOT NULL,
    [napis_intake_id]               INT          NOT NULL,
    [CONSTITUENT_ID]                INT          NULL,
    [TITLE_ID]                      INT          NULL,
    [FIRST_NAME]                    VARCHAR (50) NULL,
    [MIDDLE_NAME]                   VARCHAR (50) NULL,
    [LAST_NAME]                     VARCHAR (50) NULL,
    [SUFFIX_ID]                     SMALLINT     NULL,
    [NICKNAME]                      VARCHAR (50) NULL,
    [ADDR1]                         VARCHAR (80) NULL,
    [ADDR2]                         VARCHAR (80) NULL,
    [CITY]                          VARCHAR (50) NULL,
    [CITY_ID]                       INT          NULL,
    [TOWNSHIP_ID]                   INT          NULL,
    [STATE_ID]                      INT          NULL,
    [ZIP_ID]                        INT          NULL,
    [FEDERAL_ID]                    VARCHAR (11) NULL,
    [BIRTH_DATE]                    DATETIME     NULL,
    [GENDER]                        INT          NULL,
    [MINORITY_ID]                   INT          NULL,
    [LIVING_ALONE]                  CHAR (1)     NULL,
    [FRAIL_DISABLED]                CHAR (1)     NULL,
    [LIMITED_ENGLISH]               CHAR (1)     NULL,
    [updated_date]                  DATETIME     NULL,
    [created_date]                  DATETIME     NULL,
    [END_DATE]                      DATETIME     NULL,
    [ZIP_CODE]                      VARCHAR (10) NULL,
    [lives_in_nursing_home]         CHAR (1)     NULL,
    [maiden_name]                   VARCHAR (30) NULL,
    [ethnicity_id]                  INT          NULL,
    [pet]                           CHAR (1)     NULL,
    [pet_explain]                   VARCHAR (50) NULL,
    [case_worker_risk]              CHAR (1)     NULL,
    [case_worker_risk_explain]      VARCHAR (50) NULL,
    [female_headed_house]           CHAR (1)     NULL,
    [preferred_language_id]         INT          NULL,
    [spouse_receiving_services]     CHAR (1)     NULL,
    [income_level_id]               INT          NULL,
    [significant_relationship_name] VARCHAR (50) NULL,
    [marital_status_id]             INT          NULL,
    [phone1]                        VARCHAR (10) NULL,
    [phone2]                        VARCHAR (10) NULL,
    [phone_type_id1]                INT          NULL,
    [phone_type_id2]                INT          NULL,
    [homeless]                      CHAR (1)     NULL,
    [income_amount]                 INT          NULL,
    [income_category_id]            INT          NULL,
    [tenant_id]                     INT          NULL,
    CONSTRAINT [PK__napis_intake_constituent] PRIMARY KEY NONCLUSTERED ([napis_intake_constituent_id] ASC) WITH (FILLFACTOR = 90)
);

