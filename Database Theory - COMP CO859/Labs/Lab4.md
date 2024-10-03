```sql
/*******************************************************
I, Thomas Coons, student number 000317961, certify that this material is my original work. 
No other person's work has been used without due acknowledgment and I have not made my work available to anyone else.

Script: co859.txt
Author: Thomas Coons
Date: October 2nd 2024
Description: Create co859 Database objects for Tom's Plumbing
********************************************************/

-- Setting NOCOUNT ON suppresses completion messages for each INSERT
SET NOCOUNT ON

-- Set date format to year, month, day
SET DATEFORMAT ymd;

-- Make the master database the current database
USE master

-- If database co859 exists, drop it
IF EXISTS (SELECT * FROM sysdatabases WHERE name = 'co859')
BEGIN
  ALTER DATABASE co859 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
  DROP DATABASE co859;
END
GO

-- Create the co859 database
CREATE DATABASE co859;
GO

-- Make the co859 database the current database
USE co859;

-- Create plumbing_services table
CREATE TABLE plumbing_services (
  service_id INT PRIMARY KEY, 
  service_description VARCHAR(30), 
  service_type CHAR(1) CHECK (service_type IN ('R', 'I', 'E')), 
  hourly_rate MONEY,
  sales_ytd MONEY); 

-- Create sales table
CREATE TABLE sales (
	sales_id INT PRIMARY KEY, 
	sales_date DATE, 
	amount MONEY, 
	service_id INT FOREIGN KEY REFERENCES plumbing_services(service_id));
GO

-- Insert plumbing_services records
INSERT INTO plumbing_services VALUES(100, 'Laying Pipe', 'I', 100, 900);
INSERT INTO plumbing_services VALUES(200, 'Uncloggin/Drainage', 'R', 50, 200);
INSERT INTO plumbing_services VALUES(300, 'Bathroom Install', 'I', 150, 950);
INSERT INTO plumbing_services VALUES(400, 'Emergency Service', 'E', 350, 400);
INSERT INTO plumbing_services VALUES(500, 'Gas Service', 'I', 200, 1200);

-- Insert sales records
INSERT INTO sales VALUES(1, '2024-08-01', 300, 100);
INSERT INTO sales VALUES(2, '2024-08-02', 100, 200);
INSERT INTO sales VALUES(3, '2024-08-03', 50, 200);
INSERT INTO sales VALUES(4, '2024-08-04', 500, 100);
INSERT INTO sales VALUES(5, '2024-08-05', 100, 400);
INSERT INTO sales VALUES(6, '2024-08-06', 100, 300);
INSERT INTO sales VALUES(7, '2024-08-07', 300, 500);
INSERT INTO sales VALUES(8, '2024-08-08', 500, 300);
INSERT INTO sales VALUES(9, '2024-08-09', 50, 200);
INSERT INTO sales VALUES(10, '2024-08-10', 100, 400);
INSERT INTO sales VALUES(11, '2024-08-11', 350, 300);
INSERT INTO sales VALUES(12, '2024-08-12', 700, 500);
INSERT INTO sales VALUES(13, '2024-08-13', 100, 100);
INSERT INTO sales VALUES(14, '2024-08-14', 200, 400);
INSERT INTO sales VALUES(15, '2024-08-15', 200, 500);
GO

-- Create Index
CREATE INDEX IX_plumbing_services_service_description
ON plumbing_services (service_description);
GO

-- Create View
CREATE VIEW high_end_services
AS
SELECT SUBSTRING(service_description, 1, 15) AS descriptions, sales_ytd
FROM plumbing_services
WHERE hourly_rate > (SELECT AVG(hourly_rate) FROM plumbing_services);
GO

-- Verify inserts
CREATE TABLE verify (
  table_name varchar(30), 
  actual INT, 
  expected INT);
GO

INSERT INTO verify VALUES('plumbing_services', (SELECT COUNT(*) FROM plumbing_services), 5);
INSERT INTO verify VALUES('sales', (SELECT COUNT(*) FROM sales), 15);
PRINT 'Verification';
SELECT table_name, actual, expected, expected - actual discrepancy FROM verify;
DROP TABLE verify;
GO
```