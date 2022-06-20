USE [ResturantDBProject]
GO

/****** Object:  StoredProcedure [dbo].[GetLastEmployeeID]    Script Date: 6/19/2022 11:54:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetLastEmployeeID]
	-- Add the parameters for the stored procedure here
AS
BEGIN
SELECT Max(EmpID)
from Employee;
END
GO


