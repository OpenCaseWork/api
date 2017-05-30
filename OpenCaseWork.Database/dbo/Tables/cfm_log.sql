CREATE TABLE [dbo].[cfm_log] (
    [cfm_log_id]  INT  IDENTITY (1, 1) NOT NULL,
    [xml]         TEXT NULL,
    [is_medicaid] INT  NULL,
    [tenant_id]   INT  NULL
);

