###### **Sessions and Session Variables**
- Session Variables are a way to carry information across multiple pages
- Unlike cookies, session data is not stored on the user's computer, it is stored on the server.

[Watch This For Help](https://www.youtube.com/embed/W4rSS4-LdIE)
- This example is located in: `http://localhost/10260/samscottvideos/class9/sessionvariables/page1.php`

- In order to work with session variables we must start a session on every page at the very top.
	```php
	//page1.php
	if (isset($_POST['submit'])) {
	
	    // Start the session
	    session_start();
	
	    //BELOW: taking the post values and putting into session variables
	    $_SESSION['name'] = htmlentities($_POST['name']);
	    $_SESSION['email'] = htmlentities($_POST['email']);
	
	    //Redirect user to different page!
	    header('location: page2.php');
	}
	```

- **page2.php**
```php
	//page2.php
	<?php
	session_start();
	$name = $_SESSION['name'];
	$email = $_SESSION['email'];
	?>
```

- **Below is the FORM used for the above examples used in page1.php**
```php
	//page1.php
    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
        <input type="text" name="name" placeholder="Enter name">
        <input type="text" name="email" placeholder="Enter email">
        <input type="submit" name="submit" value="Submit">
    </form>
```

- **page3.php**
```php
	//page3.php
	session_start();
	$name = $_SESSION['name'];
	$email = $_SESSION['email'];
```

- **Getting rid of session variables**
```php
	session_start();
    unset($_SESSION["name"]);
```

###### **Useful Session Functions**
**session_start()**

Initializes a new session or resumes an existing session. It must be called before any output is sent to the browser.

// Always call this at the beginning of your script.  
  session_start();

---

**$_SESSION[ ]**

A superglobal array used to store session variables. You can assign and retrieve values from this array.

  session_start();  
  $_SESSION['username'] = 'Dave';  
  echo $_SESSION['username']; // Outputs: Dave

---

**session_destroy()**

Destroys all data registered to a session. This function does not unset global variables associated with the session

  session_start();  
  // Ends the current session and clears session data.  
  session_destroy();

---

**session_unset()**

Frees all session variables, but does not destroy the session itself.

  session_start();  
  // Clears all session variables.  
  session_unset();

---

**session_id()**

Returns the current session ID, or sets a session ID if provided as a parameter.

  session_start();  
  // Get the current session ID.  
  echo session_id();  
  // Optionally set a new session ID.  
  session_id('new_session_id');

###### **Uploading Files and Images**
- This example is located in: `http://localhost/10260/samscottvideos/class9/uploadingfilesandimages/`

	```php
	//index.php
	<!DOCTYPE html>
	<html lang="en">
	<head>
	    <meta charset="UTF-8">
	    <meta name="viewport" content="width=device-width, initial-scale=1.0">
	    <title>Document</title>
	</head>
	<body>
	    <form action="uploads.php" method="POST" enctype="multipart/form-data">
	        <input type="file" name="file">
	        <button type="submit" name="submit">Upload</button>
	    </form>
	</body>
	</html>
	
	  
	<!-- enctype="multipart/form-data" allows us to pass images into our form. Something to do with encoding idk-->
	
	```

	```php
	//uploads.php
	if (isset($_POST['submit'])){
	    $file = $_FILES['file'];
	
	    $fileName = $_FILES['file']['name'];
	    $fileTmpName = $_FILES['file']['tmp_name'];
	    $fileSize = $_FILES['file']['size'];
	    $fileError = $_FILES['file']['error'];
	    $fileType = $_FILES['file']['type'];
	
	    $fileExt = explode('.',$fileName);
	    $fileActualExt = strtolower(end($fileExt));
	
	    $allowed = array('jpg','jpeg','png','pdf');
	
	    if (in_array($fileActualExt,$allowed)){
	        if ($fileError === 0){
	            if ($fileSize < 1000000){
	                $fileNameNew = uniqid('',true).".".$fileActualExt;
	                $fileDestination = "uploads/$fileNameNew";
	                move_uploaded_file($fileTmpName,$fileDestination);
	                header("Location: index.php");
	            }
	            else{
	                echo "file too big";
	            }
	        }
	        else{
	            echo "Cant error";
	        }
	    }
	    else{
	        echo "Cant upload";
	    }
	}
	```