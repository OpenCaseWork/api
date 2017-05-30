CREATE TABLE [dbo].[age_options_category] (
    [age_options_category_id] INT          IDENTITY (1, 1) NOT NULL,
    [name]                    VARCHAR (50) NULL,
    [evanston]                CHAR (1)     NULL,
    [maine]                   CHAR (1)     NULL,
    [new_trier]               CHAR (1)     NULL,
    [niles]                   CHAR (1)     NULL,
    [northfield]              CHAR (1)     NULL,
    [unit_type]               VARCHAR (50) NULL,
    [insert_user]             VARCHAR (50) NULL,
    [update_user]             VARCHAR (50) NULL,
    [insert_date]             DATETIME     NULL,
    [update_date]             DATETIME     NULL,
    CONSTRAINT [PK_age_options_category] PRIMARY KEY CLUSTERED ([age_options_category_id] ASC) WITH (FILLFACTOR = 90)
);

