*Date*: *November 11th 2024*
###### Normalization 

- We want to develop conceptual model that represents entities of the enterprise 
- Model is independent of DBMS

- Normalization is process to group data elements into tables that represent entities 

- Normalization is process of organizing data to minimize redundance 
- Organizing data is done by applying a series to a data model. Normalization makes things more efficient but more complicated. Mus use joins 

###### Normal Forms
- 0 Normal Form: Un-normalized model before normal rules applied 
- 1st Normal Form: 
- 2nd Normal From 
- 3rd Normal Form 
- Codd created this shit 

###### First Normal Form 
- Reduces entities to 1NF by removing repeating or multi-valued attributes 
- Cant have multiple fields to capture multiple values 
- 'sins' include lack of primary keys, use of repeating columns 

###### Zero Normal Form
- No rules applied 
  Note repeating columns
  Note calculated fields 
  ![[Pasted image 20241113095402.png]]

 ###### **Solution to the Above Picture Using 1NF**

- **THE KEY**
- Do we have a primary key for everything?
- CREATE two tables, order and product 
- Linked by Order field 
- Calculated values like Amount have been discarded 
- ![[Pasted image 20241113095533.png]]

###### Second Normal Form (2NF)

- **THE WHOLE KEY**
- Reduce first normal form entities to second normal form by removing attributes that are not dependent on the whole primary key 
- The primary key for each record must be able to determine the value for all of the other fields in the records. 

- Another table is created: order_line 
- ==PICTURE FROM SLIDE GOES HERE==

###### Getting Smaller 

![[Pasted image 20241113095852.png]]

###### 2NF

-  ==PICTURE FROM SLIDE GOES HERE==
- Create Customers table 

###### 3NF

-  ==PICTURE FROM SLIDE GOES HERE==
- Create Tax rate table 

###### Order Normalization 

- Missing information 


###### Third Normal Form Tables 

-  ==PICTURE FROM SLIDE GOES HERE==
-  ==**IMPORTANT**==

###### Creating the ERD

- Draw the entities with their primary keys 
-  ==PICTURE FROM SLIDE GOES HERE==
-  ==PICTURE FROM SLIDE GOES HERE==

- Examine each primary key to see if it appears in another table, if so it is a foreign key in the other table 

- Each foreign key means there is a relationship between the two tables 
- The primary key is on the "one" side and the foreign key is on the "many" side.
-  ==PICTURE FROM SLIDE GOES HERE==

###### Normalization Quick Summary 

- 1NF - Eliminate repeating groups and derived attributes, anything that is computed. 
- 2NF - Eliminate redundant data, if an attribute depends on only part of a composite key, remove it to a separate table 
- 3NF - Eliminate columns not dependent on key. If attributes do not contribute to a description of the key, remove them to a separate table. 

###### Normalization Case Study 

- Pipes N Things
	- A distributor of plumbing parts and fixtures 
	- Purchase from manufacturers 
	- Supply retailers 
	- Designing corporate data base 

###### List the Entities Found

-  ==PICTURE FROM SLIDE GOES HERE==
-  ==**IMPORTANT**==

- Hint, look for keys
- Keys will usually identify entities 

- **Entities Found**



NOTE: Composite Keys are made up of foreign keys. 

==NOTE: Anomaly on exam== 

###### Anomaly ==TEST QUESTIONS==

- 



###### Transitive Dependency ==TEST QUESTIONS==

- 