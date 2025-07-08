create table Employees(EmpID int PRIMARY KEY,FirstName varchar(50) not null,LastName varchar(50) not null,DateOfJoining date not null,salary decimal(10,2));
alter table Employees Add Email varchar(100);
select * from Employees;
alter table Employees alter column salary Decimal(12,2);
EXEC sp_rename 'Employees.LastName','SurName','COLUMN';
alter table Employees Drop column Email;
create table Departments(DepId int Primary key,DeptName varchar(50));
alter table Employees Add DeptId int ;
EXEC sp_rename 'Employees.DeptId','DepId','COLUMN';
alter table Employees Add constraint FK Foreign key(DepId) references Dapartments(DepId);
ALTER TABLE Employees ADD CONSTRAINT foeign FOREIGN KEY (DepId) REFERENCES Departments(DepId);




