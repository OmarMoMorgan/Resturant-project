SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

use ResturantDBProject
go
create procedure [dbo].[GetPriv]

@username varchar(50),
@pass varchar(50)

as 
begin 
select priv
from User_
where LoginName=@username and Password =@pass
end 
go 
