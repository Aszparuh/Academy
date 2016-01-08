## Intro to SQL

#### What is SQL?
SQL (Structured Query Language) is a standard interactive and programming language for getting information from and updating a database. Although SQL is both an ANSI and an ISO standard, many database products support SQL with proprietary extensions to the standard language. Queries take the form of a command language that lets you select, insert, update, find out the location of data, and so forth. There is also a programming interface.

#### What is DML?
A data manipulation language (DML) is a family of computer languages including commands permitting users to manipulate data in a database. This manipulation involves inserting data into database tables, retrieving existing data, deleting data from existing tables and modifying existing data. DML is mostly incorporated in SQL databases.

Important commands:
SELECT, UPDATE, INSERT

#### What is DDL?
DDL is abbreviation of Data Definition Language. It is used to create and modify the structure of database objects in database.

Important commands:
CREATE, ALTER, DROP

#### What is Transact-SQL (T-SQL)?
T-SQL (Transact-SQL) is a set of programming extensions from Sybase and Microsoft that add several features to the Structured Query Language (SQL) including transaction control, exception and error handling, row processing, and declared variables. Microsoft's SQL Server and Sybase's SQL server support T-SQL statements.

#### Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
```
SELECT *
FROM [TelerikAcademy].[dbo].[Departments]
```

#### Write a SQL query to find all department names.
```
SELECT [Name] + ' Department' AS 'Department name'
FROM [TelerikAcademy].[dbo].[Departments]
```

#### Write a SQL query to find the salary of each employee.
```
SELECT [FirstName] + ' ' + [LastName] AS [Full name], [Salary]
FROM [TelerikAcademy].[dbo].[Employees]
```

#### Write a SQL to find the full name of each employee.
```
SELECT [FirstName] + ' ' + [LastName] AS [Full name]
FROM [TelerikAcademy].[dbo].[Employees]
ORDER BY [FirstName]
```

#### Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
```
SELECT LOWER([FirstName]) + '.' + LOWER([LastName]) + '@telerik.com' AS [Full Email Address]
FROM [TelerikAcademy].[dbo].[Employees]
```

#### Write a SQL query to find all different employee salaries.
```
SELECT DISTINCT [Salary] AS [Distinct Salary]
FROM [TelerikAcademy].[dbo].[Employees]
```

#### Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
```
SELECT e.[FirstName] + ' ' + e.[MiddleName] + ' ' + e.[LastName] AS [Full Name], e.[JobTitle], d.[Name] AS [Department], a.[AddressText], t.[Name]
FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN [TelerikAcademy].[dbo].[Departments] d
ON e.[DepartmentID] = d.[DepartmentID]
INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
ON e.[AddressID] = a.[AddressID]
INNER JOIN [TelerikAcademy].[dbo].[Towns] t
ON a.[TownID] = t.[TownID]
WHERE e.[JobTitle] = 'Sales Representative'
```

#### Write a SQL query to find the names of all employees whose first name starts with "SA".
```
SELECT [FirstName], [LastName]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE [FirstName] LIKE  'Sa%'
```

#### Write a SQL query to find the names of all employees whose last name contains "ei".
```
SELECT [FirstName], [LastName]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE [LastName] LIKE  '%ei%'
```

#### Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
```
SELECT [FirstName], [LastName], [Salary]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE [Salary] BETWEEN 20000 AND 30000
ORDER BY [Salary]
```

#### Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
```
SELECT [FirstName], [LastName], [Salary]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE [Salary] IN (25000, 14000, 12500, 23600)
ORDER BY [Salary]
```
#### Write a SQL query to find all employees that do not have manager.
```
SELECT [FirstName], [LastName]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE [ManagerID] IS NULL
```

#### Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
```
SELECT [FirstName], [LastName], [Salary]
FROM [TelerikAcademy].[dbo].[Employees]
WHERE [Salary] > 50000
ORDER BY [Salary] DESC
```

#### Write a SQL query to find the top 5 best paid employees.
```
SELECT TOP 5 [FirstName], [LastName], [Salary]
FROM [TelerikAcademy].[dbo].[Employees]
ORDER BY [Salary] DESC
```

#### Write a SQL query to find all employees along with their address. Use inner join with ON clause.
```
SELECT e.[FirstName] + ' ' + e.[MiddleName] + ' ' + e.[LastName] AS [Full Name], a.[AddressText], t.[Name]
FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
ON e.[AddressID] = a.[AddressID]
INNER JOIN [TelerikAcademy].[dbo].[Towns] t
ON a.[TownID] = t.[TownID]
```

#### Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
```
SELECT e.[FirstName] + ' ' + e.[MiddleName] + ' ' + e.[LastName] AS [Full Name], a.[AddressText], t.[Name]
FROM [TelerikAcademy].[dbo].[Employees] e, [TelerikAcademy].[dbo].[Addresses] a, [TelerikAcademy].[dbo].[Towns] t
WHERE e.[AddressID] = a.[AddressID] AND t.[TownID] = a.[TownID]
```

#### Write a SQL query to find all employees along with their manager.
```
SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employees], m.[FirstName] + ' ' + m.[LastName] AS [Menagers]
FROM [TelerikAcademy].[dbo].[Employees] e
LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] m
ON e.[ManagerID] = m.[EmployeeID]
```

#### Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
```
SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employees],  a.[AddressText], m.[FirstName] + ' ' + m.[LastName] AS [Menagers]
FROM [TelerikAcademy].[dbo].[Employees] e
LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] m
ON e.[ManagerID] = m.[EmployeeID]
JOIN [TelerikAcademy].[dbo].[Addresses] a
ON e.[AddressID] = a.[AddressID]
```

#### Write a SQL query to find all departments and all town names as a single list. Use UNION.
```
SELECT [Name] AS [Departments/Towns]
FROM [TelerikAcademy].[dbo].[Departments]
UNION
SELECT Name AS [Departments/Towns]
FROM [TelerikAcademy].[dbo].[Towns]
```

#### Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
```
SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employee], m.[FirstName] + ' ' + m.[LastName] AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] m
RIGHT OUTER JOIN [TelerikAcademy].[dbo].[Employees] e
ON e.ManagerID = m.[Employ
```
```
SELECT e.[FirstName] + ' ' + e.[LastName] AS [Employee], m.[FirstName] + ' ' + m.[LastName] AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] m
LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] e
ON e.ManagerID = m.[Employ
```

#### Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
```
SELECT e.[FirstName], e.[LastName], e.[HireDate], d.[Name] AS [Department]
FROM [TelerikAcademy].[dbo].[Employees] e
JOIN [TelerikAcademy].[dbo].[Departments] d
ON (e.[DepartmentID] = d.[DepartmentID]
AND e.[HireDate] BETWEEN '1995-01-01' AND '2005-12-31'
AND d.[Name] IN ('Sales', 'Finance'))
```