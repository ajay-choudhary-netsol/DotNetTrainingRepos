SELECT * from EMPLOYEE;

SELECT * from DEPARTMENT;

SELECT DeptID from EMPLOYEE 
UNION 
SELECT DeptID from DEPARTMENT

SELECT DeptID from EMPLOYEE 
UNION ALL 
SELECT DeptID from DEPARTMENT


CREATE TABLE EMPLOYEEDETAILS(EmpDetailsID bigint IDENTITY(10,10) not null PRIMARY KEY , EmpID bigint not null,EmpAddress nvarchar(100),
EmpJoinDate Date,EmpDesignation nvarchar(20) DEFAULT 'FRESHER' ,CONSTRAINT FK_Empid FOREIGN KEY (EmpID) REFERENCES EMPLOYEE(EmpID)) 

INSERT INTO EMPLOYEEDETAILS VALUES(2,'PATHANKOT','2022-01-03','Developer')
INSERT INTO EMPLOYEEDETAILS VALUES(3,'GURDASPUR','2022-01-03','QC')
INSERT INTO EMPLOYEEDETAILS VALUES(4,'PATHANKOT','2022-02-08','Designer')
INSERT INTO EMPLOYEEDETAILS VALUES(5,'MOHALI','2021-01-03','Senior Developer')
INSERT INTO EMPLOYEEDETAILS VALUES(6,'GURUGRAM','2021-11-10','Developer')

------VIEWS--------

CREATE VIEW vwEmpData AS SELECT ED.EmpDetailsID,Emp.EmpID,Emp.EmpName,
Emp.Email,Emp.DeptID,ED.EmpJoinDate,ED.EmpDesignation FROM EMPLOYEE Emp,
DEPARTMENT D,EMPLOYEEDETAILS ED
where Emp.EmpID=ED.EmpID
and Emp.DeptID=201;


SELECT * from vwEmpData;

CREATE VIEW vw_EmployeeData AS 
SELECT ED.EmpDetailsID,E.EMPID,E.EMPNAME,D.DEPTNAME,E.EMAIL,ED.EmpDesignation FROM EMPLOYEE AS E
INNER JOIN DEPARTMENT AS D ON E.DeptID=D.DeptID
LEFT JOIN EMPLOYEEDETAILS AS ED ON E.EmpID=ED.EmpID


SELECT * from vwEmployeeData;


---PROCEDUREs---
ALTER PROCEDURE uspGetEmployeeDetails

AS
BEGIN

	SET NOCOUNT ON;

	SELECT ED.EmpDetailsID,Emp.EmpID,Emp.EmpName,Emp.Email,Emp.DeptID,D.DeptName,Emp.Salary from EMPLOYEE Emp
	INNER JOIN  Department AS D ON Emp.DeptID=D.DeptID
	INNER JOIN EMPLOYEEDETAILS AS ED ON Emp.EmpID=ED.EmpID
	
END
GO

exec uspGetEmployeeDetails;

---------PAGINATION-------
--One Way--

DECLARE @PageNumber AS INT
            DECLARE @RowsOfPage AS INT
        DECLARE @MaxTablePage AS FLOAT
        SET @PageNumber=1
        SET @RowsOfPage=4
        SELECT @MaxTablePage = COUNT(*) FROM EMPLOYEE
        SET @MaxTablePage = CEILING(@MaxTablePage/@RowsOfPage)
        WHILE @MaxTablePage >= @PageNumber
        BEGIN
         SELECT ED.EmpDetailsID,E.EmpID,E.EmpName,E.Email,E.DeptID,E.Email,E.Contact,ED.EmpDesignation,E.Salary FROM EMPLOYEE E 
		 INNER JOIN EMPLOYEEDETAILS ED ON E.EmpID=ED.EmpID
        ORDER BY ED.EmpDetailsID DESC
        OFFSET (@PageNumber-1)*@RowsOfPage ROWS
        FETCH NEXT @RowsOfPage ROWS ONLY
        SET @PageNumber = @PageNumber + 1
        END

		 SELECT ED.EmpDetailsID,E.EmpID,E.EmpName,E.Email,E.DeptID,E.Email,E.Contact,ED.EmpDesignation,E.Salary FROM EMPLOYEE E 
		 INNER JOIN EMPLOYEEDETAILS ED ON E.EmpID=ED.EmpID
        ORDER BY ED.EmpDetailsID DESC
		OFFSET 3 ROWS;

--Another Way---
CREATE PROCEDURE uspPagination
@istartRowIndex INT,                                          
@imaximumRows INT                          
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM                            
  (                          
   SELECT ROW_NUMBER() OVER (ORDER BY EmpId)-1 AS Row,* FROM EMPLOYEE                        
  )EMPLOYEE                          
WHERE (Row between (@istartRowIndex) AND @istartRowIndex + (@imaximumRows -1))    
END
GO
EXEC uspPagination @istartRowIndex=1, @imaximumRows=6












