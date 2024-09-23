*Date: September 23rd 2024*

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107218/files/20633689?module_item_id=5794377)
###### **White Box Testing**
- Seeing, inspecting, and tracing through code
- Having access to design documents
- No unknowns while testing, nothing is hidden 
- AKA glass box, clear box
- Done as part of the development 

###### **Why do Programmers Write Tests?**
- Confirm understanding of specifications 
- Ensure all different aspects are verified 
- Test individual components

###### **Testing Automation**
- Any mechanism that can be executed automatically with little to no user interaction 
- Report is then summarized and produced 
- Unit Test is example of automated test 

###### **Advantages of Test Automation**
- **Speed**: Executed without user interaction (fast)
- **Efficiency:** Multi-task
- **Accuracy:** Tests are the same each time 
- **Relentless:** Tools do not get tired or bored
- **Regression:** The act of re-running these tests

###### **Realities of Test Automation**
- Software may be changed or improved
- Time spent testing will take time away from development 
- Invasive tests may impact a real-running system 

###### **What is a Unit Test**
- A test case using **single data set** that is used to execute a function or method or confirms the state of a component 
- Not part of the application 
- Not shipped with source code 

###### **Confirming Software Component Operation**
- Software components can have their operation confirmed by using a number of data sets that reflect  the operation of a component over a range of values.  
- In general, most methods/functions require more than a single unit test to confirm operation.  
- The goal of unit testing is to provide tests that provide data coverage and code coverage

###### **Data Coverage**
- Data input consists of a wide range of possibilities that includes allowed input and not allowed input. 

###### **Code Coverage**
- Testing that will ensure that all code paths have been executed at least once during the set of test cases used.  
	- NOTE : Practical Data Coverage MUST yield 100% code coverage  
- Ensures execution of:  
	- Each method / function  
	- Separate test cases for each branch of control  
		- If - else statements  
		- Loops  
- Separate test cases for each result of a Boolean statement  
	- Test cases for true and false results

###### **Example of Code Coverage**

###### **Goals of Unit Testing**
- Confirmation of *expected operation*
	- Tests to pass
	- Normal data sets
	- Use cases to help develop meaningful test data sets
- Confirmation of *expected error conditions*
	- Tests to fail
	- Non-normal data sets

###### **Unit Testing in Object Oriented Languages**
- **Generic Unit Testing**
	- XUnit is family name given to number of testing frameworks
	- Java uses JUnit
	- Visual Studio C# uses MSTest or NUnit 

###### **Assertions**
- A way to confirm that a return value or object variable contains a value that is known to be correct

- **How are Assertions Used?**
	- Assertions are placed into unit tests to confirm (or VERIFY) an expected result.  
	- If the Assertion results in a true response value the test is said to pass  
	- A false return value from an Assertion is considered a fail

###### **Asserts**
Each test MUST include at least on assert call, to verify the  
results of the test case  
• The testing harness in IntelliJ will handle displaying the  
result, based on what is returned from the assert method  
• Results will be displayed as either as passed (green check  
mark), assertion failed (yellow x) or unexpected exception  
(red exclamation mark)

###### **Asserts in Java**  
• As always, the best place to understand a Java Built In  
Class is to use the API (Oracle Docs)  
• https://junit.org/junit5/docs/5.0.1/api/org/junit/jupiter/api/Ass  
ertions.html  
• Overview of useful assertions in JUnit 5  
 assertEquals  
 assertArrayEquals  
 assertFalse  
 assertTrue  
 assertThrows  
 assertTimeout  
 fail  
• We will examine these in the lab in further detail

###### **Accuracy when comparing Numbers**    
- assertEquals will take a third argument beyond the expected and actual results  
- Important for when testing floating point numbers  
- This value determines the precision / accuracy to compare the floating point and is known as the delta  
	- Example  
	- actualResult = 45.111112  
	- expectedResult = 45.111111  
	- delta = 0.00001  
	- Last digit is ignored, values are considered equal

###### **Common Code among Test Cases**     
• Sometimes there will be redundant code among test  
cases  
 Initializing a database connection  
 Initializing an object  
 Environment set up – drivers for web browsers  
during automation testing

JUnit has methods you can implement to run code at  
certain times:  
 BeforeAll – code to be run before all test cases  
execute  
 AfterAll – code to be run after all test cases are  
finished  
 BeforeEach – code to be run before each test case  
 AfterEach – code to be run after each test case

###### **Unit Testing in C#**
• MSTest – Built in testing framework with .NET Core  
• NUnit – Popular framework adopted by the C#  
community and integrates easily into Visual Studio

• [TestMethod]  
 Same as @Test  
• [ExpectedException(typeof(ExceptionType))]  
 Used to manage cases where the pass case  
produces (throws) an exception  
• [Timeout(value in ms)]  
 Used to manage cases where the function needs to  
provide a performance guarantee within the value  
specified in milliseconds (ms).  
 Note 1 ms = 0.001 s

• [Ignore]  
 A valid test that should not be used at the current time  
 Often the test results in a condition the causes severe  
failure  
 Database deletion / corruption  
 The test is ignored until the bug is corrected  
• These tags [ ] all go above the test case in the code  
and are handled by the testing harness

• [ClassInitialize], [ClassCleanup]  
 These annotations are used to denote methods that will  
be called before and after the test class is invoked.  
• [TestInitialize], [TestCleanup]  
 These annotations are used to denote methods that will  
be called before and after each unit test is invoked.