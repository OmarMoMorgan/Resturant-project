
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure removeBranch
@BranchID int
as 
begin 
delete
from Branch 
where BranchID = @BranchID

END
GO
