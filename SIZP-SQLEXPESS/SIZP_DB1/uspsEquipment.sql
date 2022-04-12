Use [SIZP1]
go
-- =============================================
-- dbo.uspUpdateEquipment
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspUpdateEquipment' 
)
   DROP PROCEDURE dbo.uspUpdateEquipment
GO

CREATE PROCEDURE dbo.uspUpdateEquipment
	@Equipment_id int
	, @EquipmentClasses_EquipmentClassName nvarchar (255)
	, @EquipmentPassport_Type nvarchar (20)
	, @VoltageClasses_Value float
	, @VoltageClasses_Unit nvarchar(3)
	, @Equipment_DiagramPos nvarchar(10)
	, @Equipment_Feeder nvarchar(255)
	, @EquipmentPassport_InvNum nvarchar(10)
	, @EquipmentPassport_SerNum nvarchar(10)
	, @EquipmentClasses_CheckPeriodYear int
	, @EquipmentClasses_ReportTemplate nvarchar(50)
	, @EquipmentPassport_Manufacturer nvarchar(20)
	, @EquipmentPassport_ManufactureDate date
	, @EquipmentPassport_CommisioningDate date
	, @EquipmentPassport_JSONParams nvarchar(max)
	--, @EquipmentTest_DateOfCheck date
	--, @EquipmentTest_NextDateOfCheck date
	--, @EquipmentTest_JSONCheckParams nvarchar(max)
	, @Equipment_SSID int
AS
begin
	declare @Result int = -1
	declare @EquipmentClasses_id int
	declare @EquipmentPassport_id int
	--declare @EquipmentTest_id int
	declare @VoltageClass_id int
	begin tran
	begin try
			Select distinct @EquipmentClasses_id = [id] from [dbo].[EquipmentClasses]
				where [EquipmentClassName] = @EquipmentClasses_EquipmentClassName;
			select  distinct @VoltageClass_id = [id] from [dbo].[VoltageClasses]
				where [Value] = @VoltageClasses_Value;
			
			if @Equipment_id = 0
			begin
				insert into [dbo].[Equipment] ([EqClassID], [SSID], [VoltageID], [Feeder], [DiagramPos])
					Values(@EquipmentClasses_id, @Equipment_SSID, @VoltageClass_id,
							@Equipment_Feeder, @Equipment_DiagramPos);
				Declare @Eq_id int;
				select distinct @Eq_id = [id] from [dbo].[Equipment]
					where ([SSID] = @Equipment_SSID)
					and ([VoltageID] = @VoltageClass_id)
					and ([DiagramPos] = @Equipment_DiagramPos);
				insert into [dbo].[EquipmentPassport] ([EquipmentID], [Type], [InvNum], [SerNum], 
					[Manufacturer], [ManufactureDate], [CommisioningDate], [JSONParams])
					Values(@Eq_id
						, @EquipmentPassport_Type
						, @EquipmentPassport_InvNum
						, @EquipmentPassport_SerNum
						, @EquipmentPassport_Manufacturer
						, @EquipmentPassport_ManufactureDate
						, @EquipmentPassport_CommisioningDate
						, @EquipmentPassport_JSONParams
						);
				Set @Result = @Eq_id
			end
			else
			begin
				Update [dbo].[Equipment]
				Set [EqClassID] = @EquipmentClasses_id
				, [SSID] = @Equipment_SSID
				, [VoltageID] = @VoltageClass_id
				, [Feeder] = @Equipment_Feeder
				, [DiagramPos] = @Equipment_DiagramPos
				where [id] = @Equipment_id;
				
				Update [dbo].[EquipmentPassport]
				Set 
				  [Type] =				@EquipmentPassport_Type
				, [InvNum] =			@EquipmentPassport_InvNum
				, [SerNum] = 			@EquipmentPassport_SerNum
				, [Manufacturer] =		@EquipmentPassport_Manufacturer
				, [ManufactureDate] =	@EquipmentPassport_ManufactureDate
				, [CommisioningDate] =	@EquipmentPassport_CommisioningDate
				, [JSONParams] =		@EquipmentPassport_JSONParams
				where [EquipmentID] = @Equipment_id;
				Set @Result = @Equipment_id
			end
	end try
	begin catch
		if @@TRANCOUNT  > 0
			Rollback tran;
		set @Result = -1;
	end catch
	if @@TRANCOUNT >0 
		Commit tran;
	return @Result
end
GO

-- =============================================
-- dbo.uspDeleteEquipment
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspDeleteEquipment' 
)
   DROP PROCEDURE dbo.uspDeleteEquipment
GO

CREATE PROCEDURE dbo.uspDeleteEquipment
		@Equipment_id int
		, @DeleteAll bit = 1
AS
begin
	declare @Result int = -1
	begin tran
	begin try	
		delete from [dbo].[Equipment] where [id] = @Equipment_id;
		if @DeleteAll = 1
		begin
			delete from [dbo].[EquipmentPassport] where [EquipmentID] = @Equipment_id;
			delete from [dbo].[EquipmentTest] where [EquipmentID] = @Equipment_id;
		end;
	set @Result = 0;
	end try
	begin catch
		if @@TRANCOUNT > 0
			rollback tran;		
	end catch	
	if @@TRANCOUNT > 0
		Commit tran;
	Return @Result;
end
GO

