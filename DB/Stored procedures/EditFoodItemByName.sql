
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
CREATE PROCEDURE EditFoodItemByName
@Menu_Name VARCHAR(30),
@CurrentItem_Name VARCHAR(30) ,
@NewItem_Name VARCHAR(30) ,
@NewItem_Price float 


AS
BEGIN
	update FoodItem
	set Name=@NewItem_Name ,Price = @NewItem_Price
	where inMenu=@Menu_Name and  Name = @CurrentItem_Name;
END
GO
