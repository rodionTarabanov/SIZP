
--======================================
--  Create T-SQL Trigger Template
--======================================
USE [SIZP1]
GO

IF OBJECT_ID ('trgInsertEquipmentType','TR') IS NOT NULL
   DROP TRIGGER dbo.trgInsertEquipmentType 
GO

CREATE TRIGGER dbo.trgInsertEquipmentType  
   ON  [dbo].[EquipmentTypes]
   AFTER insert
AS 
begin
	Declare @pasportDataTable nvarchar(20);
	declare @testDataTable nvarchar(20);
	Select @pasportDataTable = N'pasport_' + [TableSuffix]
		, @testDataTable = N'test_' + [TableSuffix] from inserted
	exec(
			N'CREATE TABLE [dbo].[' + @pasportDataTable + N']('
				+'[id] [int] IDENTITY(1,1) NOT NULL,'
				+'[EqID] [int] NOT NULL,'
				+'[Type] [nvarchar](20) NOT NULL,'
				+'[InvNum] [nvarchar](10) NULL,'
				+'[SerNum] [nvarchar](10) NULL,'
				+'[Manufacturer] [nvarchar](20) NULL,'
				+'[ManufactureDate] [datetime] NULL,'
				+'[CommisioningDate] [date] NULL,'
				+'[JSONdata] [nvarchar] (max) NULL,'
			 +'CONSTRAINT [PK_'+@pasportDataTable +'] PRIMARY KEY CLUSTERED '
			+'('
				+'[id] ASC'
			+') WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]'
			+') ON [PRIMARY]'
		);
	exec (
			'CREATE TABLE [dbo].['+@testDataTable+']('
			+'[id] [int] IDENTITY(1,1) NOT NULL,'
			+'[EqID] [int] NOT NULL,'
			+'[DateOfCheck] [datetime] NOT NULL,'
			+'[NextDateOfCheck] [datetime] NULL,'
			+'[JSONCheckParams] [nvarchar](max) NULL,'
		 +'CONSTRAINT [PK_'+ @testDataTable +'] PRIMARY KEY CLUSTERED '
		+'('
		+'[id] ASC'
		+') WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]'
		+') ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]'
	)
end
GO

