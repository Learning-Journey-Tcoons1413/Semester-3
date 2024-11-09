*Date: November 4th 2024*

 ```php
 <?php
 
// First thing is connect to database
$dsn = "mysql:dbname=store;host=127.0.0.1";
$username = "root";
$password = "";

try{
	$dbh = new PDO($dsn,$username,$password);
	echo "Connection succeeded."
}
catch(Exception $ex){ echo "Connection failed..."}

// -> Used basically as a . operator for regular OOS methods
// Below we use the exec() method on the PDO object to inject a sql statement. Insert data into the table.
$dbh->exec("INSERT INTO inventory VALUES(,'Product1','This is Product1',12.99,1,'Products')")

// Accessing with query() method to get the data from the database.
// query() returns an associative array.
$result = $dbh->query("SELECT * FROM inventory",PDO::FETCH_ASSOC);
foreach($result as $r){
	echo $r;
}
?>
```

###### Downloading and Importing Database into MySQL folder with xamp

Once the .sql file is downloaded and in the Downloads folder, do the following:

**Just type this part:**
```bash
cd \xampp\mysql\bin
```

**After that, run the command to import the SQL file:**
```bash
mysql -uroot dictionary < C:\\Users\\tomco\\Downloads\\dictionary.sql
```

The downloaded .sql file will be in the downloads folder. Above statement is navigating to that folder and importing into MySQL xamp folder.  

**NOTE: you can create a database like this**
`CREATE DATABASE dictionary` OR you can do it with windows explorer by creating a folder. 








