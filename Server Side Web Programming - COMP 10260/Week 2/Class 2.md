*Date: September 9th 2024
###### ***Introduction***
- Deterministic Programs
	- Input determines the output
- **Statements**
	- Assignment
	- Expressions
	- Iteration
	- Conditionals
	- Execution
	- Something else
- **Variables and Data Types**
	- Manipulates with operators
- **Type Check** - PHP
	- Dynamic:
		- Checks type while running
		- Attempts to convert variable into needed type
	- Static:
		- Think of Java
- **PHP Has 8 Primitive Data Types**
	- Integer
	- Floats
	- String
	- Boolean 
	- Array 
	- Object
	- NULL
	- Resource
###### **Assignments**
- Variables:
	```php
	//Variables declared with a $
	//Statements end with a ;
	$variable = "Thomas";
	$array = array("Thomas", "Coons");
	```
 
###### **Operations and Expressions**
- **Arithmetic Operators:**
```
	addition + 
	subtraction - 
	multiply *
	divide /
```
- **Assignment Operators**
```
	+=
	-=
	*=
	/=
```
- **Comparison Operators**
```
	==
	===
	!=
	<> greater / lesser
	!==
```
- **Logical Operators**
```
	and
	or
	xor
	!
```
- **Conditional Assignment Operator (Turnary)**
```php
	$a ? $b : $c;
	//If a is true, b is returned
	//If a is false, c is returned
```
- **Increment Operators**
```php
	$b = ++$a; //pre
	$b = $a++; //post
```
- **String Operators**
```php
	. //String concatenation
	= //Combines second string to first
	[n] //Slicing using indexes
	$b[0] = $a; //Changing the index 0 of specific string
```
- **Order of Operations for Operators**
```
	++ or --
	* or / 
	+ - .
	?:
	= or += or -= or *= or /=
	.......missing info
```
 
###### **Advanced Variable Types**

- **Associative Arrays:**
	- They are key / value pairs
```php
$capitals = array(
    "Canada" => "Ottawa",
    "Japan" => "Tokyo",
    "Germany" => "Berlin",
);

$capitals["Japan"] = "Kyoto"; //update key
$capitals["China"] = "Beijing"; //add key value
array_pop($capitals); // Pop last element
array_shift($capitals); // Pop first element
$keys = array_keys($capitals); // Returns new array of keys
$values = array_values($capitals); // Returns new array of values
$capitals = array_flip($capitals); // Flips the key and value. Return new associative array

foreach ($keys as $key) {
    echo $key . "<br>";
}
```

- Regular Arrays:
	- implode (array to string) [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/implode.png) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/implode.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/implode.php)
		- Array to string
	```php
			$arr = ["Thomas", "Coons"];
			echo implode(" - ", $arr);
			//output: Thomas - Coons
	```
	- explode (string to array) [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/explode.png) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/explode.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/explode.php)
		```php
			$str = "Thomas Coons";
			$str =  explode(" ", $str);
			foreach ($str as $letter) {
			    echo $letter . "<br>";
			}
		```
	- str_split (string to array of characters) [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/str_split.png) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/str_split.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class4/str_split.php)
