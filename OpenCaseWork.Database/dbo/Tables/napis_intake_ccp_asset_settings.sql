CREATE TABLE [dbo].[napis_intake_ccp_asset_settings] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [married]     BIT          NULL,
    [asset_level] INT          NULL,
    [description] VARCHAR (50) NULL,
    [tenant_id]   INT          NULL
);

