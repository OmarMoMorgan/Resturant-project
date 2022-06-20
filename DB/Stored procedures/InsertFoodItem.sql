SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
CREATE PROCEDURE InsertFoodItem
	 @Item_Name VARCHAR(30) , @Item_Price float ,  @Menu_Name VARCHAR(30)

AS
BEGIN

INsert into FoodItem( Price , Name , inMenu )
	Values( @Item_Price , @Item_Name , @Menu_Name);
	 
END
GO