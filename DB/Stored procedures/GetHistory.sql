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
SELECT O.* , R.CustomerPhone
FROM Order_ as O , TheOrderRelation as R
where O.OrderID = R.OrderID;
END
GO