SELECT * FROM EMPLOYEE


ALTER TABLE EMPLOYEEDETAILS ADD  POSITION VARCHAR(10);

-------USER-DEFINED FUNCTION-------
GO
CREATE FUNCTION getdateformat
(
@DateValue AS Date
)
RETURNS VARCHAR(100)
AS
BEGIN
	RETURN
		DATENAME(DW,@DateValue)+','+
		DATENAME(DAY,@DateValue)+','+
		DATENAME(MONTH,@DateValue)+','+
		DATENAME(YEAR,@DateValue)
END

SELECT EmpID,EmpName,[dbo].[getdateformat](DOB) AS [Date OF Birth] FROM EMPLOYEE

----------Split Function----------
CREATE PROCEDURE uspGetEmployees
    @STRING VARCHAR(100),
	@SEPRATOR VARCHAR(1)=','
AS
BEGIN(
    SELECT *FROM string_split(@STRING,@SEPRATOR)
    )
END

Exec uspGetEmployees '2,3,4,Ajay,6,7,8'

----------
CREATE FUNCTION EmployeeePosition()
RETURNS table
AS
RETURN(SELECT
		VALUE Position
	FROM
		EMPLOYEEDETAILS
		CROSS APPLY STRING_SPLIT(Position, ' '))

CREATE PROCEDURE uspGetEmployeeByPosition
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM EmployeeePosition()
END
GO
EXEC uspGetEmployeeByPosition



----------TABLE TYPES----------
--Local Temporary Table--
CREATE PROCEDURE uspTabletypeLocal

AS 
BEGIN

CREATE TABLE #GETEMPLOYEEINFO(EmpID bigint, EmpName varchar(50),Email nvarchar(50),EmpDesignation nvarchar(20), SALARY decimal(10,2))

INSERT INTO #GETEMPLOYEEINFO 
SELECT E.EmpID,E.EmpName,E.Email,ED.EmpDesignation,E.SALARY FROM EMPLOYEE AS E
INNER JOIN EMPLOYEEDETAILS ED ON E.EmpID=ED.EmpID
WHERE SALARY >16000

SELECT * FROM #GETEMPLOYEEINFO
END

EXEC uspTabletypeLocal

SELECT * FROM #GETEMPLOYEEINFO --This Statement will give error because the table created is loacal to procedure.

---GLOBAL TableType----
CREATE PROCEDURE uspTabletypeGlobal

AS 
BEGIN

CREATE TABLE ##GetEmployeeEInfoGlobal(EmpID bigint, EmpName varchar(50),Email nvarchar(50),EmpDesignation nvarchar(20),SALARY decimal(10,2))

INSERT INTO ##GetEmployeeEInfoGlobal
SELECT E.EmpID,E.EmpName,E.Email,ED.EmpDesignation,E.SALARY FROM EMPLOYEE AS E
INNER JOIN EMPLOYEEDETAILS ED ON E.EmpID=ED.EmpID
WHERE SALARY >16000 order by SALARY desc

SELECT * FROM ##GetEmployeeEInfoGlobal
END

EXEC uspTabletypeGlobal

SELECT * FROM ##GetEmployeeEInfoGlobal --- This Query will run as it is global TableType

-----TABLE-Variables-------


CREATE TABLE Products (
ProductId    bigint PRIMARY KEY,
ProductName VARCHAR(50))

CREATE TYPE ProductType AS TABLE(ProductId  bigint,ProductName VARCHAR(100))

ALTER PROCEDURE uspProductInsert
@ProductType ProductType READONLY
AS
INSERT INTO Products
SELECT * FROM @ProductType
DECLARE @VarProductType AS ProductType
INSERT INTO @VarProductType
VALUES ( 101, 'Apple' )
INSERT INTO @VarProductType
VALUES ( 102, 'Dell'
       )
INSERT INTO @VarProductType
VALUES ( 103, 'Lenovo'
       )
INSERT INTO @VarProductType
VALUES ( 104, 'Toshiba'
       )
INSERT INTO @VarProductType
VALUES ( 105, 'HP'
       )
EXEC uspProductInsert @VarProductType

DROP TABLE Products

SELECT * FROM Products

------SUB-QUERIES-----

SELECT EMPLOYEE.EmpID,EMPLOYEE.EmpName,EMPLOYEE.Email
FROM EMPLOYEE INNER JOIN 
(SELECT TOP 5 EmpDetailsID,EmpID,POSITION FROM EMPLOYEEDETAILS 
ORDER BY EmpID DESC) EMPLOYEEDETAILS ON EMPLOYEE.EmpID = EMPLOYEEDETAILS.EmpID

-------MERGING--------
ALTER TABLE EMPLOYEE ADD DeptName Varchar(20);
    
MERGE EMPLOYEE AS Target
USING DEPARTMENT	AS Source
ON Source.DeptID = Target.DeptID
    

WHEN NOT MATCHED BY Target THEN

    INSERT (DeptID,DeptName) 
    VALUES (Source.DeptID,Source.DeptName)

WHEN MATCHED THEN UPDATE SET
	Target.DeptName=Source.DeptName;

    
-----CTE------
WITH EMPLOYEEDETAILS
AS
(
SELECT [EmpId]
      ,[EmpName]
      ,[Email]
      ,[Contact]
  FROM EMPLOYEE
)
SELECT * FROM EMPLOYEEDETAILS;
--CTE Join
WITH EMPLOYEEDETAILS
AS
(
SELECT E.EMPID,E.EMPNAME,E.CONTACT,E.EMAIL,D.DEPTID,D.DEPTNAME FROM EMPLOYEE AS E RIGHT JOIN DEPARTMENT AS D ON E.DeptID=D.DeptID

)
SELECT * FROM EMPLOYEEDETAILS


