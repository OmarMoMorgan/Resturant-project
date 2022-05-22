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
CREATE PROCEDURE InsertEmployee 
	-- Add the parameters for the stored procedure here
	@ename varchar(50),
	@ejob  varchar(20),
	@edate date,
	@esalary int,
	@eid int
AS
BEGIN
Insert into Employee(EmpName, EmpID, Salary) 
Values				(@ename, @eid, @esalary)
END
GO
