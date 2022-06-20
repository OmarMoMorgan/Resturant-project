SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
use ResturantDBProject
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetSupervisedBranch 
	-- Add the parameters for the stored procedure here
	@Sname varchar(50)
AS
BEGIN

Select B.BranchName
From BranchSupervisor AS S, Branch AS B
Where S.Name=@Sname AND B.BranchSupSSN = S.SSN

END
GO
