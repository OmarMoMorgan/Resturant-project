USE [ResturantDBProject]
GO
/****** Object:  StoredProcedure [dbo].[InsertTupleOrderR]    Script Date: 5/28/2022 10:40:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
alter PROCEDURE [dbo].[InsertTupleOrderR] @Orderii int , @Pphone int , @FoodNAme VARCHAR(10) , @QTY int
	-- Add the parameters for the stored procedure here
	--<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	--<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here

	declare @FID as int;
	select @FID = [ID]
	from FoodItem
	where @FoodNAme = Name;
    
	insert into Order_
	Values(@orderii , Getdate())


	insert into TheOrderRelation(CustomerPhone , FoodID , OrderID , Quantity)
	Values(@Pphone,@FID,@Orderii,@QTY)
--<@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END

