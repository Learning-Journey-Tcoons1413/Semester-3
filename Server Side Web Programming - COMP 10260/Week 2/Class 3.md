*Date: September 12th 2024
###### **Conditionals**
```php
{
$score += 10;
$dragon_kills++;
}
```
- IF / ELSEIF / ELSE
```php
if ($some_condition)
{
	// Do something;
}
elseif ($some_other_condition)
{
	//Do something;
}
else
{
	//Do something else;
}
```
- SWITCH
```php
switch ($some_condition){
	case 1:
		//Do something;
		break;
	case 2:
		//Do something;
		break;
	default:
		//Catch anything that does not meet a case;
		break;
}
```

###### **Iterators**
- WHILE
```php
while ($some_condition){
	//Do something;
}
```
- DO WHILE
```php
do {
	//Do something;
} while ($some_condition);
```
- FOR
```php
for ($i = 0; $i < 4; $i++){
	//Do something;
	//1) Initializer
	//2) Exit Condition
	//3) Increment
}
```
- FOR EACH
```php
$player_names = array('Dave','Charley','Tom');
foreach ($player_names as $name){
	echo $name;
}
```
- BREAK 
```php
for ($i = 0; $i < 4; $i++){
	if (some_condition_met){
		break;
	}
	//Continue to do something;
}
```
- CONTINUE
```php
for ($i = 0; $i < 4; $i++){
	if (some_condition_met){
		continue;
	}
	//Continue to do something;
}
```

###### **Built In Functions**
- PRINTF
```php
$name = 'Thomas';
printf('%s is my name',$name);
//%s STRING
//%d INTEGER
//%f FLOAT ex) %.3f
//%b BINARY
```
- SPRINTF
```php
$a = sprintf('%b',$my_var);
//It allows us to format a string and store it in a variable
```
- FOPEN
```php
$file_handle = fopen('c:/xampp/tmp/copied.html','r');
//r = read for normal txt
//rb = binary read for binary files
```
 - READING
 ```php
 $data = '';
 $file_handle = fopen('c:/xampp/tmp/copied.html','rb');
 while (!feof($file_handle)){
	 //feof checks if we are at the end of the file
	 $data .= fread($file_handle,4096);
 }
 echo $data;
```
- CLOSE
```php
 $data = '';
 $file_handle = fopen('c:/xampp/tmp/copied.html','rb');
 while (!feof($file_handle)){
	 //feof checks if we are at the end of the file
	 $data .= fread($file_handle,4096);
 }
 fclose($file_handle); //Close the file
 $new_handle = fopen('c:/xampp/tmp/copied.html','wb');
 fwrite($new_handle,$data);
 fclose($new_handle);
```
- Closing files is important:
	- Limited number of files available
	- High RAM consumption
	- Operations may not complete until file is closed
	
- EXTERNAL PROGRAMS
```php
system('dir ./test');
//Represents the command shell like windows and can execute shell code i guess?
```
- MATH
```php
$my_num = rand(100,200);
//Lots of other stuff probably 
```
- INCLUSION
```php
$i = 4;
$j = 5;
require 'need.php'; 
//Specifies php code to be brought into current file but code wont run if this fails
include 'niceToHave.php'; 
//Specifies php code to be brought into current file but code will still run if this fails
echo $i . ' ' . $j;
//NOTE: the files being brought in via require and include may potentially alter the variables stored inside i and j. 
```
- ERROR HANDLING
```php
try{
	//Attempt some code to execute;
}
catch(Exception $e){
	//Catch any errors;
}
```

```php
@$file_handle = fopen('file path');
//The @ symbol supresses error messages. If this variable does not get set because of an error, the @ symbol will just set this variable to null. This is bad because if this variable is used later on in the code, then it will eventually throw an error at that location in the code. 
```
- CLOSING AND OPENING PHP
```php
<?PHP
	$i = 0;
?>
```

MEDIA REFERENCES - READ THESE OVER
- printf
- fopen
- fread
- feof
- fwrite
- fclose
- fprintf
- rand

###### **Defining Functions**
```php
function functionName($parameter1, $parameter2) { // Function body return $result; // Optional return }
```

###### **Coalescing Operator**
- The ?? operator in PHP is called the null coalescing operator. It is used to provide a default value when a variable or expression is null or undefined. This operator is particularly useful for handling situations where variables might not be set, allowing you to avoid errors related to accessing undefined variables.
- The ?? operator returns the first operand if it exists and is not null; otherwise, it returns the second operand.
```php
$variable = $value1 ?? $value2;
//if $value1 is set and is not null, $variable will be assigned the value of $value1.
//if $value1 is null or not set, $variable will be assigned the value of $value2.
```
- EXAMPLE:
```php
// Suppose $_POST['age'] is not set (e.g., the form was not submitted or the input was left empty).
$age = $_POST['age'] ?? 'Age not provided';

// This will output: Age not provided
echo $age;
```

###### **Sanitize Data**
- **What does it mean?**
	- Sanitizing input in PHP means cleaning the data to make it safe for use in your application, especially when dealing with user inputs. This process helps prevent security vulnerabilities like cross-site scripting (XSS) attacks, which can occur when user-supplied data is output directly to the web page without proper handling.
```php
//When you sanitize the name input, you are removing or escaping potentially harmful characters that could alter the way your web page is displayed or executed. In your program, you used the FILTER_SANITIZE_SPECIAL_CHARS filter with filter_input() to sanitize the name input:
$name = filter_input(INPUT_POST, "name", FILTER_SANITIZE_SPECIAL_CHARS);
```
- **How does FILTER_SANITIZE_SPECIAL_CHARS work?**
	- The FILTER_SANITIZE_SPECIAL_CHARS filter replaces special characters with their corresponding HTML entities. This means it converts characters like <, >, ", ', and & into &lt;, &gt;, &quot;, &#039;, and &amp; respectively. By doing so, it prevents these characters from being interpreted as HTML or JavaScript when output to the browser, thereby reducing the risk of XSS attacks.

###### ***Super Global Variables*
- **$SERVER['PHP_SELF'] - is the current file's name. ([read more](https://www.w3schools.com/php/php_superglobals_server.asp))*  

- **$POST[ ] - is an array of all of the variables recently POSTed from a form submission. ([read more](https://www.w3schools.com/php/php_superglobals_post.asp))*  
  
- **$GET[ ] - is an array of all of the variables recently GETed from a form submission. ([read more](https://www.w3schools.com/php/php_superglobals_get.asp))*
###### Reading Variables from Forms
1. **Get & Post**  
    _( This is NOT a good way to read in a NAME and AGE from an html form. )_  
    [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/readage.png) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/readage.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/readage.php)  
      
    
2. **filter_input ( )**  
    _( This is good way of reading in a NAME and AGE from an html form. )_  
    [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/filter_input.png) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/filter_input.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/filter_input.php)  
      
    
3. **Expect Function(s)**  
    _( This is another good way of reading in a NAME and AGE from an html form. )_  
    [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/readage.png) [( expectAlphaWithSpaces )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/expectAlphaWithSpaces.txt) [( expectInt )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/expectInt.txt) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/test.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class3/test.php)




