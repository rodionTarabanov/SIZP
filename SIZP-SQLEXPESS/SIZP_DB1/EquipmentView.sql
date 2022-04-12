USE [SIZP1]
GO

/****** Object:  View [dbo].[EquipmentView]    Script Date: 08.04.2022 14:04:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[EquipmentView]
AS
SELECT        dbo.Equipment.[id]
	, dbo.EquipmentClasses.EquipmentClassName
	, dbo.EquipmentPassport.[Type]
	, CONCAT(CAST(dbo.VoltageClasses.[Value] as nvarchar(5)), dbo.VoltageClasses.Unit) as [VoltageClass]
	, dbo.Equipment.[DiagramPos]
	, dbo.Equipment.Feeder
	, dbo.EquipmentPassport.[InvNum]
	, dbo.EquipmentPassport.[SerNum]
	, dbo.EquipmentClasses.CheckPeriodYear
	, dbo.EquipmentClasses.ReportTemplate
	, dbo.EquipmentPassport.Manufacturer
	, dbo.EquipmentPassport.ManufactureDate
	, dbo.EquipmentPassport.CommisioningDate
	, dbo.EquipmentPassport.JSONParams
	, dbo.Equipment.SSID
FROM            dbo.Equipment INNER JOIN
                         dbo.EquipmentClasses ON dbo.Equipment.EqClassID = dbo.EquipmentClasses.id INNER JOIN
                         dbo.EquipmentPassport ON dbo.Equipment.id = dbo.EquipmentPassport.EquipmentID INNER JOIN
						 dbo.VoltageClasses on dbo.Equipment.VoltageID = dbo.VoltageClasses.id
GO


