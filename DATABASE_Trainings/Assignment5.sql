CREATE TABLE EmployeeHistory(EmpID bigint, ModifiedDate date)


ALTER TRIGGER Trg_Salary_Insert ON EMPLOYEE
FOR UPDATE
AS
BEGIN
INSERT INTO EmployeeHistory
SELECT EmpID, getdate()
FROM inserted
END

--INSERT INTO EMPLOYEE VALUES('Paras','1999-02-16','paras12@yahoo.in',7850874039,201,15000,'Python')

UPDATE EMPLOYEE SET SALARY=17000 WHERE EmpName='Paras'

SELECT * FROM EMPLOYEE
SELECT * FROM EmployeeHistory;


DISABLE TRIGGER Trg_Salary_Insert ON EMPLOYEE;
ENABLE TRIGGER Trg_Salary_Insert ON EMPLOYEE;


CREATE TABLE EmployeeDeleteHistory(EmpID bigint,DeletedDate date)

ALTER TRIGGER Trg_AfterDeleteTrigger
ON EMPLOYEE
AFTER DELETE
AS
INSERT INTO EmployeeDeleteHistory VALUES ((SELECT TOP 1  deleted.EmpID FROM deleted), getdate())
GO

DELETE FROM EMPLOYEE  WHERE EmpName='Paras'

SELECT * FROM EmployeeDeleteHistory;


---------------INDEXES--------------

CREATE INDEX index_EmpID  
ON EMPLOYEE (EMPName,Email); 

ALTER INDEX index_EmpID 
ON EMPLOYEE
DISABLE;






DROP INDEX index_EmpID on EMPLOYEE;