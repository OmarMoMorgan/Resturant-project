

-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO

CREATE PROCEDURE DeleteMenu @Menu_Name VARCHAR(30)
	
AS
BEGIN
	Delete From Menu 
	where MenName = @Menu_Name ;

END
GO
