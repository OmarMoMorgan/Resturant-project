-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
CREATE PROCEDURE SelectAllMenusNames
	
AS
BEGIN
	
	SELECT MenName
	From Menu;
END
GO

