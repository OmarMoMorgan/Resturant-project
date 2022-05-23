
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure removeBranch
@BranchName varchar(50)
as 
begin 
delete
from Branch 
where BranchName = @BranchName

END
GO
