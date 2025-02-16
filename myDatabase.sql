USE [DBNotKayit]
GO
/****** Object:  Table [dbo].[STULESSON]    Script Date: 19.06.2024 15:49:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STULESSON](
	[STU_ID] [smallint] IDENTITY(1,1) NOT NULL,
	[STU_NUM] [char](4) NULL,
	[STU_Name] [varchar](15) NULL,
	[STU_Sname] [varchar](20) NULL,
	[STU_Exam1] [tinyint] NULL,
	[STU_Exam2] [tinyint] NULL,
	[STU_Exam3] [tinyint] NULL,
	[AVERAGE] [decimal](18, 2) NULL,
	[Situation] [bit] NULL
) ON [PRIMARY]
GO
