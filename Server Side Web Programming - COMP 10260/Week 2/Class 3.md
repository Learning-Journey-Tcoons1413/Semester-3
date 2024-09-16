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