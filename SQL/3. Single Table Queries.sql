--#1
SELECT custid, companyname, contactname, country
FROM Sales.Customers
WHERE country IN ('Mexico', 'Canada', 'USA')
ORDER BY country, custid;
GO

--#2
SELECT *
FROM Sales.Orders
WHERE orderdate LIKE '2015-04___';
GO

--#3
SELECT productname, productid
FROM Production.Products
WHERE categoryid = 4;
GO

--#4
SELECT DISTINCT empid
FROM Sales.Orders
WHERE shippeddate LIKE '_____12%' AND shipcountry = 'Germany';
GO

--#5
--need to sum
SELECT *
FROM Sales.OrderDetails
WHERE productid = 19
GO

--SUM of all prices of those items that got a discount W/O discount
SELECT SUM(qty*unitprice) AS totalprice
FROM Sales.OrderDetails
WHERE productid = 19 AND
discount > 0;
GO

--SUM of all prices of those items that got a discount W/discount
SELECT SUM(qty*unitprice*(1-discount)) AS netpricewithdiscounted
FROM Sales.OrderDetails
WHERE productid = 19 AND
discount > 0;
GO

--#6
SELECT title, firstname, lastname
FROM HR.Employees
ORDER BY title, firstname, lastname;
GO

--#7
	--LEN(contactname) gets the length of the name (A)
	--CHARINDEX(',', contactname) gets the length until comma occurs (B)
	--RIGHT(contactname, A-B) starts to return the characters after the ','
	--TRIM removes white spaces
SELECT companyname,
	TRIM(RIGHT(contactname, LEN(contactname)-CHARINDEX(',', contactname))) AS firstnameonly
FROM Sales.Customers
ORDER BY firstnameonly ASC;
GO

--#8
SELECT contactname
FROM Sales.Customers
ORDER BY contactname ASC;
GO

--#9
SELECT productname, productid
FROM Production.Products
WHERE categoryid = 7 AND
discontinued = 1;
GO

--#10
SELECT DATEDIFF(DAY, '1994-02-24', SYSDATETIME());
--9835 Days
GO