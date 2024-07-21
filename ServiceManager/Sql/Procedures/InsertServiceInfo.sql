USE [Services]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Logan Garrett>
-- Create date: <7/20/24>
-- Description:	<Select All Services.>
-- =============================================
CREATE PROCEDURE [dbo].[InsertServiceInfo] 
	@ServiceInfoTable [dbo].[ttServiceDetails] READONLY
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [Services].[dbo].[ServiceInfo]
    (
        [ServiceName],
        [ServiceVersion],
        [ServiceDescription],
        [ServiceAdditionDate],
        [ServiceFilePath]
    )
    SELECT 
		[ServiceName],
        [ServiceVersion],
        [ServiceDescription],
        [ServiceAdditionDate],
        [ServiceFilePath]
    FROM @ServiceInfoTable
END
GO
