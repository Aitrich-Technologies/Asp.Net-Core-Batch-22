create table CustomersUp(CustomerID int primary key,FirstName varchar(50),LastName varchar(50),Email varchar(50),UserName varchar(50));
insert into CustomersUp(CustomerID,FirstName,LastName,Email,UserName) values 
						(111,'tony','tom','tonytom@gmail.com','to123'),
						(112,'sony','sam','sonysam@gmail.com','sam456'),
						(113,'tom','toss','tomtoss@gmail.com','toss123');
						select * from CustomersUp;
SELECT UPPER(FirstName) AS FirstName, UPPER(LastName) AS LastName
FROM CustomersUp;
select concat(FirstName, LastName) as Name from CustomersUp;
select substring(UserName,1,4) from CustomersUp;
select Email,LENGTH (Email) as Length_email from CustomersUp;
create table Retail_Store(SaleID int primary key,ProductName varchar(50),Category varchar(50),Quantity int,PricePerUnit decimal(10,2),SaleDate date);
insert into Retail_Store(SaleID,ProductName,Category,Quantity,PricePerUnit,SaleDate) values
						(1	,'Laptop	','Electronics	',2	,1000.00	,'2025-01-10'),
						(21,'Fridge','electronics',1,370000,'2024-03-12'),
						(22,'Oven','home',1,30000,'2024-04-05');
SELECT AVG(PricePerUnit) AS average_price;