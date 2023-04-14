BEGIN TRY 
BEGIN TRANSACTION AddDeptAndEmp;
DECLARE @deptId int;
Insert into tblDept values('TempDB@Dept');
Set @deptId = @@IDENTITY
PRINT @deptId
Insert into tblEmployee(EmpName, EmpEmail, EmpPhone, EmpSalary, DeptId) Values('Mahesh','mahes@gmail.com', 9848033445, 56000,  @deptId)
COMMIT TRANSACTION AddDeptAndEmp;
END TRY
BEGIN CATCH
  IF @@ERROR > 0
  ROLLBACK TRANSACTION AddDeptAndEmp
END CATCH

Delete FRom tblDept Where DeptId > 7
Select * from tblDept

Select * from tblEmployee