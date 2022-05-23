
-- ================================================
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO

-- =============================================
CREATE PROCEDURE ViewMenuByName @MenuName Varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT ID,F.Name,Price
	From Menu M  , FoodItem F 
	Where M.MenName=F.inMenu;
END
GO
