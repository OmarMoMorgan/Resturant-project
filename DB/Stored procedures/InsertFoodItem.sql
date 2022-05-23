--insert item
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
CREATE PROCEDURE InsertFoodItem
	@Item_ID INT, @Item_Name VARCHAR(30) , @Item_Price float ,  @Menu_Name VARCHAR(30)

AS
BEGIN

INsert into FoodItem(ID , Price , Name , inMenu )
	Values(@Item_ID , @Item_Name , @Item_Price , @Menu_Name);
	 
END
GO
