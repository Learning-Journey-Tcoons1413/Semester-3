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

- 