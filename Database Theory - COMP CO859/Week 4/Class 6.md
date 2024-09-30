*Date*: September 23rd 2024

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107243/files/20878041?module_item_id=5880242)

Insert
Delete
Update

###### **CRUD**
- Create `INSERT`
- Read `SELECT`
- Update `UPDATE`
- Delete `DELETE`
- Thus far, we have focused on reading using `SELECT`

#### **INSERT Statement**
- May insert a single row or many rows

###### **Inserting A Single Row**
```sql
INSERT INTO table_name  
[(column_1, column_2, column_3, column_4)]  
VALUES(value1, value2, value3, value4)
```
- Column names are optional 
- If col names are not specified, all cols must have values
- -- 
```sql
INSERT INTO table_name  
(column_1, column_3)  
VALUES(value1, value3)
```
- Any columns specified must have values  
	- The missing column(s) must allow NULL or have a default value
- -- 
```sql
INSERT INTO dental_services  
(service_id, service_description, service_type, hourly_rate, sales_ytd)  
VALUES(600, 'Temporary Filling', 'F', 100, 0)
```
- All columns names and values provided
- --
```sql
INSERT INTO dental_services  
VALUES(101, 'Tricky Extraction', 'E', 200, 0)
/*101 is the primary key*/
```
- Column names not provided, so all columns must have a value specified
- --
```sql
INSERT INTO dental_services  
VALUES(201, NULL, 'C', 75, 0)
```
- Column names not provided, so all columns must have a value specified  
- Service_description column explicitly set to NULL
- --
```sql
INSERT INTO dental_services  
(service_id, service_description, hourly_rate, sales_ytd)  
VALUES(700, 'Filling', 85, 1050)
```
- Column names provided  
- servivce_type column omitted, will be set to NULL
- --

###### **Dental Service Data Schema**
![[Pasted image 20240923080103.png]]

###### **Sales Table Schema**
![[Pasted image 20240923080136.png]]

###### **Table Creation with IDENTITY**
```sql
CREATE TABLE employees  
(employee_id INT IDENTITY PRIMARY KEY,  
employee_name VARCHAR(50),  
birth_date DATE,  
salary DECIMAL(8, 2) CHECK(salary >= 0))
```
- ###### **Inserting A Single Row**
```sql
INSERT INTO employees  
VALUES('Bob', '2001-12-03', 750)
```
	- Note that primary key value not provided  
	- Identity property will supply the primary key

###### **Inserting Multiple Rows**
```sql
INSERT INTO table_name  
[(column_1, column_2, column_3, column_4)]  
SELECT statement
```
- Same column rules apply as inserting single rows
- Column names are optional 
- If column names are not specified, all columns must have values

###### **Creating Dental Service Archives**
```sql
CREATE TABLE dental_service_archives (  
service_id INT NOT NULL,  
service_description VARCHAR(30) NULL,  
service_type CHAR(1) NULL,  
hourly_rate MONEY NULL,  
sales_ytd MONEY NULL)
```

- ###### **Inserting Multiple Rows**
```sql
INSERT INTO dental_service_archives  
(service_id, service_description, service_type, hourly_rate, sales_ytd)  
SELECT service_id, service_description, service_type, hourly_rate,  
sales_ytd  
FROM dental_services
```
	- All column names and values provided
```sql
INSERT INTO dental_service_archives  
(service_id, service_description, service_type, hourly_rate, sales_ytd)  
SELECT *  
FROM dental_services
```
	- All column names and values provided
 ```sql
INSERT INTO dental_service_archives  
SELECT *  
FROM dental_services
```
	- Column names not provided, so all columns must have a        value specified
```sql
INSERT INTO dental_service_archives  
(service_id, service_description)  
SELECT service_id, service_description  
FROM dental_services
```
	- Column names provided  
	- Omitted columns, will be set to NULL

#### **DELETE Statement**
- May delete a single row
- May delete many rows or all
- `WHERE` clause is optional. If not specified all rows will be deleted without warning 

###### **Deleting a Single Row**

```sql
DELETE FROM dental_services  
WHERE service_id = 300
```
- `WHERE` clause uses primary key to locate one record
- This delete will fail due to referential integrity
- **Foreign Key Constraint**
	- FK_sales_service_i_27XXXX 
	- There are multiple values where service_id = 300
- --
```sql
DELETE FROM dental_services  
WHERE service_id = 600
```
- `WHERE` clause uses primary key to locate one record 
- This delete will succeed because there are no child related records in the sales table 
- -- 

###### **Deleting Multiple Rows**

```sql
DELETE sales  
WHERE amount >= 100
```
- `FROM` is optional 
- `WHERE` clause locates many records 

###### **Deleting All Rows**
```sql
DELETE FROM sales
```
- Deletes everything

#### **UPDATE Statement**
- May update a single row
- May update many or all rows
- `WHERE` clause is optional 
	- If not specified all rows will be updated without warning 

###### **Updating All Rows**
```sql
UPDATE table_name  
SET column_1=value1, column_2=value2
```
- No `WHERE` clause

###### **Updating a Single Row**
```sql
USE chdb  
UPDATE departments  
SET manager_first_name = 'Bob', manager_last_name = 'Loblaw'  
WHERE department_id = 5
```
- `WHERE` clause uses primary key to locate one record 
- New values hard coded

###### **Updating Multiple Rows**
```sql
UPDATE items  
SET item_cost = item_cost * 1.1  
WHERE primary_vendor_id = 5
```
- `WHERE` clause locates many records
- New value provided by formula 

###### **Updating A Single Row With A Subquery**
```sql
UPDATE purchase_orders  
SET total_amount = (SELECT SUM(quantity * unit_cost)  
FROM purchase_order_lines  
WHERE purchase_order_id = 10)  
WHERE purchase_order_id = 10
```  
- Main WHERE clause locates one record  
- Subquery WHERE clause locates many records  
- SUM aggregating function ensures only one record is returned from subquery  
- New value provided by subquery

###### **SQL Script**
- When a “batch” of statements have been executed, the end of the batch can be signified by a GO statement  
- The GO statement is usually optional, but can be required in certain circumstances  
- Some CREATE statements require that they are the first statement in a batch  
- From the Student Resources page, download and open co859.sql in SSMS

- There are a variety of SET commands that change the current session handling of specific information  
- `SET NOCOUNT ON`  
	- Suppress INSERT, UPDATE and DELETE completion messages  
- `SET DATEFORMAT` ymd  
	- Sets the date format to YYYY-MM-DD

- Single line comments begin with --  
- Multi line comments are bounded with /* */  
- For a detailed treatment of naming conventions and SQL style, see  
	- https://www.sqlstyle.guide  
	- Based on the work of Joe Celko, database expert

###### **Case Styles**
• There are 4 case styles commonly used in  
computing  
– camelCase  
– kebab-case  
– PascalCase  
– snake_case  
• Guidelines only, not rules