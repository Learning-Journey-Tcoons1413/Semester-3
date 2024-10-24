 ###### **CSV Files**
- Comma Separated Values
- It is a tabular format rows and columns
- Example is found: http://localhost/10260/samscottvideos/class11/

###### **Cookies:**
- ###### Where are Cookies Stored?
	- They are a way to store information on the user's computer. The law in many places now demands that you ask the users permission before storing a cookie file.
	
- **Cookies exist only on the browser!**
	_Cookies are stored in different locations depending on the operating system and the web browser being used. Here’s a breakdown of where cookie files are typically stored on Windows and macOS:_  
	The easiest way in Chrome to view a cookie, is [Inspect; Application](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class11/cookie_inspect.png)
	
	Alternatively, you can view the file directly with a text editor: [cookie file locations](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class11/cookie_file_locations.html)
- Example:
```php
<?php
	// 1. Create a Cookie
	if (!isset($_COOKIE['user'])) {
	    // Set a cookie named "user" with value "Dave" that expires in 1 hour
	    setcookie('user', 'Dave', time() + 3600, "/"); // '/' means cookie is available in entire domain
	    echo "Cookie 'user' is set!<br>";
	} else {
	    echo "Cookie 'user' is already set!<br>";
	}
	
	// 2. View a Cookie
	if (isset($_COOKIE['user'])) {
	    echo "Cookie 'user' value: " . $_COOKIE['user'] . "<br>";
	} else {
	    echo "Cookie 'user' is not set!<br>";
	}
	
	// 3. Destroy a Cookie
	if (isset($_GET['delete'])) {
	    // To delete a cookie, set the expiration date to one hour ago
	    setcookie('user', '', time() - 3600, "/"); // This removes the 'user' cookie
	    echo "Cookie 'user' has been deleted!<br>";
	} else {
	    echo "To delete the 'user' cookie, append ?delete=true to the URL.<br>";
	}
?>
```

- Useful Video [Here](https://www.youtube.com/embed/RzMjwICWKr4) On cookies
###### **Sessions:**
- **Sessions EXIST only on the Server side.**  
	_Sessions are a way to store information from page to page on the server. Session data is fairly secure from the outside world. Sessions use cookies, they are cookies, they let you store all the data on the server represented as a long alphanumeric string known as the PHP session ID (It is a cookie). ==Have a firm understanding of cookies and how they relate to sessions==._
	

	**Sessions - Login Example**; _This script demonstrates how to use sessions to enable login._  
	  ( [output](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class11/login/login.png) )   ( [code](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class11/login/login.txt) )   ( [run it](https://csunix.mohawkcollege.ca/~slemon/SERVER-SIDE-Fall2024/docs/class11/login/login.php) )

```php
<?php
// Start the session
session_start();

// Check if the user is already logged in
if (isset($_SESSION['username'])) {
    header("Location: welcome.php"); // Redirect to welcome page if already logged in
    exit();
}
 
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Dummy credentials for demonstration
    $valid_username = 'admin';
    $valid_password = '123';

    // Get the posted username and password
    $username = $_POST['username'];
    $password = $_POST['password'];

    // Check credentials
    if ($username === $valid_username && $password === $valid_password) {
        $_SESSION['username'] = $username; // Store username in session
        header("Location: welcome.php"); // Redirect to welcome page
        exit();
    } else {
        $error = "Invalid username or password!";
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Page</title>
</head>
<body>
    <h1>Login</h1>
    <?php if (isset($error)): ?>
        <p style="color:red;"><?php echo $error; ?></p>
    <?php endif; ?>
    <form method="POST" action="">
        <label for="username">Username:</label>
        <input type="text" id="username" name="username" required>
        <br><br>
        <label for="password">Password:</label>
        <input type="password" id="password" name="password" required>
        <br><br>
        <input type="submit" value="Login">
    </form>
</body>
</html>
```

- Session information is stored in xampp / tmp folder 
- **JSON Example**
```php
<?php 
session_start();
$_SESSION["myCart"] = array("name"=>"Thomas","age"=>29);
```
- ==Breaking a session means you are destructing the ability to set a session.==
- `session_unset()` clears all session variables in the `$_SESSION[]` super global
- `session_destroy()` deletes server side files 