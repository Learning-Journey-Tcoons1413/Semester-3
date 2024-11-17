*Date*: *October 21st 2024*

Relationships,
Cardinality,
Business Rules

###### Relationships
- An association between entities 
- **EX**) Province has many patients within it
- Patient lives within ONE Province --> one-to-many 

- **EX**) Department managed by ONE employee
- Employee manages ONE department --> one-to-one

###### Cardinality
- The number of entity occurrences possible on the two sides of a relationship

- **Cardinality Range**
	- EX) Professor teaching one class but not more than 4
	- Range enforced by program logic; Known as **business rule**
- **Crow's Foot Symbols**
	- ![[Pasted image 20241102115601.png]]
	- ![[Pasted image 20241102115719.png]]

###### Degree
- A unary relationship has one entity
	- EX) Employee Supervisor --> Recursive Relationship 
- A binary relationship has two entities 
- A ternary relationship has three entities
- A four-entity relationship has four entities etc... 
- ![[Pasted image 20241102120343.png]]

###### Example of Business Rules
- An employee ID must be unique 
- A customer province must be valid 
- Patient height must be greater than zero 

###### What are Business Rules 
- Specifications that preserve the integrity of a conceptual or logical data model 
- Stored as part of the database

- **Four Types of Business Rules**
	- 1. **Entity Integrity**
		- Each entity must have unique identifier 
		- Primary Key Not Null
	- 2. **Referential Integrity**
		- Rules governing the relationship between entities 
		- Foreign Keys
		- `ON DELETE` and `ON UPDATE` parameters during table creation for foreign key constraint 
			- `NO ACTION` – An error is raised and the delete/update is rolled back  
			- `CASCADE` – Corresponding rows are deleted/updated in the related table(s)  
			- `SET NULL` – Corresponding values are set to null in the related table(s)  
			- `SET DEFAULT` – Corresponding values are set to their default values in the related table(s)

	- 3. **Domains**
		- Associated with constraints that restrict the values permitted in a column 
		- Advantages: Verify values for an attribute --> patient_height > 0
	- 4. **Triggering Operations**
		- Rules that are invoked on the action of data manipulation (`INSERT`,`UPDATE`,`DELETE`)
			- Prevents invalid transactions
			- Enforces complex security 
			- Last resort:

###### Cascade Delete
	• From the Student Resources page, download  
	cascade_example.sql and open it in SSMS  
	• Examine the script  
	• From the menu, select Query / Results To /  
	Results To Text or press Ctrl+T  
	• Run the query and examine the results

![[Pasted image 20241102121637.png]]