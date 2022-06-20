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
CREATE PROCEDURE GetHistory 
	-- Add the parameters for the stored procedure here
	--@fromDate varchar(50),
	--@toDate  date;
AS
BEGIN
SELECT ExpName, Cost
FROM Expenses
END
GO