*Date*: September 30th 2024

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107243/files/20878110?module_item_id=5880243)

Joining Tables,
Grouping Data,
Data Processing in SQL Server

###### **Joining Tables**
- Its useful to do this
- Here's how:
```sql
	SELECT column(s)  
	FROM first_table  
	JOIN second_table  
	ON first_table.column = second_table.column
```
- **Join Example:**
	- Below we select all columns from both tables
	- Join on purchase order number
```sql
	SELECT *  
	FROM purchase_orders  
	JOIN purchase_order_lines  
	ON purchase_orders.purchase_order_id = purchase_order_lines.purchase_order_id
```

- **Join Types:**
	- Inner join
	- Left outer join 
	- Right outer join 
	- Full outer join
	- Cross join

- **Sample Tables:**
	- ![[Pasted image 20240930080311.png]]

- **Inner Join** - AND OPERATION:
	- table aliases used to simplify typing
	- INNER is optional 
	- if col is not unique, it must be qualified 
	- Most commonly used join type
	- Example Below: 
	```sql
	SELECT s.product_id, sold, purchased  
	FROM sales s  
	INNER JOIN purchases p  
	ON s.product_id = p.product_id
	```
	- Inner Join Result: 
	- ![[Pasted image 20240930080725.png]]

- **Left Outer Join:** - OR OPERATION:
	- OUTER is optional 
	```sql
	SELECT s.product_id, sold, purchased  
	FROM sales s  
	LEFT OUTER JOIN purchases p  
	ON s.product_id = p.product_id
	```
	- ![[Pasted image 20240930081056.png]]

- **Right Outer Join** - OR OPERATION:
	- OUTER is optional 
	```sql
	SELECT s.product_id, sold, purchased  
	FROM sales s  
	RIGHT OUTER JOIN purchases p  
	ON s.product_id = p.product_id
	```
	- ![[Pasted image 20240930081401.png]]

- **Full Outer Join** - OR OPERATION:
	- OUTER is optional 
	```sql
	SELECT s.product_id, p.product_id, sold, purchased  
	FROM sales s  
	FULL OUTER JOIN purchases p  
	ON s.product_id = p.product_id
	```
	- ![[Pasted image 20240930081616.png]]

- **Cross Join**:
	```sql
	SELECT s.product_id, sold, purchased  
	FROM sales s  
	CROSS JOIN purchases p
	```
	- ![[Pasted image 20240930082219.png]]


	-  ![[Pasted image 20240930082522.png]]

- **Joining 3 Tables**:
	```sql
	SELECT p.product_id, product_description, sold,purchased  
	FROM products p  
	JOIN sales s  
	ON p.product_id = s.product_id  
	JOIN purchases pu  
	ON p.product_id = pu.product_id  
	ORDER BY product_description
	```
	- ![[Pasted image 20240930082735.png]]

- **Joining 3 Tables With Outer Joins:**
	```sql
	SELECT p.product_id, product_description, sold,purchased  
	FROM products p  
	LEFT JOIN sales s  
		ON p.product_id = s.product_id  
	LEFT JOIN purchases pu  
		ON p.product_id = pu.product_id  
	ORDER BY product_description
	```
	- ![[Pasted image 20240930082903.png]]

- **Joining 3 Tables Again**:
	```sql
	USE CHDB;  
	SELECT first_name,last_name,medication_description,dosage  
	FROM patients p  
	JOIN unit_dose_orders u  
		ON p.patient_id = u.patient_id  
	JOIN medications m  
		ON u.medication_id = m.medication_id  
	ORDER BY last_name, first_name, medication_description;
	```

- **Joining A Table With Itself:**
	```sql
	USE joins;  
	SELECT e1.employee_id, e1.first_name,  
	e1.last_name, e1.department, e1.title,  
	e1.supervisor, e2.employee_id, e2.first_name,  
	e2.last_name  
	FROM employees e1  
	JOIN employees e2  
		ON e1.supervisor = e2.employee_id  
	ORDER BY e1.department, e1.employee_id;
	```

- **Joining A Table With Itself Again:**
	```sql
	SELECT e1.employee_id, e1.first_name,  
	e1.last_name, e1.department, e1.title,  
	e1.supervisor, e2.employee_id, e2.first_name,  
	e2.last_name  
	FROM employees e1  
	LEFT JOIN employees e2  
		ON e1.supervisor = e2.employee_id  
	ORDER BY e1.department, e1.employee_id
	```

- ![[Pasted image 20240930083530.png]]

- **Joining the Same Table Twice:**
	```sql
	USE hasc;  
	SELECT * FROM games;  
	SELECT * FROM teams;  
	SELECT game_id, game_date, h.team_name,  
	home_team_score, a.team_name, away_team_score  
	FROM games g  
	JOIN teams h ON g.home_team_id = h.team_id  
	JOIN teams a ON g.away_team_id = a.team_id;
	```

###### **Grouping Data**
- Consider the following:
	- First returns 1 row
	```sql
	SELECT COUNT(*)  
	FROM admissions
```
	- Second returns multiple rows:
	```sql
	SELECT nursing_unit_id  
	FROM admissions
	```
	- Attempting to combine the above example will not work due to disparate result sets UNLESS a `GROUP BY` is used
		```sql
		SELECT nursing_unit_id, COUNT(*)  
		FROM admissions  
		GROUP BY nursing_unit_id
		```
- **GROUP BY**
	- must be used in conjunction with an aggregating function
	- Does not sort automatically, still need `ORDER BY` for sort
	- Multiple groupings are allowed 
		```sql
		SELECT province_id, city, COUNT(*)  
		FROM patients  
		GROUP BY province_id, city  
		ORDER BY province_id, city
		```

![[Pasted image 20240930085748.png]]

###### **Data Processing in SQL Server**
- Data processing is complex. 
- ==NOTE: You skipped a lot of random slides==

- **Date:**
	- SQL default date is: `yyyy-mm-dd`
	- In a SQL script, we can control the date format using the `SET DATEFORMAT` command
	- **SET DATEFORMAT** format  
		• format can be:  
			– dmy (Preferred in much of the world)  
			– mdy (Preferred in USA)  
			– ymd (Unambiguous, best choice)  
			– ydm (Should be avoided)  
			– myd (Should be avoided)  
			– dym (Should be avoided)
	- **DATEDIFF**(datepart, startdate, enddate)  
		- datepart  
			- year, quarter, month, dayofyear, day, week, hour, minute, second, millisecond, microsecond, nanonsecond
		- Examples:
		- ![[Pasted image 20240930090543.png]]
	- **DATEADD**
		- `SELECT DATEADD(DAY, 60, ‘2024-09-01')``  
			• Result is 2024-10-31  
		- `SELECT DATEADD(MONTH, 5, ‘2024-09-01') ` 
			• Result is 2025-02-01  
		- `SELECT DATEADD(YEAR, 3, ‘2024-09-01') ` 
			• Result is 2027-09-01
		- NOTE:
			- Use subtraction to subtract date
			- `SELECT DATEADD(DAY, -60, ‘2024-09-01') ` 
				• Result is 2024-07-03
	- **Current Date**
		- The `GETDATE` function returns the current date with time  
			- `SELECT GETDATE() ` 
		- To get the date without the time, the CONVERT function can be used  
			- `SELECT CONVERT(DATE, GETDATE())`  
		- ==Calculate patient age IMPORTANT FOR LAB==  
			```sql
			SELECT birth_date,  
			FLOOR(DATEDIFF(DAY, birth_date, GETDATE()) / 365.25)  
			FROM patients
			```
	- **Extracting Date Parts**
		- ![[Pasted image 20240930091734.png]]
		- 
		```sql
		SELECT encounter_date_time,  
			DATEPART(HOUR, encounter_date_time) AS [hour],  
			DATEPART(MINUTE, encounter_date_time) AS [minute],  
			DATEPART(SECOND, encounter_date_time) AS [second]  
		FROM encounters
		```

		- DATENAME(datepart, date) works like DATEPART but returns a string instead of an integer  
		```sql
		SELECT encounter_date_time,  
			DATENAME(HOUR, encounter_date_time) AS [hour],  
			DATENAME(MINUTE, encounter_date_time) AS [minute],  
			DATENAME(SECOND, encounter_date_time) AS [second]  
		FROM encounters
		```