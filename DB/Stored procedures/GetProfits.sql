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
CREATE PROCEDURE GetProfits 
	-- Add the parameters for the stored procedure here
	--@fromDate date,
	--@toDate  date
AS
BEGIN
SELECT ExpName, Cost
FROM Expenses
--where ExpDate > @fromDate AND ExpDate<@toDate;
END
GO