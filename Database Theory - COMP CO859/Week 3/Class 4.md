*Date*: September 16th 2024

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107243/files/20878090?module_item_id=5880241)

Index,
Views,
Subqueries,
###### **Remind yourself about primary keys:**
- A unique minimal identifier of an instance  
- Used in  
	- Index (created automatically)  
	- Relationships
###### **Indexes**
- A separate structure pointing   to the table
- Multiple indices allowed on on table
- Consists of one or more columns
- **Advantages**
	- Used to reduce access time
- **Disadvantages**
	- Storage Space needed
	- Occasional maintenance 
- **Binary Search**
	- Only works with ordered and sorted lists
	- Checks by dividing by 2
	- If target is lower, higher values are eliminated 
	- Loop until done 
- **Index Clustering**
	- ==Search what clustered means==
	- Physically sorts data according to the clustered index 
	- Only one clustered index allowed per table 
- **Creating An Index**
	- CREATE [UNIQUE] [CLUSTERED] INDEX index_name  
		ON table_name(column_name1 [ASC| DESC], column_nameN  
		[ASC| DESC], ...)
```sql
	CREATE INDEX IX_patients_last_name  
	ON patients(last_name ASC)
```

###### **Views**
- A virtual table based on one or more tables
- The view result is not permanently stored in the database
- A collection of relevant columns
- Provides a level of security 
- Cannot use ORDER BY
- **Creating a view**
```sql
	CREATE VIEW view_name AS  
	SELECT....  
```

```sql
	CREATE VIEW current_admissions AS  
	SELECT nursing_unit_id, patient_id, primary_diagnosis  
	FROM admissions  
	WHERE discharge_date IS NULL
	
	CREATE VIEW icu AS  
	SELECT patient_id, admission_date, discharge_date  
	FROM admissions  
	WHERE nursing_unit_id='ICU'
```
- **Using a View**
```sql
	SELECT *  
	FROM icu  
	SELECT *  
	FROM current_admissions
```

###### **Subquery**
- A query within a query 
- Must return only one column
- May return single row or multiple rows
- Can be nested
- **Returning a Single Row**
```sql
	SELECT *  
	FROM medications  
	WHERE medication_cost >  
	(SELECT AVG(medication_cost) * 2  
	FROM medications)  
	ORDER BY medication_cost DESC
```
- Subquery is processed first
- Main query is then processed using subquery result set
- Subquery should only return one row
- If more than one row is returned, the subquery failed
- **Returning More Rows**
```sql
	SELECT nursing_unit_id, patient_id, admission_date  
	FROM admissions  
	WHERE nursing_unit_id IN  
	(SELECT nursing_unit_id  
	FROM nursing_units  
	WHERE beds < 10)  
	ORDER BY nursing_unit_id, patient_id
```
OR
```sql
	SELECT nursing_unit_id, patient_id,  
	admission_date  
	FROM admissions  
	WHERE nursing_unit_id IN  
	('CCU', 'ER', 'ICU', 'OR')  
	ORDER BY nursing_unit_id, patient_id
```
- **Nested Query**
```sql
	SELECT *  
	FROM purchase_order_lines  
	WHERE item_id IN  
		(SELECT item_id  
		FROM items  
		WHERE quantity_on_hand >  
			(SELECT AVG(quantity_on_hand)  
			FROM items))  
```

