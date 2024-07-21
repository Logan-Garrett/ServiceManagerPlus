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
CREATE PROCEDURE [dbo].[SelectAllServices]
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT [ServiceName],
           [ServiceVersion],
           [ServiceDescription],
           [ServiceAdditionDate],
           [ServiceFilePath]
    FROM [Services].[dbo].[ServiceInfo]
END
