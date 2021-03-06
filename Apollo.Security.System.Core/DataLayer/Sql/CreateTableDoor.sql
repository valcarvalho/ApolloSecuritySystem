﻿USE [MYCORP]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_Door]
(
	[DoorId] [int] NOT NULL,
	[LockID] [int] NOT NULL,
	[RoomNumber] [int] NOT NULL,

	CONSTRAINT [PK_tbl_tbl_Door] PRIMARY KEY CLUSTERED 
	(
		[DoorId] ASC
	)
	WITH
	(
		PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON
	)
	ON [PRIMARY]
)
ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
