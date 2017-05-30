CREATE TABLE [dbo].[LogMessages] (
    [LogMessageId]      INT            IDENTITY (1, 1) NOT NULL,
    [LogMessageDt]      DATETIME       NULL,
    [ThreadId]          VARCHAR (50)   NULL,
    [SeverityLevelName] VARCHAR (5)    NULL,
    [LoggerName]        VARCHAR (255)  NULL,
    [ApplicationMsgTxt] VARCHAR (1000) NULL,
    [ExceptionMsgTxt]   VARCHAR (2000) NULL,
    [LocationMsgTxt]    VARCHAR (500)  NULL,
    [PersonPartyID]     INT            NULL,
    [FeatureID]         INT            NULL,
    [tenant_id]         INT            NULL
);

