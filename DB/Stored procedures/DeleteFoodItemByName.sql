

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO

CREATE PROCEDURE DeleteFoodItemByName @Item_Name VARCHAR(30)
	
AS
BEGIN
	Delete From FoodItem 
	where Name = @Item_Name ;

END
GO
