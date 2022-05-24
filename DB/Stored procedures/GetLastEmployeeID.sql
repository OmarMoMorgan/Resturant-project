SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetLastEmployeeID
	-- Add the parameters for the stored procedure here
AS
BEGIN
SELECT Max(EmpID)
from Employee;
END
GO
