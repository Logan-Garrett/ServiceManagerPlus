USE [Services]
GO

CREATE TYPE [dbo].[ttServiceDetails] AS TABLE(
	[ServiceName] [varchar](255) NULL,
	[ServiceVersion] [int] NULL,
	[ServiceDescription] [varchar](255) NULL,
	[ServiceAdditionDate] [datetime] NULL,
	[ServiceFilePath] [varchar](255) NULL
)
GO
