SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
CREATE PROCEDURE AddMenu
	   @Menu_Name VARCHAR(30)

AS
BEGIN

INsert into Menu( MenName)
	Values( @Menu_Name);
	 
END
GO