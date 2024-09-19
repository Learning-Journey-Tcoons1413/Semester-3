*Date: September 16th 2024
##### **Web Architecture Module**
###### **HTTP**
- Works via requests and responses 
- GET - Browser specifies a path and requests- ? and & 
- POST - Browser specifies a path and provides data in the body of HTTP
###### **Dynamic HTML**
- Client Side- uses JS + HTML. This code executes on the client side
###### **Server Side Script**
- Generated on the server and sent back to the client as html 
###### **Input Types**

###### **Methods**
- GET request 
	- can be cached
	- human readable
- POST request
	- can't be seen by anyone observing the browser URL bar

###### **Multiple HTML Forms**
- Web pages can have multiple HTML Forms
- They can not be nested
###### **Working With HTML Forms and PHP**
- PHP parses http://myserver.com/myapp.php?username=xxx
- PHP then puts the values into an array 
- PHP uses `$_GET` and `$_POST` to parse the data in the URL 
###### **==NOTE: filter_input() is important==**

###### **Getting Headers and Other Data**
`` $_SERVER[' HTTP_CONNECTION ']``
`` $_SERVER[' HTTP_USER_AGENT ']``
```php
header("Location: http://www.apple.com")
//Allows us to manipulate the HTTP Response headers
```
###### **==NOTE: Research Headers with PHP

###### **==NOTE: Research isset()


