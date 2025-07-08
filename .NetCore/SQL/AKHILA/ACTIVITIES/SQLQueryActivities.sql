create table EmployeeSalary(EmpID int primary key, Name varchar(25) not null, Department varchar(25) not null, Salary decimal(12,2), Location varchar(25));
insert into EmployeeSalary(EmpID,Name,Department,Salary,Location)
values(12,'ATUL','HR',25000,'pune'),
(13,'aditi','SE',40000,'Goa'),(10,'Rohith','CA',75000,'TVM');
select * from EmployeeSalary;
insert into EmployeeSalary(EmpID,Name,Department,Salary,Location)
	values (20,'Arun','HR',50000,'Kochi');
select * from EmployeeSalary;
select * from EmployeeSalary where Department='HR' and Salary>40000;
create table Sales(SaleID int primary key, ProductName varchar(50) not null, Category varchar(20) not null, Quantity int , Price decimal(10,2), SaleDate date not null);
insert into Sales(SaleID, ProductName, Category, Quantity, Price, SaleDate) values
				(102,'Tiffinbox','containers',20,400,'2008-11-11'),
				(110,'Bowl','container',70,350,'2008-10-11'),
				(120,'tv','Electronics',30,50000,'2018-11-11');
select * from Sales;
select Category, Quantity from Sales where Quantity>20;
create table Customers(CustomerID int primary key, FirstName varchar(50) not null, LastName varchar(50) not null, City varchar(50), Phone int);
insert into  Customers(CustomerID, FirstName, LastName, City, Phone)  values
		(111,'Ram','kumar','mumbai',123455),
		(121,'Atul','Syam','pune',3954955),
		(126,'Adil','Syam','Delhi',3954955),
		(125,'Atul','Syam','chennai',3954955);
		select * from Customers;
create table Inventory(ProductID int primary key, ProductName varchar(50) not null, Stock int, ReorderLevel int);
insert into Inventory(ProductID, ProductName, Stock, ReorderLevel) values
			(12,'tv',200,300),(23,'fridge',100,50),(25,'oven',200,400);
select * from Inventory;
select ProductName from Inventory where Stock<ReorderLevel;
create table EmployeeCount(EmpID int primary key, Name varchar(50) not null, Department varchar(50) not null, JoiningDate date);
insert into EmployeeCount(EmpID, Name, Department, JoiningDate) values
			(29,'Ameya','HR','2023-01-11'),
			(30,'tarun','SE','2018-12-11'),
			(32,'tarini','CA','2023-12-11');
			select * from EmployeeCount;
select count(Name) as NumberOFEmployees from EmployeeCount where JoiningDate between '2023-01-01' and '2023-01-31';
create table Students(StudentID int primary key, Name varchar(50) not null, Course varchar(50), Marks int not null);
insert into Students(StudentID, Name, Course, Marks) values
		(12,'Arun','Mathematics',89),
		(11,'adds','Science',90),
		(10,'sasf','Mathematics',92);
		select * from Students;
		update Students set Marks=Marks+5 where Course='Mathematics';
		select * from Students;
create table Users(UserID int primary key, Username varchar(30) not null, Status varchar(10), LastLoginDate date);
insert into Users(UserID, Username, Status, LastLoginDate) values
					(11,'Abc','active','2025-04-20'),
					(12,'sfs','inactive','2023-04-11'),
					(9,'ssffg','active','2025-07-22');
					select * from Users;
delete from Users where Status='inactive' or LastLoginDate<'2024-06-25';
select * from Users;
create table Orders(OrderID int primary key, CustomerID int not null, Amount decimal(10,2), OrderDate date);
insert into Orders(OrderID, CustomerID, Amount, OrderDate) values
			(1,10,5000,'2025-04-11'),
			(2,11,500,'2025-05-11'),
			(3,10,2000,'2025-04-12');
			select * from Orders;

select CustomerID,MAx(Amount) from Orders;


create table Products(ProductID int primary key, ProductName varchar(20), Description varchar(50), Price decimal(10,2));
insert into Products(ProductID, ProductName, Description, Price) values
			(1,'sds','hhbhdsbh hbhbh',340),
			(2,'asd','wireless',500),
			(3,'abcwireless','dkndg',300);
			select * from Products;
select ProductName from PRoducts where ProductName like '%wireless%' or Description like '%wireless%';

create table EmployeeAvg(EmpID int primary key, Name varchar(50), Location varchar(50), Salary decimal(10,2));
insert into EmployeeAvg(EmpID, Name, Location, Salary) values
						(1,'asd','pune',80000),
						(3,'ssd','mumbai',30000),
						(4,'asw','chennai',70000);
						select * from EmployeeAvg;
select 