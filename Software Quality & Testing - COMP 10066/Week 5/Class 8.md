*Date: September 30th 2024*

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107218/files/20633656?module_item_id=5794387)

Test Driven Development,
Introduce Mutations,
Introduce Mutations for Unit Testing,
Mutations Example Handout

###### **Test Driven Development**

- TDD is a model where the tests for a function / system are written first and then the code is written to match what is expected for a test
- After success of test and code for one requirement, we move on and repeat the process for another requirement

- **TDD Cycle**
	1. Add test
	2. Run all tests and see if the new one fails
		1. It should fail 
	3. Write some code to add required functionality 
	4. Run all tests
		- New test case should now pass, new functionality added 
	5. Refactor code
	6. Repeat 

- **Advantage**
	- minimizes redundant code 
		- Refactor code after new tests are added 
	- Better test coverage 
	- Regression tests always available 

- **TDD Example**
	- **Requirement #1**
		- We have been asked to write a function that calculates the average of an array of integers.
	1. Write the Test Case:
	```java
	@Test  
	public void testCase1() {  
		int[] values = {2,3,4,9};  
		double expResult = 4.5;  
		double result = TDD_Example.calculateAverage(values);  
		assertEquals(expResult, result, 0.00001);  
	}
	// This test will fail. It won't even compile. 
	// Now, write just enough code to pass this test case
	```
	2. Write the first version of `calculateAverage()`
	```java
	public static double calculateAverage(int values[]) {  
	double sum = 0;  
	for (int i = 0; i < values.length; i++)  
	sum += values[i];  
	return sum / values.length;  
	}
	// Previous test case should now pass
	```
	- **Requirement #2**
		- The average must only accept positive integers.
	```java
	@Test  
	public void testCase2() {  
		int[] values = {2,-9,10,-10};  
		// Only 2 and 10 should be included  
		double expResult = 6.0;  
		double result = TDD_Example.calculateAverage (values);  
		assertEquals(expResult, result, 0.00001);  
	}
	// This test will fail 
	```
	- Second Version of `calculateAverage()`
	```java
	public static double calculateAverage(int values[]) {  
		double sum = 0;  
		for (int i = 0; i < values.length; i++)  
		if (values[i] >= 0)  
		sum += values[i];  
		return sum / values.length;  
	}
	```
	- **Requirement #3**
		- If value appears more than once, only the first value should be included in the average.
	```java
	@Test  
	public void testCase3() {  
		int[] values = {10, 2,-9,10,-10, 10};  
		// Only 2 and 10 should be included  
		double expResult = 6.0;  
		double result = TDD_Example.calculateAverage (values);  
		assertEquals(expResult, result, 0.00001);  
	}
	```
	- Third Version of `calculateAverage()`
	```java
	public static double calculateAverage(int values[]) {  
		double sum = 0;  
		ArrayList<Integer> uniqueValues = new ArrayList<>();  
		// Put all unique values into an ArrayList  
		
		for (int i=0; i<values.length; i++)  
		if (! uniqueValues.contains(values[i]) && values[i] > 0) 
			uniqueValues.add(values[i]);  
			
		for (int i=0; i<uniqueValues.size(); i++)  
			sum += uniqueValues.get(i);  
		return sum / uniqueValues.size();  
	}
	```

- **Refactor**
	- Change method names?

- **TDD Best Practices**
	- Keep each test assertion focused on only the results necessary to validate its test / requirement.  
	- Treat your test code with the same respect as your production code. It also must work correctly for both positive (test to pass) and negative (test to fail) cases, last a long time, and be readable and maintainable. 
	- Get together with your team and review your tests and test practices to share effective techniques and catch bad habits. It may be helpful to review this section during your discussion.

- **Short Comings of TDD**
	- Ideal for small component testing. 
	- Management support is required

###### **Mutations**

- A small change that may render the code incorrect, but still executable
- The change must still compile to be considered a mutation 
- The change may or may not cause a bug

- **Mutations for Unit Testing**
	- By introducing good / favourable mutations, it is like introducing bugs into the method or algorithm  
	- Having a test case that can detect (kill) the mutation means the test suite is adequate (covers the path through the code)  
	- Mutations that are not detected means test suite needs improvement 
	- Possible test case to be added to cover the path through the code
	- Evaluates the quality of the software
	- Does not test the actual code

- **Mutation Testing Steps**
	1. Introduce mutation
	2. Run Test Stuie
		1. if test suite fails, mutation killed
		2. if test suite pass - mutation not killed 
	3. Repeat

- **Disadvantage to Mutation Testing**
	- Time Consuming and Expensive 
	- Requires White Box Testing 
	- Produce large number of mutants potentially 

- **Advantages of Mutation Testing**
	- Ensures weak points in test cases identified 
	- High level of error detection 
	- Reveals hidden faults
	- Can be automated 

###### **Handout**

