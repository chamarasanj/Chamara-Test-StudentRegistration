set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Chamara Dissanayaka
-- Create date: 24-11-2012
-- Description:	Manage Student
-- =============================================



ALTER PROCEDURE [dbo].[SP_ManageStudent]

@StudentID int,
@Name varchar(100),
@DOB datetime,
@GradePointAvg numeric(18,2),
@Active bit
        
AS
BEGIN
	
	SET NOCOUNT ON;

IF NOT EXISTS (SELECT * FROM dbo.Registration WHERE StudentID=@StudentID)
BEGIN

INSERT INTO dbo.Registration
VALUES (@StudentID,@Name,@DOB,@GradePointAvg,@Active)

END

ELSE

BEGIN

UPDATE dbo.Registration
SET 
--StudentID=@StudentID,
[Name]=@Name,
DOB=@DOB,
GradePointAvg=@GradePointAvg,
Active=@Active
WHERE StudentID=@StudentID

END



END




