## 06. Transact SQL
### _Homework_

1.	Create a database with two tables: `Persons(Id(PK), FirstName, LastName, SSN)` and `Accounts(Id(PK), PersonId(FK), Balance)`.
	*	Insert few records for testing.
	*	Write a stored procedure that selects the full names of all persons.
	
```sql
CREATE DATABASE TransactSQL
GO

USE TransactSQL
GO

CREATE TABLE Persons (
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[SSN] VARCHAR(9),
	CONSTRAINT [CH_SSNDigit] CHECK ([SSN] LIKE REPLICATE('[0-9]', 9)),
	CONSTRAINT [CH_SSNLength] CHECK (LEN([SSN]) = 9)
)
GO

CREATE TABLE Accounts(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[PersonId] INT NOT NULL,
	[Balance] MONEY NOT NULL,
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY (PersonId)
	REFERENCES Persons(Id)  
)
GO

INSERT INTO Persons (FirstName, LastName, SSN)
VALUES
('TestFirstName1', 'TestLastName1', '100000000'),
('TestFirstName2', 'TestLastName2', '200000000'),
('TestFirstName3', 'TestLastName3', '300000000')

INSERT INTO Accounts(PersonId, Balance)
VALUES
	(1, 23000),
	(2, 34000),
	(3, 250),
	(1, 2200),
	(2, 550)
GO
```


1.	Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

```sql
CREATE PROC usp_UserWithMoreBalanceThan @amount MONEY = 0
AS
SELECT FirstName, LastName, Balance
FROM Persons p
JOIN Accounts a
ON p.Id = a.PersonId
WHERE @amount < a.Balance

EXEC usp_UserWithMoreBalanceThan @amount = 550
GO
```
1.	Create a function that accepts as parameters � sum, yearly interest rate and number of months.
	*	It should calculate and return the new sum.
	*	Write a `SELECT` to test whether the function works as expected.
```sql
CREATE FUNCTION ufn_CalculateSumWithInterest (@sum MONEY, @yearInterest DECIMAL, @months INT) RETURNS MONEY
AS
BEGIN
	RETURN (@sum + @sum*(@yearInterest/100)*@months/12)
END
GO

DECLARE @sumWithInterest MONEY = (SELECT Balance FROM Accounts WHERE Id = 1)
PRINT dbo.ufn_CalculateSumWithInterest(@sumWithInterest, 4, 5)

```
	
1.	Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
	*	It should take the `AccountId` and the interest rate as parameters.
```sql
CREATE PROC usp_AddMonthlyInterest (@accountId INT, @interestRate DECIMAL)
AS
DECLARE @balance MONEY = (SELECT Balance FROM Accounts WHERE Id = @accountId)
UPDATE Accounts
SET Balance = dbo.ufn_CalculateSumWithInterest(@balance, @interestRate, 1)
WHERE Id = @accountId
GO

EXEC usp_AddMonthlyInterest 1, 4.0
GO
```

1.	Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` that operate in transactions.

```sql
CREATE PROC usp_WidrawMoney @accountId INT, @amount MONEY
AS
	BEGIN TRAN
		DECLARE @currentBalance MONEY = (SELECT Balance FROM Accounts WHERE Id = @accountId)

		IF @currentBalance < @amount
			BEGIN
				ROLLBACK
				RAISERROR('Not enough money!', 16, 1);
				RETURN
			END
		UPDATE Accounts
		SET Balance = Balance - @amount
		WHERE Id = @accountId
		IF @@ROWCOUNT <> 1
		BEGIN
			ROLLBACK
			RAISERROR('Invalid ID', 16, 1);
			RETURN
		END
		COMMIT
GO

CREATE PROC usp_DepositMoney (@accountId INT, @amount MONEY)
AS
	DECLARE @currentBalance MONEY = (SELECT Balance FROM Accounts WHERE @accountId = Id)

	BEGIN TRAN
		UPDATE Accounts
		SET Balance = Balance + @amount
		WHERE Id = @accountId
		IF @@ROWCOUNT <> 1
			BEGIN
				ROLLBACK
				RAISERROR('Invalid ID', 16, 1);
				RETURN
			END
	COMMIT
GO
```

1.	Create another table � `Logs(LogID, AccountID, OldSum, NewSum)`.
	*	Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table every time the sum on an account changes.
```sql
CREATE TABLE Logs (
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[AccountId] INT NOT NULL,
	[OldBalance] MONEY,
	[NewBalance] MONEY,
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY (AccountId)
	REFERENCES Accounts(Id)
)
GO

USE TransactSQL
GO

CREATE TRIGGER TR_LogUpdateBalance ON Accounts FOR UPDATE
AS
	INSERT INTO Logs(AccountId, OldBalance, NewBalance)
	SELECT d.Id, d.Balance, i.Balance
	FROM [deleted] d, [inserted] i
GO

--test
EXEC usp_AddMonthlyInterest 1, 4.0
EXEC usp_WidrawMoney 2, 300
```
1.	Define a function in the database `TelerikAcademy` that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
	*	_Example_: '`oistmiahf`' will return '`Sofia`', '`Smith`', � but not '`Rob`' and '`Guy`'.
```sql
CREATE FUNCTION ufn_CheckIfNameContainsSymbols (@name NVARCHAR(50), @letters NVARCHAR(50)) RETURNS INT
AS
BEGIN
	DECLARE @i INT = 1
	DECLARE @currentCharacter NVARCHAR(1)
	WHILE @i <= LEN(@name)
		BEGIN
			SET @currentCharacter = SUBSTRING(@name, @i, 1)
			IF( CHARINDEX(LOWER(@currentCharacter), LOWER(@letters)) <= 0)
				BEGIN
					RETURN 0
				END
			SET @i = @i + 1
		END
	RETURN 1
END
GO 


SELECT f.FirstName AS 'Names'
FROM Employees f
WHERE dbo.ufn_CheckIfNameContainsSymbols(f.FirstName, 'oistmiahf') = 1
UNION
SELECT l.LastName
FROM Employees l
WHERE dbo.ufn_CheckIfNameContainsSymbols(l.LastName, 'oistmiahf') = 1
UNION
SELECT m.MiddleName
FROM Employees m
WHERE dbo.ufn_CheckIfNameContainsSymbols(m.MiddleName, 'oistmiahf') = 1
UNION
SELECT t.Name
FROM Towns t
WHERE dbo.ufn_CheckIfNameContainsSymbols(t.Name, 'oistmiahf') = 1
```
1.	Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.

```sql
--CREATE TYPE EmployeeTable AS TABLE (
--	TownName VARCHAR(50),
--	FirstName VARCHAR(50),
--	LastName VARCHAR(50)
--)


DECLARE townCursor CURSOR READ_ONLY FOR
SELECT t.Name FROM Towns t

OPEN townCursor
DECLARE @name NVARCHAR(50)
FETCH NEXT FROM townCursor INTO @name

WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @name
		DECLARE @tempTable dbo.EmployeeTable
		INSERT INTO @tempTable
		SELECT @name, e.FirstName, e.LastName 
		FROM Employees e
		JOIN Addresses a
		ON a.AddressID = e.AddressID
		JOIN Towns t
		ON t.TownID = a.TownID
		WHERE @name = t.Name


		DELETE 
		FROM  @tempTable
		FETCH NEXT FROM townCursor INTO @name
	END
CLOSE townCursor
DEALLOCATE townCursor

```
1.	*Write a T-SQL script that shows for each town a list of all employees that live in it.
	*	_Sample output_:	
```sql
Sofia -> Martin Kulov, George Denchev
Ottawa -> Jose Saraiva
�
```

1.	Define a .NET aggregate function `StrConcat` that takes as input a sequence of strings and return a single string that consists of the input strings separated by '`,`'.
	*	For example the following SQL statement should return a single string:

```sql
SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees
```