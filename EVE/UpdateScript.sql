﻿USE [E:\USERS\JIMNE\DESKTOP\VISUAL STUDIO PROJECTS\EVE DESKTOP\EVE\SDE.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[UpdateDB]
		@otherDB = N'E:\USERS\JIMNE\DESKTOP\EVE\RECENT SDE\NEW_SDE.MDF'

GO