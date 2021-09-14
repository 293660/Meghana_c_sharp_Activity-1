CREATE PROC usp_Update (@DepartmentID INT, @Name VARCHAR(50), @GroupName VARCHAR(50))
AS
BEGIN
UPDATE [HumanResources].[Department] SET [GroupName] = 'ExecutiveDept' , [Name] = 'Executive Gen' WHERE [DepartmentID] = 16;
END
GO
SELECT * FROM [HumanResources].[Department]