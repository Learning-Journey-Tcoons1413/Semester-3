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