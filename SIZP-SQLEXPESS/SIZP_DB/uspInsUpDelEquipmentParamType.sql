Use [SZIP]
go
-- =============================================
-- dbo.uspUpdateParamTypes
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspUpdateParamTypes' 
)
   DROP PROCEDURE dbo.uspUpdateParamTypes
GO

CREATE PROCEDURE dbo.uspUpdateParamTypes
		@id int --NOT NULL,
	,@TypeId int --NOT NULL,
	,@Name nvarchar(50) --NOT NULL,
	,@Unit nvarchar(10) --NULL,
	,@IsStatic bit --NOT NULL,
	,@Value sql_variant --NULL,
	,@MinValue sql_variant --NULL,
	,@MaxValue sql_variant --NULL,
	,@ReportField nvarchar(20) --NULL,
AS
	Declare @Result int = -1;
	begin try
		if @id = 0
			insert into [dbo].[EquipmentParamType] (
				[TypeId]
				,[Name]
				,[Unit]
				,[IsStatic]
				,[Value]
				,[MinValue]
				,[MaxValue]
				,[ReportField]
			)
			Values (
				@TypeId
				,@Name
				,@Unit
				,@IsStatic
				,@Value
				,@MinValue
				,@MaxValue
				,@ReportField
			)
		else
			update [dbo].[EquipmentParamType]
			set 
				[TypeId] = @TypeId
				,[Name] = @Name
				,[Unit] = @Unit
				,[IsStatic] = @IsStatic
				,[Value] = @Value
				,[MinValue] = @MinValue
				,[MaxValue] = @MaxValue
				,[ReportField] = @ReportField;
			Select distinct @Result = [id] from 	[dbo].[EquipmentParamType]
			where ([TypeId]=@TypeId)
				and ([Name] = @Name);
			Return @Result;
	end try
	begin catch
		Set @Result = -1;
		Return @Result;
	end catch
GO

-- =============================================
-- dbo.uspDeleteParamTypes
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspDeleteParamTypes' 
)
   DROP PROCEDURE dbo.uspDeleteParamTypes
GO

CREATE PROCEDURE dbo.uspDeleteParamTypes
	@id int
AS
	delete from [dbo].[EquipmentParamType]
	where [id] = @id
GO


