###### Week 1
- **Defining Software Testing:**
	- Investigating software program to provide information 
- **Goal:**
	- Find Bugs
- **V-Model:**
	- ![[Pasted image 20240909102759.png]]
- **Quality Assurance:**
	- Ensures the standards of quality are used for a product 
- **Programmers Involvement:**
	- Code is well documented 
	- Follows best practices 
	- Proof code meets specifications 
- **International Standard Organization (ISO)**
	- ISO 9000 is Quality Assurance 
	- ISO Standard for Software Development"
		1. ISO 9001
		2. ISO 9000-3
	- ISO 9000-3, Primary Areas of Concern  
		 configuration management,  
		 change control,  
		 development planning,  
		 quality planning,  
		 design and implementation,  
		 testing and validation  
		 maintenance.
- **ISO Certification:**
	- Two Main Goals of ISO 9000 Process:
		1. How does organization complete its work 
		2. Tells organization what needs to be done
- **Testing on Software Dev Life Cycle:**
	- ![[Pasted image 20240909104951.png]]
- **Limitations of Software Testing:**
	- Cant find all bugs
	- Cant cover all cases
	- Cant fix all bugs (too risky)
	- Cant afford the time

###### Week 2
- **Quality Standards:**
	- @author
		- Indicates programmer author
	- **Clean / Good Code:**
		- Readable
		- No duplication
		- Minimal Dependencies 
		- Error Handling
		- Thought and Care
		- Methods explain themselves 
	- **High Quality:**
		- Accurate and complete documentation 
		- UI follows standards for the device or OS
		- Behaves as expected and does what the users say it should do
- **Programming Guidelines:**
	- Languages and Companies have documentation standards that should be followed
	- **Usefulness:**
		- Naming conventions, readability, minimal duplication, reusability, commenting 
- ==**Best Practices**==
	- Style - code format
	- Syntax - is correct 
	- Simplicity - keep code as simple as possible
	- Solution - does it solve the problem?
	- Scaling - can components be reused?
- **Types of Comments:**
	- Class, Module, and Method Level
	- Explanation - Inline 
	- Documentation - JavaDoc or XML
- **Refactoring:**
	- Restructure code without breaking it, doesn't change interface, improves readability
- **==Handout==**
	```java
	//Analyze the code listed below: Take 10 minutes and improve the code quality of the method below  
	//1) What does this program do? What will it print?  
	//2) Refactor the md method to make it more readable. Simplify if you can and add appropriate comments. Improve the code, but it must still do what it was originally supposed to.  
	
	public class RefactorExample {  
	
		public static void main(String[] args) {  
			ArrayList<Double> data = new ArrayList<>(  
				Arrays.asList(10.2, -20.9, 30.2, 40.4, 11.1, 223.3, 12.7,  
				34.8, 0.0, -200.2, -400.0));  
			double longestDifference = maxDifference(data);  
			System.out.println(String.format("ld = %.2f\n", ld));  
		}  
		//Find the maximum difference between two consecutive numbers in a list
		public static double calculateMaxDifference(ArrayList<Double> x) {  
			double difference = 0.0;  
			for (int i = 1; i < x.size(); i++) {  
				double currentNum = x.get(i);  
				double previousNum = x.get(i - 1);  
					if (Math.abs(currentNum - previousNum) > difference)  
						difference = Math.abs(v1 - v2);  
			}  
			return difference;  
		}  
	}
	```
- **Version Control:**
	- Document files and keep track of them
	- **Source Code Control is the Management of**:
		- Changes to documentation
		- Computer programs
		- Large websites
	- ![[Pasted image 20241020152434.png]]
- **Git Terminology:**
	- Command line client. Supports access to remote and local repos
	- Local:
		- My machine
	- Remote:
		- Some external repo (GitHub)
	- **GitHub**
		- Web based Git Repo Hosting Service
	- **Repo**
		- Set of files that are grouped together as a project. Stores data.
- **Git Commands:**
	- init - Creates a git rep
	- add - adds in files
	- commit - adding source code changes
	- clone - clones a repo in a new directory 
	- checkout - switch branches, allows selection of an old commit or file revision
	- merge - merges changes back to the main branch
	- push - sends a series of commits to move a local branch to another repo 
	- fetch - downloads a branch, but doesn't integrate. Allows manual inspection before merge.
	- pull - automates version of fetch, downloads branch and attempts to merge

###### Week 3
- **Code Reviews:**
	- Developer looks at code and reviews it
	- Participants:
		- Original Programmer 
		- Managers
		- Testers
		- Stakeholders
	- Peer Reviews:
		- Informal, mentoring
	- Walkthroughs
		- Systematic detailed
		- Group programmers
	- Inspection:
		- Very formal review
		- Mathematical proof
		- Done on systems that impact human safety 
			- Planning - Information on what is being reviewed 
			- Overview - Original programmer provides overview 
			- Preparation - Participants individually inspect 
			- Formal Inspection
			- Reword - Refactoring
			- Follow-up - Changes made are confirmed 
	- Advantages:
		- Find and identify issues
		- Ensure compliance
	- Disadvantages:
		- Time consuming
		- Money
- **Debugging:**
	- Rubber Ducking - Talking it out
	- Print Statements:
		- Find the state of the program during execution
		- Snapshot of a variable
		- Confirm correct block was entered
	- Using IDE
		- Using debug mode 
		- Create breakpoints 
		- Inserting a breakpoint will pause execution of the code on that line when in debug mode
		- ![[Pasted image 20241020154631.png]]
		- Step Over - 
		- Step Into - Enters method if current line is a method call
		- Step Out - Runs until end of current method and returns to where method was called
		- Run to Cursor - Runs to where the cursor is 
- ==**Handout:**==
```java
//Walkthrough the provided code below and note any feedback you have for the programmer. 
/** 
* Count all vowels in a given input string 
* @param input provided input string 
* @return 
* */ 
public static int countAllVowels(String input){ 
	if(input == null || input.isEmpty()){ // String less than 0 makes no sense
		throw new IllegalArgumentException("String is empty"); 
	} 
	int count=0; 
	char[] letters = input.toCharArray(); 
	for(int i = 1; i < input.length(); i++){ // I should start at 0
		char c = input.charAt(i); 
			switch(c) { // Only checking lower-case
				case 'a': 
				case 'e': 
				case 'i': 
				case 'o': 
				case 'u': 
				count++; 
			} 
		} 
	return count; 
}
```

###### Week 4
- **White Box Testing**
	- No unknowns, nothing hidden, clear box, inspecting code and access to design documents 
- **Why Write Tests:**
	- Understand specifications, and test individual components 
- **Testing Automation:**
	- Any mechanism that can be executed automatically with little to no user interaction 
	- Unit Testing
- **Advantages of Test Automation**
	- Speed
	- Efficiency
	- Accuracy
- **Disadvantages of Test Automation**
	- Costs time, more time writing tests than developing
- **Unit Test**
	- Test case using a single data set to execute function / method
	- Not part of application or source code
- **Confirming Software Component Operation**
	- Software components can have their operation confirmed by using a number of data sets that reflect  the operation of a component over a range of values.  
	- In general, most methods/functions require more than a single unit test to confirm operation.  
	- The goal of unit testing is to provide tests that provide data coverage and code coverage
- ###### **Data Coverage**
	- Data input consists of a wide range of possibilities that includes allowed input and not allowed input. 
- **Code Coverage**
	- Each method / function is executed
	- Each if and else statement and loops are entered
	- Each Boolean statement is entered 
- ==**Handout**==
	- Located in `C:\Users\tomco\OneDrive\Desktop\Mohawk\GitHub For School\Software Quality and Testing\Midterm`
- **Goals of Unit Testing**
	- Confirmation of expected operation
	- Normal and Non-normal data sets
- **Helpful Assertions**
	- `assertEquals`
	- **Purpose**: Checks if two values are equal.
	- **Usage**: Typically used to compare expected and actual results.
	- **Floating Point Precision:** The following test results in equals or true. Enables Precision.
		- actualResult = 45.111112  
		- expectedResult = 45.111111  
		- delta = 0.00001  
	
	- `assertArrayEquals`
	- **Purpose**: Compares two arrays for equality.
	- **Usage**: Ensures that two arrays have the same length and corresponding elements are equal.
	
	- ### `assertFalse`
	- **Purpose**: Verifies that a condition is `false`.
	- **Usage**: Used in scenarios where you expect a certain condition to be false.
	
	- ### `assertTrue`
	- **Purpose**: Verifies that a condition is `true`.
	- **Usage**: Used when you expect a certain condition to be true.
	
	- ### `assertThrows`
	- **Purpose**: Asserts that a specific exception is thrown.
	- **Usage**: Used to test whether a certain operation results in an expected exception.
	- `assertThrows(ExpectedException.class, () -> { // code that is expected to throw the exception });`
	
	- ### `assertTimeout`
	- **Purpose**: Checks that a certain code block completes within a specified time.
	- **Usage**: Useful for testing performance and ensuring that operations don’t take too long.
	- `assertTimeout(Duration.ofSeconds(1), () -> { // code that should complete within the timeout });`
	- NOTE: `@Timeout(value = 5000, unit = TimeUnit.MILLISECONDS)` use this above the test
	
	- `assertIterable`
	- **Purpose**: used in scenarios where you want to assert that an iterable contains the same elements as another iterable
	- **Order Matters**: `assertIterableEquals` checks that the elements are in the same order. If the order is different, the assertion will fail.
	- **Null Safety**: Both the expected and actual iterables can be `null`, and you can assert their equality.
	- **Type**: It works with any type that implements the `Iterable` interface, including `List`, `Set`, and other collection types.

###### Week 5
- **Test Driven Development:**
	- Tests written first, then code should match tests
	- **TDD Cycle**
		1. Add test
		2. Run all tests and see if the new one fails
			1. It should fail 
		3. Write some code to add required functionality 
		4. Run all tests
			- New test case should now pass, new functionality added 
		5. Refactor code
		6. Repeat 
	- Minimizes redundant code 
	- **TDD Best Practices**
		- Keep each test assertion focused on only the results necessary to validate its test / requirement.  
		- Treat your test code with the same respect as your production code. It also must work correctly for both positive (test to pass) and negative (test to fail) cases, last a long time, and be readable and maintainable. 
		- Get together with your team and review your tests and test practices to share effective techniques and catch bad habits. It may be helpful to review this section during your discussion.
- **Mutations**
	- Small change that produces unexpected results. Still compiles 
	- **Mutations for Unit Testing**
	### 1. Original Loop
	
	`for (int i = 0; i <= 5; i++)     System.out.print("*");`
	
	- **Behavior**: This loop starts from `0` and continues while `i` is less than or equal to `5`.
	- **Iterations**: It executes **6 times** (for `i = 0, 1, 2, 3, 4, 5`), printing an asterisk each time.
	
	### 2. Mutated Loop
	
	`for (int i = 1; i <= 5; i += 1)     System.out.print("*");`
	
	- **Behavior**: This loop starts from `1` and continues while `i` is less than or equal to `5`.
	- **Iterations**: It executes **5 times** (for `i = 1, 2, 3, 4, 5`), printing an asterisk each time.
	
	- 1. is a good mutation. we get 6 loops
	- 2. is not a good mutation. It doesn't change our output at all 
- **==Handout==**
	- ![[Pasted image 20241020182234.png]]
	- ![[Pasted image 20241020182306.png]]
###### Week 6
- **Software Specification**
	- Description of correct operation of application 
- **Static Testing**
	- Test before coding. Reveal gaps. Understand scope and requirements 
- **Static Black Box Testing**
	- No code exists at this point
- **Specification and Documentation Testing**
	- Put yourself in customers shoes
	- Research existing standards guidelines
	- Review and test similar software
- **What to Ask During Specification Review**
	- Complete?
	- Consistent?
	- Feasible?
	- Can specifications be tested?
	- **How does this help?**
		- Detect more bugs
- **Types of Documentation**
	- Printed Electronic 
		- users don't read these
		- Can be outdated
	- Videos
		- Can be outdated
- **Test Plans**
	- This planning provides a way to identify:
		- requirements 
		- resources
		- scheduling
		- involve the team 
- **Test Plan Document**
	- Actual look and feel of the document 
	- Must Define:
		- Test objectives 
		- approach taken 
		- tools and environment required
		- schedules for testing 
- ###### Test Plans - Brainstorming
	- Purpose / Objectives of the testing:
	  - What is in the testing scope?
	  - What will be tested, what will be omitted?
	  - Degree or level?
	- What type of testing?
	  - Unit testing
	  - Integration Testing
	  - Systems Testing
	  - End User Testing / Acceptance Testing.
  ###### Test Plans - Brainstorming (Who will Test it?)
	- Programmers?
	- Testing Team?
	- Customers?
- ###### Test Plans - Brainstorming (Quality Goals)
	- What are the quality goals of the product?
	  - Must have features completed vs. Nice to have features.
	  - Max # of bugs found in the last iteration.
	  - Could also be elimination of all severe bugs.
- ###### When to start testing?
	- Entry Conditions:
	  - Under what conditions can testing start?
	  - Will we do it throughout the cycle?
	  - Do we wait for development to complete?
	  - Is documentation complete?
- ###### When to stop testing?
	- Exit Conditions:
	  - When are we done?
	  - Quality achievement level has been obtained.
	  - Bug detect frequency (i.e., # bugs/week).
	  - Scheduling requirement – Deadline cannot be missed.
- ###### Hard Date Scheduling
	- Fix start and stop dates.
	- Advantages:
	  - Eases scheduling / resource allocation.
	  - Only real solution for outsourcing situations.
	- Disadvantages:
	  - Difficult to control entry and exit conditions from a quality perspective.
	  - Delays can compromise the testing process.
- ###### Relative Date Scheduling
	- Advantages:
	  - Start date not set until “Entry Condition” for the test cycle is met.
	  - Original estimates for testing time should be closer to reality.
	- Disadvantages:
	  - Shifted time may not optimize resources.
	  - Testing team may be allocated to other projects in the future and may still end up in a time crunch.
- ###### Test Plans – Resource Planning
	- List the resources that should be defined and included in a Test Plan:
	  1. People
	  2. Equipment
	  3. Office Space
	  4. Software / Tools specific for the testing:
	     - Reporting / Tracking software
	  5. Outsourcing companies
	  6. Miscellaneous Supplies:
	     - Domain Reference material
	     - Domain training material
	  - Important for small testing projects.
- ###### Test Plans – Classifying the “Bugs”
	- When is it a bug?
	  - Bug classifications are used to confirm where and why a certain behavior is a bug.
	  - Project documents confirm the expected behavior/result of an application feature.
	  - In most cases, the Project Specification will be used as the guiding document.
- ###### Bug Classifications
	1. Software does not do something in the specification.
	2. Software does something that the specification says it should not do.
	3. Software does something that the specification does not mention.
	4. Software does not do something it should, that is not mentioned in the specification (e.g., missing a feature that is present in similar software).
- ###### Test Plans – Classifying the “Bugs” (Additional Notes)
	- Some bugs do not fit into the standard categories:
	  - Any unspecified / incorrect behavior should be reported.
	  - Simple – Inconsistent formatting / spelling.
	  - Major – Crash (Exceptions, Blue screen of death, Data loss).
	- These are aspects we expect to work correctly in any application.
	- Generally, the programmer has failed to consider all cases when these bugs occur.
- ==**Just Study This:**==
	- ![[Pasted image 20241020203712.png]]