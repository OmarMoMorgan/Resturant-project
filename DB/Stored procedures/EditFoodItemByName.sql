
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
CREATE PROCEDURE EditFoodItemByName
@CurrentItem_Name VARCHAR(30) ,
@NewItem_Name VARCHAR(30) ,
@NewItem_Price float 


AS
BEGIN
	update FoodItem
	set Name=@NewItem_Name ,Price = @NewItem_Price
	where   Name = @CurrentItem_Name;
END
GO
