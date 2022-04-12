USE [SIZP1]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[uspUpdateEquipment]
		@Equipment_id = 0,
		@EquipmentClasses_EquipmentClassName = N'Силовий трансформатор',
		@EquipmentPassport_Type = N'ТМ-4000/35',
		@VoltageClasses_Value = 35,
		@VoltageClasses_Unit = N'кВ',
		@Equipment_DiagramPos = N'1Т',
		@Equipment_Feeder = NULL,
		@EquipmentPassport_InvNum = NULL,
		@EquipmentPassport_SerNum = N'111643',
		@EquipmentClasses_CheckPeriodYear = 3,
		@EquipmentClasses_ReportTemplate = NULL,
		@EquipmentPassport_Manufacturer = NULL,
		@EquipmentPassport_ManufactureDate = N'01.01.1980',
		@EquipmentPassport_CommisioningDate = NULL,
		@EquipmentPassport_JSONParams = NULL,
		@Equipment_SSID = 190

SELECT	'Return Value' = @return_value

GO
