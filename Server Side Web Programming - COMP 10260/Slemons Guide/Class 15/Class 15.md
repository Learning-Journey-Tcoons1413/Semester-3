###### Connecting PHP to MySQL Database:

###### **PDO**:
- **What is PDO:**
	- PHP Data Objects (PHP Extension)
	- A way to access a database
	- Data Access Layer
	- Object Oriented 
	  
- **Benefits**:
	- Multiple Databases 
	- Security / Prepared Statements
	- Usability
	- Reusability 
	- Excellent Error Handling
	  
- **3 Main Classes**
	- PDO: connection between PHP and DB
	- PDOStatement: prepared statement and after execution, an associated result 
	- PDOException: error raised by PDO

###### **Create and Use Database From Command Line**
```bash
CREATE DATABASE database_name;

USE database_name;

CREATE TABLE table_name (
	column1_name data_type AUTO_INCREMENT PRIMARY KEY, 
	column2_name data_type,
	column3_name data_type DEFAULT TRUE
);
```

###### **Dave's Way to Connect to Database**
```php
<?php
// Connecting MySQL to PHP

// Key values
$host = "localhost";
$user = "root";
$password = "";
$dbname = "dictionary";   // Change this line to the correct db
					
// Set data source name with UTF-8 encoding
$dsn = "mysql:host=".$host.";dbname=".$dbname.";charset=utf8";

try {
    // Create a PDO instance with error handling
    $pdo = new PDO($dsn, $user, $password);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	$pdo->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE,PDO::FETCH_ASSOC);
	
	
} catch (PDOException $e) {
    // Handle connection error
    echo "Connection failed: " . $e->getMessage();
}
?>
```
###### **Inside PHP**
```php
// SET UP VARIABLES
$host = 'localhost';
$user = 'root';
$password = "";
$dbname = "database_name";

// SET UP DSN
$dsn = 'mysql:host=' . $host . ';dbname=' . $dbname;

// CREATE PDO
$pdo = new PDO($dsn, $user, $password);

// SIMPLE PDO QUERY
$statement = $pdo->query('SELECT * FROM table_name');

// LOOP THROUGH STATEMENT OBJECT
// FETCH -> FETCH_ASSOC
// FETCH -> FETCH_OBJ
// NOTE: $row IS AN ASSOC ARRAY
while ($row = $statement->fetch(PDO::FETCH_ASSOC)){
	echo $row["column_name"] . "<br>";
}
```

###### **Back To Command Line**
```bash
INSERT INTO table_name (column1, column2, column3, ...)
VALUES (value1, value2, value3, ...);

OR

INSERT INTO table_name 
VALUES (value1, value2, value3, ...);

USE NULL FOR PRIMARY AUTO INCREMENT KEYS

INSERT INTO Employees 
VALUES (NULL, 'John', 'Doe', '2024-05-15', TRUE);
```

###### **Back To PHP**
```php
// You can also fetch(PDO::FETCH_OBJ)
while ($row = $statement->fetch(PDO::FETCH_OBJ)) {
    echo $row->column_name . "<br>";
}

// SET DEFAULT ATTRIBUTE TO FETCH_OBJ. Now you can just use fetch()
$pdo->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE,PDO::FETCH_OBJ);

while ($row = $statement->fetch()) {
    echo $row->column_name . "<br>";
}
```

###### **Positional Params**
```php
// USER INPUT EXAMPLE
$author = 'Anthony';

// PREPARE AND EXECUTE STATEMENTS

// BAD BAD BAD DONT DO THE BELOW CODE!!!!!!!!!!!!
$sql = "SELECT * FROM table_name WHERE column_name = '$INPUT'";

// WE MUST USE PREPARED STATEMENTS. POSITIONAL - NAMED PARAMETERS

// POSITIONAL 
// '?' REPRESENTS POSITIONAL PARAM
$sql = "SELECT * FROM posts WHERE column_name = ?";
$statement = $pdo->prepare($sql);

// EXECUTE TAKES A REGULAR ARRAY. BASICALLY FILLING IN THE '?' PARAM
$statement->execute([$author]);

// fetchAll() RETURNS AN ARRAY OF THE RESULT SET. IN THIS CASE, ARRAY OF OBJECTS
$posts = $statement->fetchAll();
foreach ($posts as $post) {
    echo $post->title . "<br>";
}
```

###### **Named Params**
```php
$sql = "SELECT * FROM posts WHERE author = :author";
$statement = $pdo->prepare($sql);

// EXECUTE TAKES AN ASSOC ARRAY FOR NAMED PARAMS
$statement->execute(['author' => $author]);

$posts = $statement->fetchAll();

foreach ($posts as $post) {
    echo $post->title . "<br>";
}
```

###### **Additional Conditions in WHERE Clause**
```php
// USER INPUT EXAMPLE
$author = 'Anthony';
$is_published = true;

$sql = "SELECT * FROM posts WHERE author = :author AND is_published = :is_published";

// EXECUTE TAKES AN ASSOC ARRAY FOR NAMED PARAMS
$statement->execute(['author' => $author, 'is_published' => $is_published]);

$posts = $statement->fetchAll();
foreach ($posts as $post) {
    echo $post->title . "<br>";
}
```

###### **Info On execute() and prepare()**
- The `execute()` method is called with an **associative array**, where the keys are the named parameters (`:author`, `:is_published`), and the values are the user inputs (`$author`, `$is_published`).
- This step **binds** the user inputs to the prepared statement, ensuring they are correctly escaped and not interpreted as part of the SQL query itself.

###### **Get Row Count**
```php
//************************ GET ROW COUNT ********************************/
$sql = "SELECT * FROM posts";
$statement = $pdo->prepare($sql);
$statement->execute();
$rowCount = $statement->rowCount();

echo $rowCount;
```

###### **Inserting Data**
```php
$title = "Seventh Post";
$body = "This is post seven";
$author = "John Doe";

$sql = "INSERT INTO posts(title,body,author) VALUES(:title, :body, :author)";
$statement = $pdo->prepare($sql);
$statement->execute(['title' => $title, 'body' => $body, 'author' => $author]);

echo "Post added.";
```

###### **Updating Data**
```php
$id = 1;
$body = "This is updated post one";

$sql = "UPDATE posts SET body = :body WHERE id = :id";
$statement = $pdo->prepare($sql);
$statement->execute(['body' => $body, 'id' => $id]);

echo "Post updated.";
```

###### **Deleting Data**
```php
$id = 7;

$sql = "DELETE FROM posts WHERE id = :id";
$statement = $pdo->prepare($sql);
$statement->execute(['id' => $id]);

echo "Post deleted.";
```

###### **Searching Data**
```php
// F must be at the beginning of the 'title' column. 
$search = "F%";

$sql = "SELECT * FROM posts WHERE title LIKE :title";
$statement = $pdo->prepare($sql);
$statement->execute(["title" => $search]);
$posts = $statement->fetchAll();

foreach ($posts as $post) {
    echo $post->title  . " by: {$post->author}" . "<br>";
}
```

##### About Encrypting a Database
---

**Transparent Data Encryption (TDE)**

_If you're using MySQL Enterprise Edition (paid version), Transparent Data Encryption (TDE) can encrypt the entire database (tablespace-level encryption) transparently. TDE provides at-rest encryption, so the data is encrypted on disk but is decrypted in memory when accessed by applications._

---

**Column-Level Encryption with MySQL Functions (AES_ENCRYPT)**

_Using MySQL’s built-in AES_ENCRYPT and AES_DECRYPT functions is the most straightforward method for encrypting individual fields. With this approach:_  
  
**Encryption**: _Use AES_ENCRYPT to encrypt data before storing it in a column. You would pass both the data and a key to the function._  
For example,  
  **_INSERT INTO my_table (id, encrypted_data) VALUES (1, AES_ENCRYPT('Sensitive Data', 'encryption_key'));_**  
  
**Decryption**: _Use AES_DECRYPT when retrieving data, passing the same key used for encryption._  
For example,  
  **_SELECT AES_DECRYPT(encrypted_data, 'encryption_key') FROM my_table WHERE id = 1;_**  

  
  
_Special Note: the encryption_key or SALT is often stored on another computer._
###### ==Working example found in Sam Scott videos Class 15==

The difference between `fetch()` and `fetchAll()` in PDO (PHP Data Objects) is in how they retrieve the data from the database.

### 1. **`fetch()`**:

- **Purpose**: Retrieves a **single row** from the result set.
- **Return Type**: Returns an **associative array** (or another format, depending on the fetch mode), or `false` if no more rows are available.
- **Usage**: Typically used when you expect only **one row** to be returned or you want to retrieve rows **one by one**.

#### Example:

php

Copy code

`$stmt = $pdo->prepare("SELECT * FROM users WHERE id = :id"); $stmt->execute([':id' => 1]); $user = $stmt->fetch(PDO::FETCH_ASSOC);  // Fetch one row  if ($user) {     echo $user['name'];  // Access data for a single row } else {     echo "No user found!"; }`

- `fetch()` returns **only the first row** matching the query (or `false` if no results are found).

### 2. **`fetchAll()`**:

- **Purpose**: Retrieves **all rows** from the result set.
- **Return Type**: Returns an **array of rows**, where each row is typically an associative array (or another format, depending on the fetch mode).
- **Usage**: Used when you want to retrieve **multiple rows** in a single call.

#### Example:

php

Copy code

`$stmt = $pdo->prepare("SELECT * FROM users"); $stmt->execute(); $users = $stmt->fetchAll(PDO::FETCH_ASSOC);  // Fetch all rows  foreach ($users as $user) {     echo $user['name'] . "<br>";  // Loop through and access all rows }`

- `fetchAll()` returns an **array of all rows** that match the query, where each row is an associative array.

---

### Key Differences:

|Feature|`fetch()`|`fetchAll()`|
|---|---|---|
|**Purpose**|Fetch a **single row** from the result set.|Fetch **all rows** from the result set.|
|**Return Type**|Single row (array) or `false` if no more rows.|An **array of rows** (empty array if no results).|
|**Usage**|Best for retrieving one row or looping through rows **one by one**.|Best for retrieving multiple rows in one go.|
|**Performance**|More memory-efficient if only one row is needed.|May consume more memory if there are many rows, since it loads all rows into memory at once.|

### When to Use Each:

- **`fetch()`** is useful if you're dealing with a result set that contains just one row, or if you want to loop through the rows manually and process them one by one.
- **`fetchAll()`** is useful when you need to retrieve **all rows** at once, such as when displaying a list of results or performing bulk processing on the entire result set.

### Example Scenarios:

- **Use `fetch()`**: When querying a database for a single record by its primary key, like getting a user by their ID.
- **Use `fetchAll()`**: When retrieving all records in a table, like getting all users or fetching a list of products.

### Additional Notes:

- When using `fetchAll()`, if the query result is large (e.g., thousands of rows), it may consume significant memory. For large datasets, it's better to use `fetch()` in a loop, as it will process rows one at a time, without loading everything into memory at once.