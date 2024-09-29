 - ###### [Text Files](https://www.youtube.com/embed/1vS2KXf0Esc?si=2k0WDJJa3K_aLy0q) 
	- ![[Pasted image 20240929130956.png]]
	```php
	// Check to see if file exists:
	if (file_exists("log.txt")) {
	    $file = "log.txt";
	   
	    // This GETS CONTENTS from a file path
	    $current = file_get_contents($file);
	}
	// If it doesnt, create one...
	else {
	    $my_file = fopen("log.txt", "w");
	}
	
	//IN ANOTHER FILE CALLED process.php
	$comment = $_POST["comment"];
	$file = "log.txt";
	
	//Writing to a file
	file_put_contents($file, $comment);
	
	// Use this header to redirect where user goes?
	header("Location: http://localhost/");
	```
	
	[if ( file_exists('log.txt') )](https://www.w3schools.com/php/func_filesystem_file_exists.asp) - returns true or false  
	[$file = fopen('log.txt','w')](https://www.w3schools.com/php/func_filesystem_fopen.asp) - creates log.txt and prepares to write to it.  
	[file_put_contents('log.txt',$message)](https://www.w3schools.com/php/func_filesystem_file_put_contents.asp) - writes the contents of message to the file  
	[$text = file_get_contents('log.txt')](https://www.w3schools.com/php/func_filesystem_file_get_contents.asp) - retrieves the contents of the file and places it into $text  
		
	Here is how to read a file data.txt, by line using [fgets( )](https://www.w3schools.com/php/func_filesystem_fgets.asp).     ( [code](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/while.txt) ) ( [run it](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/while.php) )  
	**header("Refresh:0")** - refreshes the current page in 0 seconds  
	**header('Location: http://www.google.com')** - transfers to www.google.com  
	**header('Location: https://localhost/files/index.html')** - transfers user back to this page
	
- ###### **Useful File Functions**
```php
//Open file. create file if its doesnt exist
$h = fopen("data.txt", "w+");

//Write to file
fwrite($h, "TEXT");
$h2 = fopen("moredata.txt", "r+");

//Read file line by line.
while (!feof($h2)) {
    echo fgets($h2) . "<br>";
}

//Append to a txt file
fwrite($h2, "<br>Hello again!");

//Close file when finished.
fclose($h2);
```

- ###### [JSON Data](https://youtu.be/0pGafJLVb5M?si=Yhr3sMt6vZJDseH_)
	```php
		//Storing the JSON file into a variable
		$drinks =  file_get_contents("drinks.json");
		
		//Converting the JSON file using decode.
		//THIS will convert the JSON file into an array of objects
		$drinks = json_decode($drinks);
		
		//Some weird arrow syntax to grab the name of each drink obj
		foreach ($drinks as $drink) {
		    echo $drink->name . "  $" . $drink->price . "<br>";
		}
	```
###### **htmlspecialchars** **AND** **htmlentities
- In PHP, both htmlspecialchars() and htmlentities() are used to convert special characters to their corresponding HTML entities, which helps prevent Cross-Site Scripting (XSS) attacks by escaping characters like <, >, and &.

- echo **htmlspecialchars( "<", ENT_QUOTES,'utf-8')**; [( output )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/htmlspecialchars.png) [( code )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/htmlspecialchars.txt) [( run it )](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/htmlspecialchars.php)  
    
    htmlspecialchars(): Only converts a few special characters to their HTML entities, namely:  
    `&` (ampersand) → &amp;  
    `<` (less than) → &lt;  
    `>` (greater than) → &gt;  
    `"` (double quote) → &quot; (if ENT_NOQUOTES is not used)  
    `'` (single quote) → &#039; (if ENT_QUOTES flag is used)  
    
- echo **htmlentities( "<" )**;  
    
    htmlentities(): Converts all applicable characters to HTML entities, including special characters like accented letters.
    
    **htmlspecialchars()**: Use this when you only need to escape a few special characters and don't want to affect other content. It's more common for most cases like escaping input for HTML output (e.g., displaying user input in a form).
    
    **htmlentities()**: Use this when you want to convert all characters that have an HTML entity equivalent. This might be useful when dealing with documents that contain special symbols, foreign characters, or other specific needs where more thorough escaping is required.
    
- Example showing differences: ( [output](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/html.png) ) ( [code](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/html.txt) ) ( [run it](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class5/html.php) )

###### **Validate and Filter Email**
```php
//check to see if form is submitted
if (isset($_POST["email_btn"])) {

	//filter and sanitize the incoming input (email)
    $email = filter_input(INPUT_POST, "email", FILTER_SANITIZE_EMAIL);
    
    // Validate the sanitized input
    if (filter_var($email, FILTER_VALIDATE_EMAIL)) {
        echo "Success: $email";
    } else {
        echo "Failure: Error";
    }
}
```