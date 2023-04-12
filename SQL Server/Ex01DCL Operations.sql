--Used to create the Database, Tables, Stored Procedures, Functions and other database objects. 
Create database FnFTraining

--Drop is used to Delete the Database object
Drop Database FnFTraining

--Use the database once it is created. Use makes the IDE execute SQL statements on that perticular database
use FnFTraining
--SP_ are stored Procs which are like functions that is created by SQL server for performing some common operations within the SQL server.
sp_databases --Display all the Dbs of UR SQL server instance

sp_tables --Stored Proc to get all the tables associated with the Current database

sp_columns tblEmployee
--All variables in SQL are prefixed with @. @@ is the variables provided by SQL server itself 
PRINT @@version

DECLARE @vaName INT
Set @vaName = 123
PRINT @vaName


-------------Data Definition Language------------------
Create table tblEmployee
(
	EmpId int primary key IDENTITY(1, 1),
	EmpName varchar(50) NOT NULL, 
	EmpEmail varchar(70) NOT NULL UNIQUE, 
	EmpPhone bigint NOT NULL, 
	EmpSalary int NOT NULL
)
-------Used to Delete the created table from the selected database. 
Drop table tblEmployee

Create table tblDept
(
   DeptId int primary key identity(1,1),
   DeptName varchar(30) NOT NULL
)

ALTER table tblEmployee
Add DeptId int NOT NULL REFERENCES tblDept(DeptId)
--Use NOT NULL only if there are no records in the table. 

ALTER TABLE tblEmployee
--DROP CONSTRAINT FK__tblEmploy__DeptI__47DBAE45
Drop COLUMN DeptId

----------------------------Insert statements------------------
Insert into tblDept VALUES('Human Resources')
Insert into tblDept VALUES('Development')
Insert into tblDept VALUES('BPO')
Insert into tblDept VALUES('Transport')
Insert into tblDept VALUES('IT Help Desk')
Insert into tblDept(DeptName) Values('Utilities')

--The Above syntax works only if the column order and the values order are corresponding. U should mention the column names and the corresponding values specifically if U want to insert values to specific columns of the table.

SELECT * from tblDept
GO --GO Statement is the part of SSMS which allows to execute batches of SQL statements with an optional numeric value for executing so many no of times.

Insert into tblEmployee values('Phani Raj B.N', 'phanirajbn@gmail.com', 9945205684, 56000, 1)
Insert into tblEmployee values('Ramnath Nishad', 'ramnathn@gmail.com', 9856444321, 36000, 2)
Insert into tblEmployee values('Banu Prakash', 'banu_p@gmail.com', 9845078665, 76000, 3)
Insert into tblEmployee values('Vinod K', 'vinodk@gmail.com', 9449184478, 46000, 4)
Insert into tblEmployee values('JoyDip Mondal', 'joydip@gmail.com', 9988766778, 45000, 5)
Insert into tblEmployee values('Murali Sharma', 'muralisharma.com', 9945884123, 56000, 6)

--Update tableName Set colName = 'Value'..... WHERE COLNAME = 'someconditionalVal' 
Update tblEmployee Set DeptId = 2 Where EmpId > 0

Delete From tblEmployee Where EmpID > 3
Select * from tblEmployee

TRUNCATE table tblEmployee

---Assignment--------------------
--Create a new table called tblCity with Id and CityName as Columns. Add some 10 Cities to it. 
--Add a new column to the tblEmployee called CityId and set the CityID as the foreign key to the tblCity.
--Update the CityId of the tblEmployee in a random manner. 
