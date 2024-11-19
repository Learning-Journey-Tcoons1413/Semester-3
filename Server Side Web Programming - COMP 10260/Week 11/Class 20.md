*Date: November 18th 2024*

# **REST**

 GET, POST, PUT, DELETE
 
 CRUD stands for **Create, Read, Update, Delete**, which are the four basic operations used in persistent storage systems such as databases. Here’s a breakdown:

### **1. Create**

- Adding new records or data entries to a system.
- Example:
```sql
INSERT INTO users (name, email) VALUES ('Alice', 'alice@example.com');
```

### **2. Read**

- Retrieving or reading data from a system.
- Example:
```sql
SELECT * FROM users WHERE id = 1;
```

### **3. Update**

- Modifying existing records or data entries.
```sql
UPDATE users SET email = 'newalice@example.com' WHERE id = 1;
```
### **4. Delete**

- Removing data from the system.
- Example:
```sql
DELETE FROM users WHERE id = 1;
```

CRUD forms the foundation of many applications, especially in database-driven systems, and is implemented in most programming languages using frameworks or libraries that interact with databases. Would you like examples in a specific programming language?

1. Create → POST
2. Read → GET
3. Update → PUT/PATCH
4. Delete → DELETE

HTTP://domain/path/scriptname.php

C://xampp/htdocs/scriptname.php

This `.htaccess` configuration is used to enable URL rewriting in Apache servers, which can help create cleaner, user-friendly URLs. Here's an explanation of each line:

---

### **1. `RewriteEngine on`**

- **Purpose**: Enables the Apache rewrite engine. Without this, the rewrite rules won't work.

---

### **2. `RewriteRule . index.php [L]`**

- **Purpose**: Redirects all incoming requests to `index.php`.
- **Breakdown**:
    - **`.`**: Matches any URL (except empty ones, unless a condition is added).
    - **`index.php`**: Specifies the destination for the redirect.
    - **`[L]`**: Stands for "Last." It tells Apache to stop processing further rules if this one matches.

---

### **How It Works**

1. Any request to the server (e.g., `/about`, `/contact`, `/profile`) is rewritten to `index.php`.
2. The query string or additional information from the URL can be processed by `index.php`, often using a routing mechanism in the application.

---

### **Practical Use Case**

This configuration is common in frameworks like Laravel, CodeIgniter, or custom PHP applications where you want a single entry point (e.g., `index.php`) to handle all requests and determine routing dynamically.

---

### **Example**

A URL like:
`http://example.com/about`

Will internally be handled as:
`http://example.com/index.php`

From here, the application can parse the URL path (`about`) to load the appropriate content.

```php
<?php
$url = $_SERVER["REQUEST_URI"];
$request = $_SERVER["REQUEST_METHOD"];
$param = explode("/", $url);

if ($request === "GET") {
    echo "User {$param[2]}";
} else if ($request === "DELETE") {
    echo "You wanna delete User {$param[2]}?";
} else {
    echo "Invalid!";
}
```



 