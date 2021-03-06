--USE [TestDB-Chamara]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 11/25/2012 10:02:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[StudentID] [int] NOT NULL,
	[Name] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DOB] [datetime] NULL,
	[GradePointAvg] [numeric](18, 2) NOT NULL CONSTRAINT [DF_Registration_GradePointAvg]  DEFAULT ((0)),
	[Active] [bit] NOT NULL CONSTRAINT [DF_Registration_Active]  DEFAULT ((0)),
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF