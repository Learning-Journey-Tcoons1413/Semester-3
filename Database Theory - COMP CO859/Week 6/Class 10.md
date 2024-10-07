*Date*: *October 7th 2024*
###### **Predicates**
- A condition that is true or false or unknown about a given row or group 
- Used in WHERE clauses
- ![[Pasted image 20241007081024.png]]

- **Basic Predicates**
	- A basic predicate compares two values
	- `=, < >, <, >, <=, >=`
	```sql
	SELECT *  
	FROM admissions  
	WHERE nursing_unit_id = '2EAST'  
	
	SELECT first_name, last_name, patient_weight  
	FROM patients  
	WHERE patient_weight > (SELECT AVG(patient_weight) FROM patients)
	```

- **BETWEEN Predicate**
	- The BETWEEN predicate compares a value **inclusively** with a range of values  
	- More compact version of >= AND <=
	```sql
	SELECT first_name, last_name, patient_height  
	FROM patients  
	WHERE patient_height BETWEEN 100 AND 105  
	WHERE patient_height >= 100 AND patient_height <= 105
	```

- **EXISTS Predicate**
	- The EXISTS predicate tests for the existence of certain rows using a subquery  
	- EXISTS returns true if a subquery contains any rows  
	- Used in the database creation scripts  
	- Ex. chdb.sql, co859.sql, ...  
	- Find patients who take at least one medication
	```sql
	SELECT first_name, last_name  
	FROM patients  
	WHERE EXISTS (SELECT * FROM unit_dose_orders  
	WHERE unit_dose_orders.patient_id = patients.patient_id)
	```
	- Other Ex)
	```sql
	INSERT INTO vendors VALUES('Medical Mart',  
	'550 Matheson Blvd W', 'Mississauga', 'ON',  
	'L5R 4B8', 'McCoy', 'Leonard', 0)
	
	SELECT *  
	FROM vendors  
	WHERE NOT EXISTS (SELECT * FROM purchase_orders WHERE 
	purchase_orders.vendor_id = vendors.vendor_id)
	```

- **IN Predicate**
	- Compares a value with a set of values
	- Wherever EXISTS is used, IN can also be used
	```sql
	SELECT first_name, last_name  
	FROM patients  
	WHERE patient_id IN (SELECT DISTINCT patient_id FROM unit_dose_orders)
	```
	- Other Ex)
	```sql
	SELECT *  
	FROM vendors  
	WHERE vendor_id NOT IN (SELECT DISTINCT vendor_id FROM purchase_orders)
	```

- **LIKE Predicate**
	- LIKE predicate searches for strings that have a certain pattern
	- `%` matches any number of characters
	- `_` Matches a single character
	- Examples)
	```sql
	SELECT first_name, last_name, primary_diagnosis  
	FROM patients p  
	JOIN admissions a  
	ON p.patient_id = a.patient_id  
	WHERE primary_diagnosis LIKE '%Diab%' 
	
	SELECT first_name, last_name, nursing_unit_id  
	FROM patients p  
	JOIN admissions a  
	ON p.patient_id = a.patient_id  
	WHERE nursing_unit_id LIKE '_EAST'
	```

- **NULL Predicate**
	- Tests for null values
	- MUST BE USED WITH `IS` NOT `=`
	```sql
	SELECT first_name, last_name, secondary_diagnoses  
	FROM patients  
	JOIN admissions  
	ON patients.patient_id = admissions.patient_id  
	WHERE secondary_diagnoses IS NULL
	```

- **TOP**
	- Not a predicate
	- This clause sets a max number of rows that can be retrieved
	- Example)
	```sql
	SELECT TOP 5 *  
	FROM patients
	```

- **Top Percent**
	- Not a predicate
	- Sets a max number of rows that can be retrieved
	```sql
	SELECT TOP 5 PERCENT *  
	FROM patients
	```

- **Having**
	- Not a predicate
	- A second `WHERE` clause
	- Used with `GROUP BY`
	- Example)
	```sql
	SELECT nursing_unit_id, COUNT(*)  
	FROM admissions  
	GROUP BY nursing_unit_id  
	HAVING COUNT(*) >= 340
	```

###### **Entities**
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

###### **Relationships**
- Exists between pairs of entities
- Three Kinds:
	- ![[Pasted image 20241007085509.png]]
- **What would the ERD look like for the following entities**
	- Students, Transcripts 
	- Instructor, Students
	- Classes, Students
	- Teams, Players

- **Library Example**
	- Entities:
		- members
		- books
		- copies
		- borrow_transactions
		- ![[Pasted image 20241007085744.png]]

###### **Designing a Database**

- Step 1 - Identify Vital Entities:
	- Interview representatives 
	- Examine existing systems 
- Step 2 Define Entities and Relationships:
	- Determine the key and dependent attributes

- Example:
- Step 1: Community Hospital Database:
	- Patients
	- Doctors 
	- Medications
	- Nursing Units
- Step 2: Define Entities and Relationships
	- Name
	- Phone
	- Address
	- Health Card Number
	- Allergies
	- ![[Pasted image 20241007090140.png]]

###### **Many-to-Many Relationships**
- Cannot be directly implemented in DBMS  
- Use intersection entities
- ![[Pasted image 20241007090311.png]]
- ![[Pasted image 20241007090411.png]]

- **ER Modeling Symbols**
- ![[Pasted image 20241007090504.png]]
- ![[Pasted image 20241007090633.png]]

==Search for the rows that have null values in them is a MIDTERM QUESTIONS==


###### **Lab 5**
- Due October 23rd
- Each group - Pick 2 Only 
- Good way to study for the midterm 

