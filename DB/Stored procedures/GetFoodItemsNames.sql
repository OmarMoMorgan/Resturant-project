set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
use ResturantDBProject
GO

-- =============================================
create PROCEDURE [dbo].[GetFoodItemNames]
@MenuName Varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Name
	From  FoodItem F 
	Where F.inMenu = @MenuName;
END

