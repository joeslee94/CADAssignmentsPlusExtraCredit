-- 2
-- Explain what’s wrong in the following query and provide a correct alternative
USE TSQLV4
SELECT C.custid, C.companyname, O.orderid, O.orderdate
FROM Sales.Customers AS C
  INNER JOIN Sales.Orders AS O
    ON C.custid = O.custid;
GO

--3
--Return US customers, and for each customer return the total number of orders and total quantities
USE TSQLV4
SELECT C.custid, COUNT(DISTINCT O.orderid) AS totalnumberoforders, SUM(D.qty) AS totalquantities
FROM Sales.Customers AS C
 INNER JOIN Sales.Orders AS O
  ON C.custid = O.custid
 INNER JOIN Sales.OrderDetails AS D
  ON O.orderid = D.orderid
WHERE C.country = 'USA'
GROUP BY C.custid; --this is key to execute
GO

--4
--Return customers and their orders, including customers who placed no orders
SELECT C.custid, C.companyname, O.orderid, O.orderdate
FROM Sales.Customers AS C
 LEFT OUTER JOIN Sales.Orders AS O
  ON C.custid = O.custid
ORDER BY C.custid;
GO



