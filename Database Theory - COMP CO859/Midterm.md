#### Database Terminology

- Character:
	- Alphanumeric, digits, characters ex) D d 4 7 * ; 
- Entity:
	- A person place or thing represented by a table 
- Attribute:
	- A descriptor of an entity represented by a table 
- Database Dictionary 
	- Repo of all data definitions for all objects within the scope of the database 
- Column (Field):
	- Vertical column of table containing values of characters. Each column containing same type.
- Row (Record):
	- Horizontal row of table 
- Table:
	- Collection of related rows 
- Database:
	- Collection of related tables and objects
- Basic Statements:
	- SELECT column FROM table 
	- SELECT DISTINCT service_id FROM sales (removes duplicates)
	- SELECT `*` FROM sales ORDER BY (sorts data ascending by default)
	- SELECT`*` FROM sales WHERE service_id = 500 (select specifics / also use AND / OR)
	- ==SELECT `*` FROM sales WHERE service_id BETWEEN 100 AND 300 (inclusive)==
	- SELECT * FROM plumbing_services WHERE service_description LIKE `'%er%'` (matches all)
	- SELECT * FROM plumbing_services WHERE service_description LIKE `'%er%'` (matches all)
- Useful Functions:
	- LEN('Blake')  
	- SQRT(144) + 5  
	- STR(SQRT(99), 5, 3)  
	- GETDATE()
- Column Functions:
	- AVG  
		- Computes the average value of the column  
	- COUNT  
		- Counts the number of rows  
	- MAX  
		- Determines the maximum value  
	- MIN  
		- Determines the minimum value  
	- SUM  
		- Totals the numeric values
- Candidate Key:
	- An attribute that can be used as a primary key
- Primary Key:
	- Cannot be null, MBUN, Start at 1 and increment
- Alias:
	- Synonym, different name for a data element 
- Foreign Key
	- Field in a table that identifies a row of another table 
- Creating a Table with Script:
	```sql
	CREATE TABLE employees2  
	(employee_id INT,  
	employee_name VARCHAR(50) NOT NULL,  
	department_id INT,  
	job_id CHAR(3),  
	birth_date DATE,  
	gender CHAR(1),  
	salary DECIMAL(8, 2),  
	CONSTRAINT PK_employees2 PRIMARY KEY(employee_id),  
	CONSTRAINT CK_employees2_gender CHECK(gender IN ('F', 'M', 'O')),  
	CONSTRAINT CK_employees2_salary CHECK(salary >= 0),  
	CONSTRAINT FK_employees2_department_id FOREIGN KEY(department_id)  
	REFERENCES departments(department_id))
	```
- Adding Column To Table after table has been created:
	```sql
	ALTER TABLE table_name 
	ADD column_name data_type [constraints];
	
	EXAMPLE BELOW:
	
	ALTER TABLE employees 
	ADD gender VARCHAR(1) CHECK (gender IN ('M', 'F'))
	```
- INSERT Row To Table:
	```sql
	INSERT INTO employees(employee_id, employee_name, department_id)
	VALUES (2,'Sally Smith',100)
	```
- UPDATE Column Value of a Row:
	```sql
	UPDATE table_name 
	SET column_name = new_value 
	WHERE condition;
	```

#### Indexes

- Separate structure pointing to table, consists of one more more columns
- Reduce Access Time but storage space is needed. Only works with sorted lists
- Only works with binary search 
- One clustered index per table 
- CREATE INDEX
	```sql
	CREATE INDEX idx_employee_name ON employees (employee_name);
	
	CREATE INDEX idx_name ON table_name (column_name);
	```
	- This will speed up queries based on employee names
		```sql
		SELECT * FROM employees WHERE employee_name = 'John Doe';
		```

#### Views

- Virtual table based on one or more tables, not permanent, can't use ORDER BY
	```sql
	CREATE VIEW female_employees AS
	SELECT employee_name, gender
	FROM employees
	WHERE gender = 'F'
	```
- In another separate SELECT:
	```sql
	SELECT *
	FROM female_employees
	```

#### Subquery

- Query within a query, must only return one column 
- Subquery processed first, then main query compared to the sub result

#### Insert

- **Insert into single row:**
	```sql
	INSERT INTO table_name(column_1, column_2, column_3, column_4)
	VALUES(value1, value2, value3, value4)
	```
	- All columns specified must have values
	- If column names not provided, all columns must have value specified 
	- The missing column(s) must allow NULL or have a default value
	
- Table Creation With IDENTITY 
```sql
	CREATE TABLE employees  
	(employee_id INT IDENTITY PRIMARY KEY,  
	employee_name VARCHAR(50),  
	birth_date DATE,  
	salary DECIMAL(8, 2) CHECK(salary >= 0))
```
- This allows for automatic assigning of unique primary keys
- Insert a column
```sql 
ALTER TABLE table_name
ADD column_name VARCHAR(2) CHECK (column_name IN('ON','QC','NO','NB'));
```
#### Delete

- Delete many or single rows, WHERE clause option (deletes all without)
	```sql
	DELETE FROM table_name
	WHERE column_name = something
	
	/*DELETE MANY ROWS*/
	DELETE table_name  
	WHERE amount >= 100
	
	/*DELETE EVERYTHING*/
	DELETE FROM sales
	
	```

#### Update

- Update single row, or many. WHERE clause optional (updates everything)
- Updating All Rows:
	```sql
	UPDATE table_name  
	SET column_1=value1, column_2=value2
	```
- Update single row:
```sql
	UPDATE departments  
	SET manager_first_name = 'Bob', manager_last_name = 'Loblaw'  
	WHERE department_id = 5
	
	UPDATE employees
	SET employee_name = 'Thomas Coons' WHERE employee_id = 4;
	
```
- Update everything
	```sql
	UPDATE employees
	SET salary = 100000
	```


#### Joining Tables

- Overall, joining tables is essential for effective data retrieval and manipulation in relational databases.
```sql
SELECT alias.column_name, otheralias.column_name, Orders.OrderDate 
FROM table_name AS alias
JOIN other_table_name AS otheralias
ON alias.primary_key = otheralias.foriegn_key /*Prim Key = For Key*/
```
- **Join Types:**
	- **Inner** join -**Returns** only the rows where there is a match in both tables.
	
	- **Left** **outer** **join** - Returns all rows from the left table and the matched rows from the right table.
	
	- **Right** **outer** **join** - Returns all rows from the right table and the matched rows from the left table
	
	- **Full** **outer** **join** - Returns all rows when there is a match in either the left or right table.
	
	- **Cross** **join** - Returns the Cartesian product of two tables, meaning every row from the first table is paired with every row from the second table.
- Complicated Example:
	```sql
	SELECT nu.nursing_unit_id, a.admission_date, p.first_name + ' ' + p.last_name AS name
	FROM nursing_units AS nu
	JOIN admissions AS a
	ON nu.nursing_unit_id = a.nursing_unit_id
	JOIN patients AS p
	ON a.patient_id = p.patient_id
	WHERE a.admission_date BETWEEN '2021-9-01' AND '2021-10-28'
	ORDER BY a.admission_date
	```

#### Group By

- Must be used with aggregate functions
```sql
SELECT province_id, city, COUNT(*) AS num_of_patients
FROM patients  
GROUP BY province_id, city  
ORDER BY province_id, city
```
- **Multiple Columns**: You can group by multiple columns if needed.
- **Aggregate Functions**: Must use aggregate functions on columns not in the `GROUP BY` clause.
- ![[Pasted image 20241029161231.png]]

#### Data Processing 
- **Default Date Format**: `yyyy-mm-dd`
    
- **Control Date Format**: Use `SET DATEFORMAT`  
    Options:
    
    - `dmy` (common worldwide)
    - `mdy` (common in the USA)
    - `ymd` (unambiguous, best choice)
- **Date Functions**:
    
    - **DATEDIFF(datepart, startdate, enddate)**: Calculates the difference between two dates.
        - `datepart`: year, month, day, etc.
    - **DATEADD(datepart, number, date)**: Adds a specified number of date parts to a date.  
        Examples:
        - `SELECT DATEADD(DAY, 60, '2024-09-01')` → 2024-10-31
        - Use negative values to subtract dates:
            - `SELECT DATEADD(DAY, -60, '2024-09-01')` → 2024-07-03
- **Current Date**:
    
    - `GETDATE()`: Returns the current date and time.
    - To get the date without time:
        - `SELECT CONVERT(DATE, GETDATE())`
- **Calculating Age**:
```sql
SELECT birth_date, 
	FLOOR(DATEDIFF(DAY, birth_date, GETDATE()) / 365.25) 
FROM patients
```
    
- **Extracting Date Parts**:
    
```sql
SELECT encounter_date_time, 
	DATEPART(HOUR, encounter_date_time) AS [hour], 
	DATEPART(MINUTE, encounter_date_time) AS [minute], 
	DATEPART(SECOND, encounter_date_time) AS [second] 
FROM encounters
```
- Use `DATENAME(datepart, date)` for string output instead of integers.

#### Predicates

- A condition that is true or false or unknown about a given row or group
- Used in WHERE clauses
- BETWEEN
- EXISTS
- IN
- LIKE
- NULL
- Basic:
	- `=, < >, <, >, <=, >=`
- BETWEEN
	- inclusive 
	- `WHERE patient_height BETWEEN 100 AND 105  `
- EXIST
	- Must use subquery
	- Test existence of certain rows
	- EXISTS returns true if a subquery contains any rows  
```sql
WHERE EXISTS 
	(SELECT * FROM unit_dose_orders  
		WHERE unit_dose_orders.patient_id = patients.patient_id)
```
- IN
	- Compares a value with a set of values
- LIKE
	- `WHERE column_name LIKE '%Diab%'`
- NULL
- TOP
```sql
	SELECT TOP 5 *  
	FROM patients
	
	SELECT TOP 5 PERCENT *  
	FROM patients
```
- HAVING
	- used with group by

#### ERD

- ###### **Entities**
- **Entity Relationship Model**
	- A form of semantic modeling  
	- A description of the data in a system  
	- Today’s method influenced by Peter Chen who devised ERM in 1976  
	- Represented by Entity Relationship Diagrams (ERDs)

- **Entities**
	- A person, place, or thing or an event about which we keep information
	- Shows as a rectangular box, labeled with the name of the entity 

- **Bank Entities**
	- People or Companies
		- Customers, Tellers, Suppliers
	- Places
		- Branches, Regions
	- Things
		- Accounts, Fixed Assets
	- Events
		- Withdrawals, Deposits, Loan Applications 
	- ![[Pasted image 20241007085037.png]]
- ###### **Relationships**
	- Exists between pairs of entities
	- Three Kinds:
		- ![[Pasted image 20241007085509.png]]


#### Like

- `'%Moo'` = search for everything ending with the substring
- `'Moo%'` = search for everything starting with the substring
- `'%Moo%'` = search for everything with the substring