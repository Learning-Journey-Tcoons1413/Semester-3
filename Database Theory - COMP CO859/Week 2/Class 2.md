*Date: September 9th 2024*

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107243/files/20879727?module_item_id=5880238)

###### **Windows Services**
- SSMS is application used to interact with Database
- The Database runs as windows service
- Windows Service is long-running. No UI
- Databases and other OS components run as services
- Run Task Manager (Ctrl+Shift+Esc), click More details if  
  necessary, click Services tab to see all services

###### **What is a Database**
- A shared collection of logically related data
- Designed to meet the information needs of multiple users

###### **Database Terminology**
- **Character**:
	- Various alphanumeric characters, digits and specific characters
	- Ex) D b 4 7 * ;
- **Entity**
	- A person, place, or thing
	- Represented by a table
- **Attribute**
	- A descriptor of an entity 
	- Represented by columns
- **Database Dictionary**:
	- Repo of all data definitions for all objects within the scope of the database
	- Contains meta-data
	- 

###### **Column**
- Sometimes referred to  as a field
- Vertical Columns of a table
- Contains actual value consisting of one or more characters
- Each column contains the same type of information for every record in table
- ![[Pasted image 20240909082604.png]]

###### **Row**
- Sometimes referred to as a record
- Horizontal rows of a table 
- PICTURE

###### **Table**
- Collection of related rows
- tables can be linked 

###### **Database**
- Collection of related tables and other objects (views, triggers, procedures).
- *We will use Community Hospital Database (Fictional)*
- **Uses:**
	- Retail Companies (Amazon)
	- Manufacturing Companies (Product Data)
	- Banks (Account Data)
	- Hospitals (Patient Data)
	- Schools (Student Data)

###### **SQL (Structured Query Language)**
- Access language used by many Database Management Systems

###### ==**SQL Statements** MIDTERM QUESTIONS==
- DDL (Data Definition Language):
	- CREATE table
	- CREATE index
- DML (Data Manipulation Language)
	- SELECT
	- INSERT
	- UPDATE
	- DELETE

###### **SQL Characteristics**:
- SQL is not case sensitive 
- Character data must be inside single quotes
- Ex) 'M' <> 'm'
- SQL ignores white space

###### **SQL Basic Select Statement**
- * means everything from patients
- Keywords should be capitalized

```sql
SELECT nursing_unit_id  
FROM admissions
```

- DISTINCT allows for us to remove duplicates
```sql
SELECT DISTINCT nursing_unit_id  
FROM admissions
```

- ORDER BY allows us to order or sort our data
```sql
SELECT *  
FROM patients  
ORDER BY last_name
```

- WHERE retrieves a subset of data. Use AND / OR
```sql
SELECT *  
FROM admissions  
WHERE room = 5 AND nursing_units_id = 'CCU'
WHERE room = 5 OR nursing_units_id = 'CCU'
```

- ==BETWEEN is inclusive MIDTERM QUESTION==
```sql
SELECT *  
FROM admissions  
WHERE room BETWEEN 2 AND 4
```

- LIKE
```sql
SELECT *  
FROM patients  
WHERE last_name LIKE '%sky%'
```

```
_ matches a single character  
% matches any number of characters
```

###### **Expressions**:
- An expression can be:  
	- A column name  
	- Text  
```sql
'this is a text string'  
10  
last_name + ', ' + first_name  
```

- A function:  
```sql
LEN('Blake')  
SQRT(144) + 5  
STR(SQRT(99), 5, 3)  
GETDATE()
```

![[Pasted image 20240909091943.png]]

REFORMAT THIS

###### **Column Functions**  
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

###### **Column Function Examples**  
- SELECT COUNT(*)  
	- FROM patients  
- SELECT AVG(patient_weight)  
	- FROM patients  
- SELECT MIN(last_name)  
	- FROM patients

###### **Column Function Examples**  
- SELECT COUNT(*)  
- FROM patients  
- SELECT AVG(patient_weight)  
- FROM patients  
- SELECT MIN(last_name)  
- FROM patients

[[Database Theory - COMP CO859/To Do|To Do]]
