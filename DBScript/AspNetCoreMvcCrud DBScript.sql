IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'AspNetCoreMvcCrud')
BEGIN
    CREATE DATABASE AspNetCoreMvcCrud
END
GO

USE AspNetCoreMvcCrud
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employees' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE Employees
	(
		EmployeeID INT PRIMARY KEY IDENTITY(1,1),
		EmpName NVARCHAR(100) NOT NULL,
		Position NVARCHAR(50) NOT NULL,
		Office NVARCHAR(50) NOT NULL,
		Salary DECIMAL(18,2) NOT NULL
	);
END
GO

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Alice Johnson', 'Software Engineer', 'New York', 75000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Bob Smith', 'Project Manager', 'San Francisco', 85000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Charlie Brown', 'Data Analyst', 'Chicago', 65000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Diana Prince', 'UX Designer', 'Los Angeles', 70000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Ethan Hunt', 'DevOps Engineer', 'Seattle', 80000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Fiona Green', 'Business Analyst', 'Austin', 72000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'George Clark', 'Database Administrator', 'Boston', 78000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Hannah Brown', 'Marketing Specialist', 'New York', 69000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Isaac Newton', 'Software Developer', 'San Francisco', 73000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Julia Roberts', 'Product Manager', 'Chicago', 76000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Kevin Hart', 'Customer Support Specialist', 'Los Angeles', 62000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Laura Croft', 'Quality Assurance Analyst', 'Seattle', 68000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Michael Scott', 'Office Administrator', 'Austin', 64000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Nina Simone', 'Content Strategist', 'Boston', 71000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Oscar Isaac', 'Front-end Developer', 'New York', 75000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Paula Abdul', 'Human Resources Manager', 'San Francisco', 82000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Quincy Jones', 'Business Development Manager', 'Chicago', 74000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Rita Ora', 'Sales Associate', 'Los Angeles', 67000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Sam Smith', 'IT Support Specialist', 'Seattle', 66000.00;

INSERT INTO Employees (EmpName, Position, Office, Salary)
SELECT 'Tina Fey', 'Creative Director', 'Austin', 79000.00;
