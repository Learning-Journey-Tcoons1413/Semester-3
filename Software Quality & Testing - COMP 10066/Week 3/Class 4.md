*Date: September 16th 2024*

[MyCanvas Notes](https://mycanvas.mohawkcollege.ca/courses/107218/files/20633646?module_item_id=5794369)

Code Reviews
Debugging
  
###### **Code Reviews**
-  A developer looks at your code and reviews it
- Looking for style, guidelines followed, error checking, the methods you used to solve problems

- **Participants in Code Review**
	- Original Programmer
	- Managers
	- Testers
	- Stakeholders
- **Peer Reviews**
	- Informal and relaxing
	- Purpose is to mentor junior dev's
	- Ensure company policies are met
- **Walkthroughs**
	- More systematic and detailed review 
	- Done by a group of programmers
	- Allows for transfer of knowledge
- **Inspections**
	- Formal review of code
	- Can include mathematical proof of concepts
	- This is done on systems that impact human safety 
	- **Involves a series of events and meetings:**  
		- Planning – each participant is provided with information about what is being reviewed  
		- Overview meeting – original programmer provides overview of code  
		- Preparation – each participant individually inspects the code  
		- Formal Inspection Meeting – formal walkthrough, recording issues found  
		- Rework – original programmer refactors the code based on what was found in the inspection meeting  
		- Follow up – changes made are confirmed by participants
- **What are you looking for**
	- Data reference errors
	- Data declaration types - different for strong and weak types languages
	- Computational Errors - is the calculation correct?
	- Comparison Errors - is the logic correct?
	- Control of Flow - is the loop correct?
	- Parameter Errors - 
	- Input / Output Errors - 
- **Advantages of Code Reviews**
	- Find and identify issues
	- Ensure compliance 
	- Transfer of knowledge between teams
- **Disadvantages of Code Reviews**
	- Time consuming 
	- Costs money
	- Ego gets hurt 
- **Best Practices for Code Reviews**
	- Use constructive feedback
	- Are changes made based on functional or preference 
	- No ego!

###### **Debugging**

- **Rubber Ducking - Talk It Out**
	- Talking about the problems to brainstorm solutions 
	- Reason the problem out loud 
- **Print Statements**
	- Find out the state of the program during execution 
	- Snapshots of a variable
	- Confirm correct block was entered 
- **Using the IDE**
	- IntelliJ using the debug mode
	- Create breakpoints 