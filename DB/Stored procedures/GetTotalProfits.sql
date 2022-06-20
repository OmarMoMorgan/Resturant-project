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
CREATE PROCEDURE GetTotalProfits 
	-- Add the parameters for the stored procedure here
	@fromDate date,
	@toDate  date
AS
BEGIN
SELECT SUM(Cost)
FROM Expenses
--where ExpDate > @fromDate AND ExpDate<@toDate;
END
GO