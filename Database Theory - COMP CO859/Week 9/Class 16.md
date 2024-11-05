*Date*: *November 4th 2024*

Triggers,

###### Triggers
- Supported by most RDBMS
- Special stored procedure attached to specific table managed by DBMS

###### Triggers VS Stored Procedure 
- Triggers attached to specific table
- Triggers can't pass values to a trigger
- Triggers "fired" automatically in response to event 
- Triggers event-driven 
	- INSERT, UPDATE, DELETE
	  
- Stored Procedures not attached to specific table
- Stored Procedures can pass values to procedures 
- Stored Procedures must be called by programs, triggers or manually
- Stored Procedures not event driven 
- Stored Procedures can be scheduled 

###### Trigger Examples
- Reduce inventory when item is sold 

###### Why Use Triggers?
- Enforce business rules too complex CHECK constraints or referential integrity 
- Automate activity 
- Access or modify other tables 

###### Scenario 
- Consider a many-to-many relationship M:N
	- Part sold by suppliers, supplier can supply many parts
- A trigger can check how many rows already exist for a specific part and prevent an INSERT
- A trigger can disallow any order that does not use the lowest quote for a part

CREATE TRIGGER
```sql
CREATE TRIGGER trigger_name
ON table_name
AFTER [INSERT][,][UPDATE][,][DELETE]
AS
	optionally declare variables here
BEGIN
	insert statements for trigger here
```

CREATE TRIGGER EXAMPLE
```sql
USE joins;  
GO  
CREATE TRIGGER employees_insert  
ON employees  
AFTER INSERT  
AS  
	UPDATE company_stats  
	SET number_of_employees = number_of_employees + 1;
```
###### Deleted and Inserted
- During trigger execution, two special tables are used: deleted and inserted 
- SQL server automatically creates and manages these tables
- They have identical schema to the table being modified 
- ![[Pasted image 20241104084146.png]]

###### Sample Trigger
![[Pasted image 20241104084314.png]]

###### Sample Trigger Test
```sql
PRINT '**********Before Update**********'  
SELECT * FROM employees WHERE employee_id = 102;  
PRINT '**********Attempted Update**********'  
UPDATE employees SET salary = 1500 WHERE employee_id = 102;  
GO  
PRINT '**********After Attempted Update**********'  
SELECT * FROM employees WHERE employee_id = 102;  
PRINT '**********Successful Update**********'  
UPDATE employees SET salary = 850 WHERE employee_id = 102;  
GO  
PRINT '**********After Successful Update**********'  
SELECT * FROM employees WHERE employee_id = 102;
```
NOTE: The above example only works with one employee

```sql
UPDATE employees SET salary = 700 WHERE department = 'Sales';
/*This will fail because we are returning multiple employees*/
```

We will alter the trigger to handle this error. Shown below:
```sql
ALTER TRIGGER employees_update  
	ON employees  
	AFTER UPDATE  
AS  
BEGIN  
	IF EXISTS (SELECT i.salary FROM inserted i  
		JOIN deleted d  
		ON i.employee_id = d.employee_id  
		WHERE i.salary > (d.salary * 1.5))  
	ROLLBACK TRANSACTION;  
END
/*This will fail if ONE employee can't get salary set.
All or none get set.
*/
```

###### Sample Trigger with Cursor
```sql
BEGIN  
	OPEN employees_cursor;  
	FETCH NEXT FROM employees_cursor  
		INTO @new_salary, @old_salary;  
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		IF @new_salary > @old_salary * 1.5  
		BEGIN  
			ROLLBACK TRANSACTION;  
			BREAK;  
	END  
	FETCH NEXT FROM employees_cursor  
		INTO @new_salary, @old_salary;  
	END  
	CLOSE employees_cursor;  
END
```

###### Firing Triggers
- Timing Choices:
	- AFTER: after firing activity occurs
	- INSTEAD OF: allows DBA to take complete control of modification 
- AFTER:
	- INSERT, UPDATE, DELETE occurs first
	- Trigger logic is executed 
	- Trigger can roll back data modifications 

###### purchase_order_line_insert
```sql
CREATE TRIGGER purchase_order_lines_insert  
	ON purchase_order_lines  
	AFTER INSERT  
AS  
	UPDATE purchase_orders  
		SET total_amount = total_amount +  
			(SELECT SUM(quantity * unit_cost)  
			FROM inserted  
			WHERE purchase_orders.purchase_order_id = inserted.purchase_order_id)  
WHERE purchase_orders.purchase_order_id IN  
	(SELECT purchase_order_id FROM inserted);
```

###### purchase_order_lines_update
```sql
CREATE TRIGGER purchase_order_lines_update  
ON purchase_order_lines  
AFTER UPDATE  
AS  
UPDATE purchase_orders  
SET total_amount = total_amount +  
(SELECT SUM(quantity * unit_cost)  
FROM inserted  
WHERE purchase_orders.purchase_order_id = inserted.purchase_order_id) -  
(SELECT SUM(quantity * unit_cost)  
FROM deleted  
WHERE purchase_orders.purchase_order_id = deleted.purchase_order_id)  
WHERE purchase_orders.purchase_order_id IN (SELECT purchase_order_id FROM inserted);
```

###### purchase_order_lines_delete
```sql
CREATE TRIGGER purchase_order_lines_delete  
ON purchase_order_lines  
AFTER DELETE  
AS  
UPDATE purchase_orders  
SET total_amount = total_amount -  
(SELECT SUM(quantity * unit_cost)  
FROM deleted  
WHERE purchase_orders.purchase_order_id = deleted.purchase_order_id)  
WHERE purchase_orders.purchase_order_id IN (SELECT purchase_order_id FROM deleted);
```

Deleting A Trigger  
• To delete an existing trigger use:  
DROP TRIGGER Trigger_Name