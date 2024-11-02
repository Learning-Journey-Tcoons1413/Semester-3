*Date*: *October 28th 2024*

###### Stored Procedures
- Supported by most RDBMS
- Pieces of executable code stored in the database
- Managed by DBMS

- Examples:
	- Archive last years data 
	- Remove customers data when customer hasn't bought anything for more than 3 years

- Stored procedures are automated processes
- Compiled, therefor faster 
- Written in `Transact-SQL (T-SQL)`

- **Preferred Database Access Method**

![[Pasted image 20241102122137.png]]

- Stored Procedures are invoked by `EXECUTE`(`EXEC`) statements in T-SQL
	- `EXEC` is optional (allows autocomplete)
	- Can accept command line parameters separated by commas 

- **System Stored Procedures**
	- ![[Pasted image 20241102122404.png]]
```sql
	EXEC sp_columns 'patients'  
	EXEC sp_columns @table_name='patients'  
	EXEC sp_help  
	sp_help 'patients'  
	sp_server_info
```

- **Stored Procedures Structure**
	- Consists of: Procedure name, set of operational parameters, and routine body 

- **Sample Procedure**
```sql
CREATE PROCEDURE update_items_item_cost  
AS UPDATE items  
SET item_cost = item_cost * (1 + 0.25) WHERE primary_vendor_id = 1;
```

- BELOW: Increase and vendor are parameters, improved flexibility
```sql
ALTER PROCEDURE update_items_item_cost  
	@increase DECIMAL(3, 2),  
	@vendor_id INT  
AS  
UPDATE items  
	SET item_cost = item_cost * (1 + @increase)  
	WHERE primary_vendor_id = @vendor_id;
```

- **`ALTER` SQL Statement**
	- `ALTER PROCEDURE` allows changing an existing stored procedure  
	- `ALTER TABLE` allows for changing table structure  
		- Adding/Removing/Changing of columns, constraints, ...  
	- ALTER DATABASE, ALTER VIEW, ...

- **Sample Procedure Test**
```sql
	PRINT '**********Before Update**********'  
	SELECT * FROM items WHERE primary_vendor_id = 1;  
	
	EXEC update_items_item_cost 0.25, 1;  
	
	PRINT '**********After 1st Update**********'  
	SELECT * FROM items WHERE primary_vendor_id = 1;  
	
	EXEC update_items_item_cost @vendor_id=1, @increase=0.25;  
	
	PRINT '**********After 2nd Update**********'  
	SELECT * FROM items WHERE primary_vendor_id = 1;
```

- **Sample Procedure Test Parameters Explanation Below**
	- 1st Param - store up to 3 digit number
	- 2nd Param - the vendor ID
	- 3rd Param - could be used as a flag (Conditional Update)
	- 4th Param - the number of records updated
```sql
ALTER PROCEDURE update_items_item_cost
    @increase DECIMAL(3, 2),
    @vendor_id INT,
    @update INT = 0, -- If @update = 1, perform update; else show what would be updated
    @number_of_records INT OUTPUT
AS
BEGIN
    -- Initialize output parameter
    SET @number_of_records = 0;

    -- Declare cursor for items
    DECLARE items_cursor CURSOR FOR 
    SELECT item_cost
    FROM items
    WHERE primary_vendor_id = @vendor_id
    FOR UPDATE;

    DECLARE @item_cost DECIMAL(9, 2);

    -- Open the cursor
    OPEN items_cursor;

    -- Fetch the first item
    FETCH NEXT FROM items_cursor INTO @item_cost;

    -- Loop through the cursor
    WHILE @@FETCH_STATUS = 0
    BEGIN
        IF @update = 1
        BEGIN
            -- Update the item cost
            UPDATE items
            SET item_cost = @item_cost * (1 + @increase)
            WHERE CURRENT OF items_cursor;

            -- Increment the count of updated records
            SET @number_of_records = @number_of_records + 1;
        END
        ELSE
        BEGIN
            -- Show what would be updated
            PRINT 'Item cost would be updated from ' + CAST(@item_cost AS VARCHAR(10)) + 
                  ' to ' + CAST(@item_cost * (1 + @increase) AS VARCHAR(10));
        END

        -- Fetch the next item
        FETCH NEXT FROM items_cursor INTO @item_cost;
    END

    -- Close and deallocate the cursor
    CLOSE items_cursor;
    DEALLOCATE items_cursor;
END

```

- **Variable Declaration**
```sql
	DECLARE @total_sales DECIMAL(11,2);  
	DECLARE @number_customers INT;  
	DECLARE @error_code CHAR(4);  
	DECLARE @error_msg VARCHAR(100);  
	DECLARE @order_date DATETIME;  
	DECLARE @picture VARBINARY(MAX);
```

- **Assignment Statement `SET`**
```sql
	SET @record_count = @record_count + 1;  
	SET @credit_limit = @credit_limit * 1.20;  
	SET @num_orders = NULL;  
	SET @max_credit_limit = (SELECT MAX(credit_limit) FROM  
	customers);
```

- **`IF` /  `ELSE**
```sql
	IF @ref_error = 0  
		SET @error_msg = 'FOUND';  
	ELSE  
		SET @error_msg = 'NOT FOUND';
```

- **`BEGIN-END` THINK OF { `curly braces` }**
```sql
	IF @ref_error = 0  
	BEGIN  
		SET @error_msg = 'FOUND';  
		SET @found = @found + 1;  
	END  
	ELSE  
	BEGIN  
		SET @error_msg = 'NOT FOUND';  
		SET @not_found = @not_found + 1;  
	END
```

- SIDE NOTE YOU CAN DO NESTED IFS WOW

- **`WHILE` USED WITH BEGIN AND END**
```sql
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		<loop processing>  
	END
```

- **`BREAK`**
```sql
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		<loop processing>  
		IF @count = 5  
			BREAK;  
	END
```

- **`CONTINUE`**
```sql
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		<loop processing>  
		IF @price = 5.0  
			CONTINUE;  
		<loop processing>  
	END
```

- **Deleting a Procedure**
	- `DROP PROCEDURE procedure_name`

- **Cursors**
	- Used to access a SELECT result set on row at a time
	- ![[Pasted image 20241102124837.png]]

![[Pasted image 20241102124907.png]]