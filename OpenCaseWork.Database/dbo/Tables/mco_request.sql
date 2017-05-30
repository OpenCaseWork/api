CREATE TABLE [dbo].[mco_request] (
    [mco_request_id] INT          IDENTITY (1, 1) NOT NULL,
    [constituent_id] INT          NULL,
    [submit_dt]      DATETIME     NULL,
    [mco_action]     VARCHAR (50) NULL,
    [start_dt]       DATETIME     NULL,
    [mco_name]       VARCHAR (50) NULL,
    [don_score]      INT          NULL,
    [billing_code]   VARCHAR (50) NULL,
    [office]         VARCHAR (50) NULL,
    [insert_user]    VARCHAR (50) NULL,
    [update_user]    VARCHAR (50) NULL,
    [update_dt]      CHAR (10)    NULL,
    [insert_dt]      DATETIME     NULL,
    [tenant_id]      INT          NULL
);

