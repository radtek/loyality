IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID(N'[prod].[Cache]') AND name = 'DisableDate')
BEGIN
	ALTER TABLE [prod].[Cache]
	ADD [DisableDate] [datetime] NULL
END