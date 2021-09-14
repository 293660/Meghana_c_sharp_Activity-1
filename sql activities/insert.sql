CREATE PROC usp_Insert(@DepartmentID INT, @Name VARCHAR(50), @GroupName VARCHAR(50))
AS
BEGIN
DECLARE @DeptID INT
DECLARE @DeptName VARCHAR(50)
INSERT INTO HumanResources.Department([Name],[GroupName],[ModifiedDate]) VALUES (@Name,@GroupName,GETDATE())
END
GO
EXECUTE usp_Insert 8, 'Industry', 'ITGroup'
EXECUTE usp_Insert 8, 'DeliveryDept', 'Deliverygroup'
SELECT * FROM [HumanResources].[Department]
