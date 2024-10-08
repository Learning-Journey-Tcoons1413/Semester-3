###### **REST API**
- Representational State Transfer
- Web based API
- **Main** **Purpose**: Build web services for web, mobile, desktop apps
- Uses HTTP (Hyper Text Transfer Protocol)  Standard protocol for communication for the internet
	- GET
	- POST
	- PUT
	- DELETE
- Each resource in REST is identified by a unique URL and the response is a JSON or XML format

- **Essential** **Feature**: follows stateless client-server model
	- The server does not store any information about the clients state between requests.

- **When to use:**
	- Building web services that require stateless, scalable, and easy to maintain architecture 
	- Building CRUD apps (Create, Read, Update, Delete) 
	- Chat applications, Streaming Services

###### **SOAP API**
- Simple Object Access Protocol 
- Used for exchanging structured data between different applications regardless of the programming language used
- Web based Programming Application Interface that follows the SOAP protocol 
- Uses XML as the format for sending and receiving data and provides a wide range of data types 
- Supports multiple transfer protocols (Hypertext Transfer Protocol, Simple Mail Transfer Protocol, File Transfer Protocol)

- **Advanced Security**
	- Digital Signatures
	- Encryption

- **When to use**
	- Building apps that require highly secure and reliable method of exchanging data between applications 
	- Ideal for handling complex data structures and business logic 
###### HTTP (Hypertext Transfer Protocol)

- **Purpose:** Used for transferring web pages on the internet.
- **How It Works:** Operates over TCP/IP and facilitates communication between web browsers and servers. It defines how messages are formatted and transmitted.
- **Common Usage:** Accessing websites (e.g., when you type a URL in your browser).

###### SMTP (Simple Mail Transfer Protocol)

- **Purpose:** Used for sending emails across networks.
- **How It Works:** Operates on a client-server model, allowing the sending of messages from a client (like an email application) to a mail server and between servers.
- **Common Usage:** Sending emails, typically from an email client to the server.

###### FTP (File Transfer Protocol)

- **Purpose:** Used for transferring files between computers on a network.
- **How It Works:** Operates over TCP/IP, allowing users to upload, download, and manage files on remote servers.
- **Common Usage:** File sharing, website maintenance, and backups.
###### **XML**

XML (eXtensible Markup Language) is a markup language designed for storing and transporting structured data. Here are the key points about XML:

**key Features**

- **Text-Based:** XML files are plain text, making them easy to read and write.
- **Hierarchical Structure:** It organizes data in a tree-like structure with nested elements, allowing for complex representations.
- **Self-Descriptive:** Data is enclosed in tags that describe its content, making it intuitive to understand.
- **Extensible:** Users can create custom tags, allowing XML to adapt to various applications and data structures.
- **Well-Formed and Valid:** A well-formed XML document adheres to syntax rules, while a valid XML document conforms to a defined schema (like DTD or XML Schema).

**Common Uses**

- **Data Exchange:** Frequently used for data interchange between systems, especially in web services and APIs.
- **Configuration Files:** Many applications utilize XML for configuration settings due to its readability.
- **Document Formats:** Formats such as SVG (for graphics) and XHTML (a variant of HTML) are based on XML.
- **Web Services:** Protocols like SOAP use XML for message formatting.

**Example of XML**

Here’s a simple XML document representing a book:
```xml
<book> 
	<title>Learning XML</title> 
	<author>Jane Doe</author> 
	<year>2024</year> 
	<publisher>Tech Books Publishing</publisher> 
</book>
```

###### **Information about Ontario Ministry of Children**
Helping to improve outcomes for children, youth, families and individuals who need support, and advancing the interests of women across Ontario.

**What we do**
**Children and Youth**
- Oversee the delivery of child protection services for children who have been, or are at risk of being, abused or neglected.
- Help make sure children and youth with special needs, including autism, have access to timely and effective services.
- Work with First Nations, Inuit, Métis and urban Indigenous communities to support the healthy development of their children and youth.
- Help prevent high-risk youth from coming into conflict with the law, improve their outcomes, and reduce re-offending.
- Oversee health screening and intervention programs that support early child development.
- Monitor international and private adoption services in Ontario.
- Provide policy oversight and funding for the [Ontario Child Benefit.](https://www.ontario.ca/page/ontario-child-benefit)

**Community and Social Services**
- Provide financial and employment supports to low-income Ontarians.
- Fund services and supports for adults with developmental disabilities.
- Collect, distribute and enforce child and spousal support payments.
- Supply interpreter and intervenor services for adults who are deaf, deafened, hard of hearing or deafblind.
- Collaborate with Indigenous communities on healing, health and wellness programs and services for Indigenous people.
- Support survivors of human trafficking, domestic violence and sexual violence.

**Women’s social and economic opportunity**
- Supports the advancement of women’s equality and safety.
- 
###### **Fetch API**

The Fetch API is a modern JavaScript interface that allows you to make network requests to servers, enabling you to retrieve or send data over the web. It provides a more powerful and flexible feature set compared to the older XMLHttpRequest.

Key Features:

1. **Promise-Based**: The Fetch API returns a Promise, which makes it easier to handle asynchronous operations using `.then()` and `.catch()` for success and error handling.
    
2. **Simple Syntax**: Fetch uses a more straightforward syntax for making requests and handling responses.
    
3. **Support for Various Methods**: You can use it to perform various HTTP methods, such as GET, POST, PUT, DELETE, etc.
    
4. **Response Handling**: The API allows you to easily handle responses, including parsing JSON, text, or other formats.
    
5. **CORS Support**: It supports Cross-Origin Resource Sharing (CORS), allowing you to make requests to different domains with the right permissions.
    

Basic Usage Example:

Here’s a simple example of using the Fetch API to make a GET request:

```js
fetch('https://api.example.com/data') 
	.then(response => { 
		if (!response.ok) { 
			throw new Error('Network response was not ok'); 
		} 
	return response.json(); // or response.text() for plain text 
	}) 
	.then(data => { 
		console.log(data); // Handle the data from the response 
	}) .catch(error => 
		{ console.error('There was a problem with the fetch operation:', error); });
```

Summary:

The Fetch API is widely used in web development for its simplicity and effectiveness in handling network requests, making it a go-to choice for modern JavaScript applications.

###### **Async Await**

`async` and `await` are JavaScript keywords that simplify working with asynchronous code, particularly when using Promises. They help make your code more readable and easier to understand by allowing you to write asynchronous code in a synchronous style.

Key Concepts:
1. **`async` Function**: When you declare a function as `async`, it always returns a Promise. This means you can use `await` within this function.
2. **`await` Expression**: The `await` keyword can only be used inside an `async` function. It pauses the execution of the function until the Promise is resolved or rejected, making it easier to handle the results.

```js
async function getData() { 
	try { 
		const response = await fetch('https://api.example.com/data'); 
		if (!response.ok) { 
			throw new Error('Network response was not ok'); 
		} 
		const data = await response.json(); 
		console.log(data); // Handle the fetched data 
	} catch (error) { 
		console.error('There was a problem with the fetch operation:', error);         } 
} 
getData();
```

###### **SQL**
SQL, or Structured Query Language, is a standard programming language used for managing and manipulating relational databases. It allows users to perform various operations such as:

1. **Querying Data**: Retrieve specific information from one or more tables using the `SELECT` statement.
2. **Inserting Data**: Add new records to a table with the `INSERT` statement.
3. **Updating Data**: Modify existing records using the `UPDATE` statement.
4. **Deleting Data**: Remove records from a table with the `DELETE` statement.
5. **Creating and Modifying Structures**: Define new tables or modify existing ones using `CREATE`, `ALTER`, and `DROP` statements.

SQL is widely used in many database management systems (DBMS) like MySQL, PostgreSQL, Microsoft SQL Server, and Oracle. Its declarative nature allows users to specify what data they want without detailing how to retrieve it, making it powerful for data manipulation and analysis.