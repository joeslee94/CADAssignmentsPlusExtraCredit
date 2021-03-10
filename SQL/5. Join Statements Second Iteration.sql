--Exercise 5
--Return customers who placed no orders:
SELECT C.custid, C.companyname
FROM Sales.Customers AS C
LEFT OUTER JOIN Sales.Orders AS O
ON C.custid = O.custid
WHERE O.orderid IS NULL
GO

--Exercise 6
--Return customers with orders placed on February 12, 2016, along with their orders
SELECT C.custid, C.companyname, O.orderid, O.orderdate
FROM Sales.Customers AS C
LEFT OUTER JOIN Sales.Orders AS O
ON C.custid = O.custid
WHERE O.orderdate = '2016-02-12'
GO

--Exercise 1-1
--Write a query that generates five copies of each employee row:
SELECT E.empid, E.firstname, E.lastname, N.n
FROM HR.Employees AS E
CROSS JOIN dbo.Nums AS n
WHERE n <= 5
GO