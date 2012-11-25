set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chamara Dissanayaka
-- Create date: 21-11-2012
-- Description:	Get Max Student Code Code
-- =============================================

--exec [Sp_GetNextStudentID]

ALTER PROCEDURE [dbo].[Sp_GetNextStudentID] 
	
AS
BEGIN
	
	SET NOCOUNT ON;

--SELECT 'STU'+(RIGHT('00'+convert(varchar,MAX(substring((StudentID),4,datalength(StudentID)))+1),3)) 'StudentID' 
--FROM dbo.Registration

SELECT Max(StudentID)+1
FROM dbo.Registration

END





