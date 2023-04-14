-----Stored Procedures and Functions------------------
--Stored Procedures are similar to Functions that are predefined and preparsed without a need to reparse it when we use the Proc. 
Alter Procedure InsertEmployee
(
	@empName varchar(50),
	@empEmail varchar(50),
	@empPhone bigint,
	@empSalary int,
	@deptId int,
	@cityId int,
	@empId int OUTPUT
)
AS 
Insert into tblEmployee values(@empName, @empEmail, @empPhone, @empSalary, @deptId, @cityId)
Set @empId = @@IDENTITY
GO

-------------------Call the Stored Proc---------------------------
DECLARE @id int
EXEC InsertEmployee
       @empName = 'Daniel Gibbs',
	   @empEmail ='db_987@gmail.com',
	   @empPhone = 9876555434,
	   @empSalary = 45000,
	   @deptId = 3,
	   @cityId = 5,
	   @empId = @id OUTPUT

	   PRINT @id
Select @id as 'GENERATEDID'


--TODO: Create Stored procs for Deletion based on ID, Updation based on ID and FindEmployee based on Id. 

-------------------------------Functions in SQL server------------------------------
--Functions are one kind that can be used as an Expression within a Query which cannot be done with Stored Proc. 
-- 2 kinds of functions: Scalar Value Functions(SVF) that return only one single value. Another one is Table Value Function(TVFs) that return a Temp Table that contains data of a Query. 
--Creating of the Function and usage of it is very similar to Stored Procedure. 

Create Function GetDeptName(@id int)
RETURNS varchar(30)
AS
BEGIN
DECLARE @deptName varchar(30)
Set @deptName = (SElect tblDept.DeptName from tblDept Where tblDept.DeptId = @id)
RETURN @deptName
END

PRINT dbo.GetDeptName(1)

Select dbo.GetDeptName(2) as DeptName

---------------------Functions on Date-----------------------------------
PRINT getDate()

Select FORMAT(getDate(), 'dd/MM/yyyy') as Date
Select FORMAT(getDate(), 'dd/MMM/yyyy') as Date
Select FORMAT(getDate(), 'dddd MMMM yyyy') as Date
Select FORMAT(getDate(), 'hh:mm:ss tt') as Time


Create Function CreateDate(@date Date)
RETURNS VARCHAR(30)
AS 
BEGIN
DECLARE @result varchar(30)
Set @result = '' + DATENAME(day,@date) + ' ' + DATENAME(month, @date) + ' ' + DATENAME(year, @date)
RETURN @result
END

select dbo.CreateDate(getDate())

-----------Function to get the Age based on Date--------------
Create Function GetAge(@dob Date)
RETURNS INT
AS
BEGIN
Declare @age int = 0
Set @age = DATEDIFF(year, @dob, getDate())
RETURN @age
END

PRINT dbo.GetAge('01/12/1976')
--Create a table with Columns of BookingID, Description, Date
--INsert some records to it
--Find the data based on Date. 
--Check if U need UR CreateDate Function
--------------------Multiple Values,U should create Table value functions----------

Create Function GetAllEmployees()
RETURNS TABLE
AS
RETURN(SElect * from tblEmployee)

SElect Empname from dbo.GetAllEmployees();