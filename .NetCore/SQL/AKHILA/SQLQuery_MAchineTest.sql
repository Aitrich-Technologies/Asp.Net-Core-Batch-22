--CUSTOMERS TABLE--

CREATE TABLE CUSTOMERS(CustomerID INT PRIMARY KEY,CustomerName VARCHAR(20), City VARCHAR(20))
INSERT INTO CUSTOMERS(CustomerID,CustomerName,City) VALUES 
					(1,'Alice','New York'),(2,'Bob','Chicago'),
					(3,'Charlie','Los Angeles'),(4,'David','Houston')
SELECT * FROM CUSTOMERS



--ORDERS--
CREATE TABLE ORDERS(OrderID INT PRIMARY KEY, CustomerID INT FOREIGN KEY REFERENCES CUSTOMERS(CustomerID), 
					OrderDate DATE, TotalAmount FLOAT)
INSERT INTO ORDERS(OrderID,CustomerID,OrderDate,TotalAmount) VALUES
					(101,1,'2024-02-15',500),
					(102,2,'2024-02-16',700),
					(103,1,'2024-03-01',200),
					(104,3,'2024-03-05',900),
					(105,2,'2024-03-07',450)
SELECT * FROM ORDERS

--Q1.Write a SQL query to find the total amount spent by each customer.--
SELECT C.CustomerID,C.CustomerName ,SUM(O.TotalAmount) AS TotalAmountSpent
				FROM CUSTOMERS C  JOIN ORDERS O 
				ON C.CustomerID=O.CustomerID
				GROUP BY C.City,C.CustomerName
				ORDER BY TotalAmountSpent DESC;


--Q2. Write a SQL query to find customers who have never placed an order.--

SELECT CUSTOMERS.CustomerID,CUSTOMERS.CustomerName 
				FROM CUSTOMERS  LEFT JOIN ORDERS 
				ON CUSTOMERS.CustomerID=ORDERS.CustomerID
				WHERE ORDERS.CustomerID IS NULL

--Q3. Write a SQL query to find the most recent order placed by each customer.
SELECT C.CustomerID,C.CustomerName,O.OrderId,O.OrderDate
		FROM CUSTOMERS C JOIN ORDERS O ON C.CustomerID=O.CustomerID
		JOIN
		(SELECT CustomerID,MAX(OrderDate) AS MaxOrderDate
			FROM ORDERS GROUP BY CustomerID) X ON O.CustomerID=X.CustomerID AND 
			O.OrderDate=X.MaxOrderDate
			ORDER BY O.OrderDate DESC

--Q4. Write a SQL query to get the customer who spent the highest total amount.
SELECT C.CustomerId,C.CustomerName,O.TotalAmount
		FROM CUSTOMERS C JOIN ORDERS O ON C.CustomerID=O.CustomerID
		ORDER BY O.TotalAmount DESC

--Q5. Write a SQL query to find the number of orders placed in the month of March 2024.
SELECT COUNT(O.OrderID) AS MarchOrders
			FROM ORDERS O
			WHERE MONTH(O.OrderDate)=3 AND YEAR(O.OrderDate)=2024