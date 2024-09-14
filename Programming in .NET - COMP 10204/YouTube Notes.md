#### The Following Notes Are From: [Here](https://www.youtube.com/watch?v=gfkTfcpWqAY&list=PLTjRvDozrdlz3_FPXwb6lX_HoGXa09Yef)
###### **C# Structure:**
- **Classes:**
	- Consist Of:
		- Data / Attributes /  Instance Variables
		- Methods / Functions
- **Namespace:**
	- Container for related classes. Think of Java Packages

- **Assemblies:**
	- A container for Namespaces and Classes
	- It is a file on a disc
	- Can be executable or a Dynamically Linked Library (DLL)
	
![[Pasted image 20240908135524.png]]

###### **C# Variables and Constants**:
- To declare a variable:
```cs
	int firstNumber = 0; //Camel Case Non-Constants
	const int SecondNumber = 1; //Pascal Case for Constants
```

- You can also let the C# Compiler detect the datatype:
```cs
	var firstNumber = 0; //Compiler will pick this up and work correctly
	const int SecondNumber = 1; //Constants must still have datatype declared
```
###### **C# Primitive Types:**
![[Pasted image 20240908141210.png]]

**NOTE**: Much like Java, it is best to use "double" when dealing with floating point numbers. Or else you do the following:
![[Pasted image 20240908141457.png]]

###### **C# Overflow:**
```cs
byte number = 255; //Max size of bits that byte can be
number += 1; //This will exceed the limitation for the byte data type
```
- To stop Overflowing use this:
```cs
checked
{
	byte number = 255;
	number += 1;
	bool yesOrNo = true; //Booleans are lowercase
}
//This will throw an exception
```

###### **C# Scope:**
![[Pasted image 20240908142515.png]]
- It is self explanatory

###### **C# Color Coding Variable Meanings:**
| **Element**                 | **Example**                                                                                                                                          | **Meaning**                                               |
| --------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------- |
| **Keywords**                | <span style="color:blue">int</span>, <span style="color:blue">class</span>, <span style="color:blue">if</span>, <span style="color:blue">else</span> | Reserved words in C# used for syntax                      |
| **Types**                   | <span style="color:lightblue">int</span>, <span style="color:lightblue">string</span>, <span style="color:lightblue">List</span>                     | Built-in or user-defined data types                       |
| **Strings**                 | <span style="color:brown">"Hello, World!"</span>                                                                                                     | Text literals enclosed in double quotes                   |
| **Comments**                | <span style="color:green">// This is a comment</span>                                                                                                | Explanations or notes in the code                         |
| **Numbers**                 | <span style="color:darkred">42</span>, <span style="color:darkred">3.14</span>, <span style="color:darkred">0xFF</span>                              | Numerical literals (integers, floats, hexadecimal)        |
| **Variables**               | <span style="color:black">age</span>, <span style="color:black">totalScore</span>                                                                    | User-defined variables and objects                        |
| **Methods**                 | <span style="color:yellow">Calculate()</span>, <span style="color:yellow">WriteLine()</span>                                                         | Functions that perform tasks or calculations              |
| **Constants**               | <span style="color:darkred">PI</span>, <span style="color:darkred">MaxValue</span>                                                                   | Immutable variables that do not change                    |
| **Properties**              | <span style="color:black">MyProperty</span>, <span style="color:black">Length</span>                                                                 | Properties of a class to access private fields            |
| **Preprocessor Directives** | <span style="color:gray">#define</span>, <span style="color:gray">#region</span>, <span style="color:gray">#if</span>                                | Directives for conditional compilation and code inclusion |
###### **C# Formatted Strings**
```cs
Console.WriteLine("{0} | {1}",byte.MinValue,byte.MaxValue);
```

###### **C# Implicit Type Conversion**:
![[Pasted image 20240908145905.png]]
- When the compiler can do the conversion without any loss of data, it will do it implicitly.

###### **C# Explicit Type Conversion**:
![[Pasted image 20240908150139.png]]
- We are aware of the potential data loss so we explicitly "cast" the conversion. 

###### **C# Non-Compatible Type Conversion**:
![[Pasted image 20240908150403.png]]
- "**Convert**" class is defined within the System Namespace. 
	```cs
	Convert.To //And then a list of things to convert to
```
- "**Parse**" is a method that is part of primitive data types used to convert Strings.

###### **C# Increments**
```cs
//Postfix
int a = 1;
int b = a++;
//explanation: a is first assigned to b. Then a is incremented
//Output: a  = 2 | b = 1

//Prefix
int a = 1;
int b = ++a;
//explanation: a is first incremented by 1. Then a is assigned to b
//Output: a  = 2 | b = 2
```

---

