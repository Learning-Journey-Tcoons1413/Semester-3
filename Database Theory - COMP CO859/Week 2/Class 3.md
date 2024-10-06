*Date: September 11th 2024*

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107243/files/20878080?module_item_id=5880239)
###### **Relation (Table in a Database)**
- Basically an excel sheet 
- **Row**
	- Tuple
	- Collection of Attributes 
- **Column**
	- Vertical 
- **Attribute**
	- Primary Key - Determines the values of other attributes
	- Mostly are integers (but doesn't have to be)
- **Functional Dependency**
	- Relationship between a determinant A and dependent attribute B
- **Candidate Key**
	- An attribute that could be used a a primary key 
- **Primary key**
	- Cannot be NULL
	- Meaningless but unique number `MBUN`
	- Start at 1 and increment 
	- 2,147,483,647 possible values for int
	- 9,223,372,036,854,775,807 possible values for big int
	- Globally Unique Identifier (GUID)
	- **IDENTITY property** 
		- IDENTITY [ (seed , increment) ]  
			- Seed and increment are optional, both default to 1
- Atomic attribute  
	- A component of the record definition that is used to describe an entity  
		- A field  
		- Unique meaningful names  
		- Example: postal_code  
 - Composite attribute  
	- Composed of atomic attributes, each defined in the data dictionary  
	- Address is comprised of  
		- street_address  
		- city  
		- province_id  
		- postal_code
- Derived attribute  
	An attribute whose value is obtained by applying a formula to other data elements  
	Examples:  
	- sales commission = sales * percentage  
	- age = DATEDIFF(YEAR, birth_date, GETDATE())  
- Multi-valued attribute  
	- An attribute with multiple possible values  
	- An employee can have more than one skill  
- Alias  
	- Synonym (AS is optional)  
	- A different name for a data element with the same meaning  
	SELECT COUNT(*) AS total  
	FROM patients

---

**More Terms**
- Domain  
	- The set of possible values an attribute can take on  
- Concatenated Key  
	- Also known as Composite Key, Compound Key  
	- Two or more attributes taken together to uniquely identify a record  
	- Examples:  
		-  patient_id, admission_date in admissions table potentially  
		- purchase_order_id, line_num in purchase_order_lines table potentially  
- Secondary Key  
	- Requires an index may not be unique  
	- Example: last_name
- Domain  
	- The set of possible values an attribute can take on  
- Concatenated Key  
	- Also known as Composite Key, Compound Key  
	- Two or more attributes taken together to uniquely identify a record  
	- Examples:  
		- patient_id, admission_date in admissions table potentially  
		- purchase_order_id, line_num in purchase_order_lines table potentially  
- Secondary Key  
	- Requires an index may not be unique  
	- Example: last_name
- Foreign Key  
	- A field (or multiple fields) in a table that uniquely identifies a row of another table (or the same table)  
	- Example: nursing_unit_id in admissions table  
- Entity Occurrence  
	- Represented by a record with actual data values in it, or a row in a table  
- Schema  
	- The definition of an entire database  
	- In SQL Server, schemas are used as containers to organize database objects

---
###### **Models and Database Design**
- The Process of database design is evolutionary 
- Stage 1:
	- Develop the conceptual model
	- Describe each entity and all its attributes 
	- Represented as a row 
- Stage 2:
	- Convert the conceptual model to an internal model 
	- Here we set up an internal model that is compatible with the DBMS we have selected  
	- The internal model is also known as a schema  
	- In the internal model, the relationships between entities fit the structure of a hierarchy or a network or exist as relations between tables  
	- The internal model is required to satisfy each user view (external model)
- Stage 3:
	- Map the internal model to a physical model 
	- Type of File Organizations
	- How data is stored 
	- What devices are used 

###### **Relational Model**
- Developed by IBM
- Two dimensional tables
- New relationships can be created at any time
- Data model may be altered at any time 

###### **The System Catalog**
- A detailed system data dictionary that describes all objects in the database.
- Also Knows As:
	- Metadata
	- Data Dictionary
	- System Tables (SQL Server)
	- System Dictionary

###### **System Scheme**
- Not as nice to work with

###### **Creating Table**
- Tables can be created interactively by right clicking on Tables and selecting New / Table...  
	- Fill in the data from there  
	- Example follows on next few slides

###### **Creating a Table with GUI**
- ![[Pasted image 20240911104747.png]]
- ![[Pasted image 20240911104813.png]]
- MUST CLICK REFRESH

**Creating a Table with Script**
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

```
• CHAR is fixed length  
• VARCHAR is variable length with a maximum  
• CHAR is typically used for “code” values that  
are all the same length (job class, province,  
etc.); 
VARCHAR is more common  
• The values below are not equal  
CHAR(5) 'ABC '  
VARCHAR(5) 'ABC'
```


