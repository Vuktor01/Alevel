USE AdventureWorks2019;
--1
SELECT * FROM Sales.Customer;

--2
SELECT * FROM Sales.Store ORDER BY Name;

--3
SELECT TOP 10 * FROM HumanResources.Employee WHERE BirthDate > '1989-09-28';

--4
SELECT NationalIDNumber, LoginID, JobTitle FROM HumanResources.Employee WHERE RIGHT(LoginID, 1) = '0' ORDER BY JobTitle;

--5
SELECT * FROM Person.Person WHERE YEAR(ModifiedDate) = 2008 AND MiddleName IS NOT NULL AND Title IS NULL;

--6
SELECT DISTINCT d.Name FROM HumanResources.EmployeeDepartmentHistory edh JOIN HumanResources.Department d ON edh.DepartmentID = d.DepartmentID;

--7
SELECT TerritoryID, MAX(CommissionPct) AS MaxCommissionPct FROM Sales.SalesPerson WHERE CommissionPct > 0 GROUP BY TerritoryID;

--8
SELECT * FROM HumanResources.Employee WHERE VacationHours = (SELECT MAX(VacationHours) FROM HumanResources.Employee);

--9
SELECT * FROM HumanResources.Employee WHERE JobTitle IN ('Sales Representative', 'Network Administrator', 'Network Manager');