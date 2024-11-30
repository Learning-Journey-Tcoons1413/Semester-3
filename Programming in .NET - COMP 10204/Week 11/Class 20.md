*Date: November 19th 2024*
###### Connecting C# to Databases 
 
Files are from Module 11

###### Steps To Configure To File
1. Create a StreamReader or StreamWriter
2. Read or Write  
3. Close

###### Steps To Configure To Database
1. Create Connection String to the database
```cs
	SqlConnection Connection;
	String connectionString = 
	@"Data Source=.\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;";
```
2. Connect To The Database: DO THIS IN A TRY CATCH
```cs
	Connection = new SqlConnection();
	Connection.ConnectionString =  connectionString;
	Connection.Open();
```
3. Perform Query (Execute SQL Against The Database)
```cs
SqlCommand sqlCommand = new SqlCommand(command,Connection);
SqlDataReader reader = sqlCommand.ExecuteReader();

while (reader.Read())
{
	string result = "";
	for (int i = 0; i < reader.FieldCount; i++)
	{
		var field = reader[i];
		result += $"{field.ToString(),-12}";
	}
	Console.WriteLine(result);
}
// Closing the Query, NOT the connection
reader.Close();
```
4. Close connection
```cs
	Connection.Close();
```

==**TEST QUESTIONS**==
	Write a connection String to the database
		- `@"Data Source=.\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;";`
	Steps to establish a connection 
	Steps of creating an SQL Command
	Reading the results of a query 

###### **Doing the Same thing with a Form Application!**

==**You need to download the code for the form and UNDERSTAND THIS GAY FORM SHIT WITH SQL**== 


**Creating Headers in ListBox**

Set Headers:
- Properties Window: View -> Details 

 
