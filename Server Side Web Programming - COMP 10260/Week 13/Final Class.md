#### **Final Exam Information**
###### Basic PHP semantics
- **Focus on Question 2 Jonathan's Mock Exam**
	- Double quotes -> string interpolation 
	- Single quotes -> do not interpolate 
###### Taking client input
###### File Uploads (I won't ask you to code anything) - **==STUDY==**
- POST request contains the file 
- PHP receives this and stores it into a temporary directory 
- Populates super global `$_FILES[]` 
	- consists of `["name"]`, `["type"]`, `["error"]`, `["size"]`
- Coder must use a function to move the files from temporary directory to wherever we need to go. Also sanitize stuff like the filename.  Significant Sanitization!
###### File IO 
- json
- csv
- txt
- blah blah blah 
###### Databases
- WE MUST KNOW HOW TO CODE AND CONNECT TO A DATABASE
- KNOW HOW TO WRITE SQL COMMANDS
###### Password Hashing
- ==SALTING==
- password_hash()
- password_verify()
- md5()
- **NOTE:**
	- encryption can be decrypted and vice versa 
	- hashing is not reversable 
###### SQL injection
- Directly concatenating user input with our SQL commands
- We use prepared statements to deal with this 
```php
$stmt = $pdo->prepare($sql);
$stmt->execute();
$result = $stmt->fetch();
```
###### Sessions/Cookies
- **Focus on Question 1 Jonathan's Mock Exam**
- **Sessions:** These functions generally return Booleans
	- session_start()
		- starts the session
	- session_unset()
		- unsets all session variables
	- session_destroy()
		- destroys the session
###### MVC architecture
- Software Methodology 
- Each section is a functional spec and area that they are in charge of:
1. **Model**
	- How the system talks to the database / datastore 
	- ex) PHP program that talks to database
	- Something that describes your data structure 
2. **View**
	- Generates the front end for the user (UI)
	- Also involves using PHP to generate HTML
3. **Controller**
	- Routes requests. Controls the flow. 
	- Makes calls to the view and model when necessary 
- **MVC Ordering**
	1. Controller
	2. Model
	3. View
###### REST APIs
- A way to define how functions in a program can be accessed using a 
- **WE CREATE AN HTACCESS FILE**: Maps routing to single index.php file 

- ex) 
```php
// This would be in your index.php hooked up with .htaccess
// This code can be considered as a controller

function getStudentData(number){
	
}

function changeStudentEmail(number, email){
	
}

// note: anything on the url can be considered GET

$uri = $_SERVER["REQUEST_URI"]; 
$uri_parts = explode("/",$uri); // use explode: note zero elemnt has nothing

if ($_SERVER["REQUEST_METHOD"] === "GET" && $uri_parts[2] === "studentinf"){
	if (isset($uri_parts[3])){
		getStudentData(number);
	}
}


```
- **URL**:
- **METHODS**: GET, POST, PUT, DELETE
- ==**TEST QUESTION: BUILD A REST APPLICATION CONTROLLER**==
	- This is the application that receives 

###### File Includes and File Require - ==**STUDY**==
- basically these allow you to copy and paste the required or included code into the current file without copy pasting. 
- know the difference between include and require:
	- include brings in a file and it does not exist:
		- Warning is generated 
	- require brings in a file and it does not exist:
		- FATAL ERROR and program stops 
	- include once:  
	- require once:

==QUESTION ON EXAM: Here is a script, what is wrong with it?==





