--#1
--Find the Most Recent Order for Each Customer
--Problem: Given an `Orders` table
--with columns `OrderID`, `CustomerID`, and `OrderDate`,
--find the most recent order date for each customer.
--Table Structure:

CREATE DATABASE QuestTest2;
USE QuestTest2;

CREATE TABLE Orders (
OrderID INT,
CustomerID INT,
OrderDate DATE
);

INSERT INTO Orders (OrderID, CustomerID, OrderDate)VALUES
(1,101,'2022-04-18'),
(2,102,'2020-09-10'),
(3,103,'2012-06-09'),
(4,104,'2023-01-23'),
(5,105,'2021-12-29')
INSERT INTO Orders (OrderID, CustomerID, OrderDate)VALUES(6,101,'2022-04-19');
INSERT INTO Orders (OrderID, CustomerID, OrderDate)VALUES(7,101,'2022-04-17');

--Find the Most Recent Order for Each Customer
select OrderID, CustomerID, OrderDate 
from Orders
where OrderDate = (select max(OrderDate) from Orders);

select OrderID, CustomerID, OrderDate
from Orders as o
where OrderDate = (select max(OrderDate) from Orders as r
where o.CustomerID=r.CustomerID);

--#2
--Find the Top N Salespersons by Sales
--Problem:
--Given a table `Sales`
--with columns `SalesPersonID`, `SaleAmount`, and `SaleDate`,
--find the top 3 salespersons by total sales amount.
--Table Structure:

CREATE TABLE Sales (
SalesPersonID INT,
SaleAmount DECIMAL(10, 2),
SaleDate DATE
);
drop table Sales;

INSERT INTO Sales(SalesPersonID, SaleAmount,SaleDate) VALUES
(1, 2500.00, '2023-09-06'),
(2, 13000.50, '2022-06-13'),
(3, 3000.19, '2015-10-03'),
(4, 4600.09, '2002-12-25'),
(5, 50000.13, '2017-11-02');
INSERT INTO Sales(SalesPersonID, SaleAmount,SaleDate) VALUES(5, 50060.13, '2018-11-02');

select * from Sales;

--Find the Top N Salespersons by Sales
select SalesPersonId from Sales
group by SalesPersonId
order by sum(SaleAmount) desc;

select SalesPersonId, sum(SaleAmount) as Total_Sales from Sales
group by SalesPersonId
order by Total_Sales desc;

select SaleDate, SalesPersonId, SaleAmount from Sales
order by SaleAmount desc;
--#3
--Find Orders with the Largest Order Value
--Problem: Given an `Orders` table
--with columns `OrderID`, `CustomerID`, and `OrderValue`,
--find the order with the largest order value.

--drop table Orders;
CREATE TABLE Orders (
OrderID INT,
CustomerID INT,
OrderValue INT
);

INSERT INTO Orders (OrderID, CustomerID, OrderValue)VALUES
(1,101,25000),
(2,102,1600),
(3,103,14500),
(4,104,250),
(5,105,10500);

--Find Orders with the Largest Order Value
select OrderID, CustomerID, OrderValue from Orders
where OrderValue = (select max(OrderValue) from Orders);

--drop table Orders;

--#4
--Find the Average Sales Per Customer
--Problem:
--Given an `Orders` table
--with columns `OrderID`, `CustomerID`, and `SaleAmount`,
--calculate the average sales amount per customer.


CREATE TABLE Orders (
OrderID INT,
CustomerID INT,
SalesAmount INT
);
-- (OR)  select OrderID, CustomerID, OrderValue as SalesAmount from Orders;
INSERT INTO Orders (OrderID, CustomerID, SalesAmount)VALUES
(1,101,25000),
(2,102,1600),
(3,102,14500),
(4,105,250),
(5,105,10500);

select * from Orders;

--Find the Average Sales Per Customer
select CustomerID, avg(SalesAmount) as Avg_Sales_Per_Customer 
from Orders
group by CustomerID;

--drop table Sales;

--#5
--Find the Day with the Highest Sales
--Problem: Given a `Sales` table
--with columns `SaleAmount` and `SaleDate`,
--find the day with the highest total sales.

CREATE TABLE Sales(
SalesAmount INT,
SalesDate DATE
);

INSERT INTO Sales (SalesAmount, SalesDate)VALUES
(25000,'2022-04-18'),
(13500,'2020-04-18'),
(229550,'2012-01-23'),
(80920,'2023-01-23'),
(3700,'2021-12-29');

select * from Sales;

--to find the date with max sale amount 
select SalesAmount, SalesDate from Sales
where SalesAmount=(select max(SalesAmount) from Sales);

--to find day with highest sales
select top 1 SalesDate, sum(SalesAmount) as TOTAL_SALES_OF_THE_DAY 
from Sales
group by SalesDate
order by TOTAL_SALES_OF_THE_DAY desc;

select SalesDate, sum(SalesAmount) as TOTAL_SALES_OF_THE_DAY 
from Sales
group by SalesDate
order by TOTAL_SALES_OF_THE_DAY desc;