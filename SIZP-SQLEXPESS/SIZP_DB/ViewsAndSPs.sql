USE [SZIP]
GO
/****** Object:  View [dbo].[SSGroups]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- [dbo].[SSGroups]
-- =============================================
IF object_id(N'dbo.SSGroups', 'V') IS NOT NULL
	DROP VIEW [dbo].[SSGroups]
GO

CREATE VIEW [dbo].[SSGroups]
	AS SELECT Distinct [SSGroup] FROM [dbo].[Substations]
GO
/****** Object:  View [dbo].[vwEquipment]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- [dbo].[vwEquipment]
-- =============================================
IF object_id(N'dbo.vwEquipment', 'V') IS NOT NULL
	DROP VIEW [dbo].[vwEquipment]
GO

CREATE VIEW [dbo].[vwEquipment]
AS
SELECT        eq.Name, eq.Position, eq.IsPartOf, eq.Manufacturer, eq.SerialNum, eq.InventoryNum, eq.DateOfManufacture, eq.DateOf—ommissioning, ss.Id
FROM            dbo.Equipment AS eq INNER JOIN
                         dbo.Substations AS ss ON eq.SSId = ss.Id
GO
/****** Object:  View [dbo].[vwSubstations]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- [dbo].[vwSubstations]
-- =============================================
IF object_id(N'dbo.vwSubstations', 'V') IS NOT NULL
	DROP VIEW [dbo].[vwSubstations]
GO

CREATE VIEW [dbo].[vwSubstations] AS
SELECT
	SS.[Id]
	, SS.[Region]
	, SS.[Substation]
	, CONCAT(CAST(hvc.Value AS nvarchar(5)),
		N'/', CAST(mvc.Value AS nvarchar(5)),
		N'/', CAST(lvc.Value AS nvarchar(5))) as Voltage
	, SS.[SSGroup]
	, SizpGr.[ShortName]
FROM dbo.Substations AS SS
	INNER JOIN [dbo].[VoltageClasses] AS hvc ON SS.HVClass = hvc.id
	INNER JOIN [dbo].[VoltageClasses] AS mvc ON SS.MVClass = mvc.id
	INNER JOIN [dbo].[VoltageClasses] AS lvc ON SS.LVClass = lvc.id
	Inner join [dbo].[SIZPGroup] as SizpGr on ss.SIZPGroupId = SizpGr.id
union
SELECT
	SS.[Id]
	, SS.[Region]
	, SS.[Substation]
	, CONCAT(CAST(hvc.Value AS nvarchar(5)),
		N'/', CAST(lvc.Value AS nvarchar(5)))  as Voltage
	, SS.[SSGroup]
	, SizpGr.[ShortName]
FROM dbo.Substations AS SS
	INNER JOIN [dbo].[VoltageClasses] AS hvc ON SS.HVClass = hvc.id
--	INNER JOIN [dbo].[VoltageClasses] AS mvc ON SS.MVClass = mvc.id
	INNER JOIN [dbo].[VoltageClasses] AS lvc ON SS.LVClass = lvc.id
	Inner join [dbo].[SIZPGroup] as SizpGr on ss.SIZPGroupId = SizpGr.id
	where SS.[MVClass] is null

GO

/****** Object:  StoredProcedure [dbo].[uspAddEquipmentType]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- [dbo].[uspAddEquipmentType]
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspAddEquipmentType' 
)
   DROP PROCEDURE [dbo].[uspAddEquipmentType]
GO

CREATE PROCEDURE [dbo].[uspAddEquipmentType]
	@EqType	nvarchar(255)
	, @DiagramPos nvarchar(10)
	, @CheckPeriodYear int = null
	, @ReportTemplate nvarchar(50) = null
AS
	Declare @id int = -1
	insert into [dbo].[EquipmentType] (
		[EqType]
		, [DiagramPos]
		, [CheckPeriodYear]
		, [ReportTemplate]
		)
	Values(@EqType, @DiagramPos, @CheckPeriodYear, @ReportTemplate)
	Select distinct @id=[id] from [dbo].[EquipmentType]
		where ([EqType] = @EqType) and ([DiagramPos] = @DiagramPos)
	return @Id
GO
/****** Object:  StoredProcedure [dbo].[uspGetMeasEqForSIZP]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- [dbo].[uspGetMeasEqForSIZP]
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspAddEquipmentType' 
)
   DROP PROCEDURE [dbo].[uspGetMeasEqForSIZP]
GO

CREATE PROCEDURE [dbo].[uspGetMeasEqForSIZP]
	@SIZPid int
AS
	Select Distinct 
	MEq.[EqType] as N'¬≥‰ Ó·ÓÛ‰Ó‚‡ÌËˇ'
	, MEq.[Reference] as N'“ËÔ Ó·ÓÛ‰Ó‚‡ÌËˇ'
	from [dbo].[MeasuringEquipment] as MEq
	inner join [dbo].[SIZPGroup] as Sgrp on (Meq.[SIZPGroupId] = Sgrp.[id])
	where MEq.[SIZPGroupId] = @SIZPid
	Return 0
GO


/****** Object:  StoredProcedure [dbo].[uspUpdateEquipment]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- [dbo].[uspUpdateEquipment]
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspUpdateEquipment' 
)
USE [SZIP]
GO

/****** Object:  StoredProcedure [dbo].[uspUpdateEquipment]    Script Date: 23.03.2022 01:14:45 ******/
DROP PROCEDURE [dbo].[uspUpdateEquipment]
GO

/****** Object:  StoredProcedure [dbo].[uspUpdateEquipment]    Script Date: 23.03.2022 01:14:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspUpdateEquipment]
	@EqType nvarchar (255)
	, @SSID int
	, @DiagramPos nvarchar (10)
	, @CheckPeriodYear int
	, @Name nvarchar (50)
	, @Position nvarchar (10)
	, @IsPartOf int = 0
	, @Manufacturer nvarchar (50)
	, @SerialNum nvarchar (50)
	, @InventoryNum nvarchar (50)
	, @DateOfManufacture date
	, @DateOf—ommissioning date
	--, @Id int = -1 output

AS
	
	declare @Id int = -1
	declare @EqTypeID int = null;
	Set @EqTypeID= (select distinct [id] from [dbo].[EquipmentType]
			where [EqType]=@EqType);

	if @EqTypeID = null
	 begin	
		execute @id = dbo.uspAddEquipmentType @EqType, @DiagramPos, null --, @EqTypeID;
	 end;
	
	--declare @SSID int = null
	--Set @SSID = (select distinct [id] from [dbo].[Substations]
	--		where [Substation] = @Substation)
	
	begin try   
		Select distinct @Id = [id]
				from  [dbo].[Equipment]
				where 
				([SSId] = @SSID)
				and ([TypeId] = @EqTypeID)
				and ([Position] = @Position)
		print @id;
		if @Id = -1
			Insert into [dbo].[Equipment] (
					[SSId]
					, [TypeId]
					, [Name]
					, [Position]
					, [IsPartOf]
					, [Manufacturer]
					, [SerialNum]
					, [InventoryNum]
					, [DateOfManufacture]
					, [DateOf—ommissioning]
					)
			Values (
				@SSID
				, @EqTypeID
				, @Name
				, @Position
				, @IsPartOf
				, @Manufacturer
				, @SerialNum
				, @InventoryNum
				, @DateOfManufacture
				, @DateOf—ommissioning
				);
		else
			UPDATE [dbo].[Equipment]
				Set	
					[SSId] = @SSID
					, [TypeId] = @EqTypeID
					, [Name] = @Name
					, [Position] = @Position
					, [IsPartOf] =@IsPartOf
					, [Manufacturer] = @Manufacturer
					, [SerialNum] = @SerialNum
					, [InventoryNum] = @InventoryNum
					, [DateOfManufacture] = @DateOfManufacture
					, [DateOf—ommissioning] = @DateOf—ommissioning
			where
				[dbo].[Equipment].[id] = @Id;
	end try
	begin catch
		Set @id = -1
	end catch;
	return @id
GO


/****** Object:  StoredProcedure [dbo].[uspUpdateParams]    Script Date: 23.03.2022 00:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- [dbo].[uspUpdateParams] 
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspUpdateParams' 
)
   DROP PROCEDURE [dbo].[uspUpdateParams]
GO

CREATE PROCEDURE [dbo].[uspUpdateParams]
	@Substation nvarchar(50)
	, @Position nvarchar(50)
	, @Name nvarchar(50)
	, @Unit nvarchar(10)
	, @IsStatic bit = 0
	, @Value sql_variant
	, @MinValue sql_variant
	, @MaxValue sql_variant
	, @ReportField nvarchar(20)
AS
	Declare @Res int = -1;
	Declare @EqId int = -1;
	Select distinct @EqId = [dbo].[Equipment].[id] from [dbo].[Equipment] inner join [dbo].[Substations]
			ON ([dbo].[Equipment].[SSId] = [dbo].[Substations].[Id])
		where
			([dbo].[Substations].[Substation] = @Substation)
			and ([dbo].[Equipment].[Position] = @Position);
	if 	@EqId > 0
	begin
		declare @EqParamId int = -1;
		select distinct @EqParamId = [id] from [dbo].[EquipmentParams]
			where
				([EquipmentId] = @EqId)
				and ([Name] = @Name);
		if @EqParamId >0
			begin
				Update [dbo].[EquipmentParams]
					Set 
						[Unit]= @Unit
						, [IsStatic]= @IsStatic
						, [Value]= @Value
						, [MinValue]= @MinValue
						, [MaxValue]= @MaxValue
						, [ReportField] = @ReportField;
				Set @Res = 0;
			end		
		else
			begin
				insert into [dbo].[EquipmentParams](
					[EquipmentId]
					,[Name]
					,[Unit]
					,[IsStatic]
					,[Value]
					,[MinValue]
					,[MaxValue]
					,[ReportField]
					)
				values (
					@EqId
					,@Name
					,@Unit
					,@IsStatic
					,@Value
					,@MinValue
					,@MaxValue
					,@ReportField
					)
				Set @Res = 1;
			end;		
	end;
	Return @Res;
GO

-- =============================================
-- [dbo].[uspSelectEqForSS]
-- =============================================

-- Drop stored procedure if it already exists
IF EXISTS (
  SELECT * 
    FROM INFORMATION_SCHEMA.ROUTINES 
   WHERE SPECIFIC_SCHEMA = N'dbo'
     AND SPECIFIC_NAME = N'uspSelectEqForSS' 
)
   DROP PROCEDURE [dbo].[uspSelectEqForSS]
GO

CREATE PROCEDURE [dbo].[uspSelectEqForSS]
	@SSId
AS
SELECT 
	eqt.[EqType]
	, eqt.[DiagramPos]
	, eq.[Name]
	, eq.[Position]
	, eq.[IsPartOf]
	, eq.[Manufacturer]
	, eq.[SerialNum]
	, eq.[InventoryNum]
	, eq.[DateOfManufacture]
	, eq.[DateOf—ommissioning]
	
FROM dbo.Equipment AS eq INNER JOIN
      dbo.EquipmentType AS eqt ON eq.[TypeId] = eqt.[id]
where eq.[SSId] = @SSId
GO

-- =============================================
-- Example to execute the stored procedure
-- =============================================
EXECUTE <Schema_Name, sysname, Schema_Name>.<Procedure_Name, sysname, Procedure_Name> <value_for_param1, , 1>, <value_for_param2, , 2>
GO




EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "eq"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ss"
            Begin Extent = 
               Top = 6
               Left = 286
               Bottom = 136
               Right = 460
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwEquipment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwEquipment'
GO
