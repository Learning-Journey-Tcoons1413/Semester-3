*Date: October 7th 2024*
###### What is a Software Specification?
- A Software Specification is a description of the correct operation of an application.
- Can be provided as a list of requirements.
- The specification is used to inform the design of the product.
  - How can requirements be written to make them testable?
  - [Writing Testable Requirements](http://www.cqaa.org/Resources/Documents/Presentations%202010/Writing%20Testable%20Requirements.pdf)

###### Static Testing
- Also known as Specification Testing.
- First chance for review.
  - TEST before CODING – Finding bugs at this stage is the most cost-effective.
  - Used to reveal gaps in understanding.
  - Good time to verify that both the client and the developer understand the scope and requirements of the application.

###### Static Black-Box Testing
- No code exists at this point in the development.
- It is good practice to have clients provide the review.

###### Specification and Documentation Testing
- Three ways to evaluate the specification for a high-level review:
  - Put yourself in the place of the customer.
  - Research existing standards & guidelines regarding the platform being used.
  - Review and test similar software.
    - Not always possible, but often applications in similar domains can clarify functionality.

###### What to Ask During Specification Review?
- Is it Complete and Accurate?
- Is it Consistent?
  - Are the terms and nomenclature the same throughout the document?
- Is the information relevant?
  - Is the information presented important to the development of THIS application?
  - Extra information can be a distraction. Keep the specification focused.
- Is it Feasible?
  - Can it be built with current hardware/software?
- Is the specification code/technology free?
  - Should not specify technology in the list of requirements.
- Can the Specification be tested?
  - Is it complete and specific enough to generate use cases? The use cases can generate specific test cases.

###### How Does This Help?
- Detect more bugs.
  - You will find more bugs than you expect in the software and the documentation.
- Find more meaningful bugs/defects.
  - When a bug is found by following instructions, it is more credible.
  - Either the documentation is incorrect, or the software is at fault.

###### Types of Documentation
- Documentation often supplied with Software:
  - Manual
  - Commenting – JavaDoc or XML
  - Completed Examples / Tutorials
  - Video Tutorials

###### How to Test These Types of Documentation?
- Printed / Electronic Manuals:
  - Read manual for correctness.
  - Expert user review – Domain Knowledge.
  - Novice user review – Determines ease of use.
- Completed Examples / Tutorials / Video:
  - Test Examples / Tutorials / Video.
  - Best done by a novice; experts tend to gloss over "obvious" items.

###### What Are the Challenges?
- Printed / Electronic Manuals:
  - Users don't read them.
  - Printed manuals can be expensive.
  - Can quickly become out of date.
- Completed Examples / Tutorials / Video:
  - Based on previous versions.
  - Need version control to keep in check.
  - Video suffers from the same problems as printed manuals.
  - More difficult to update when significant UI changes occur.

###### Static Testing Example
- Review the small specification written on the next slide.
- Make a list of errors in the specification.
- Make a list of recommendations to improve the specification in terms of readability and testability.

###### Static Testing Example
You are to develop an easy-to-use mobile app that will track a user's stock portfolio (set of owned stocks) on North American Stock Exchanges. The app must support the ability to record buy/sell transactions (including the date and # of stock purchased/sold). The app must also keep track of any payments made to you as dividends while you own the stock. The app must be able to calculate the average return over the entire portfolio of stocks as well. To calculate the return on a stock in a portfolio use the following formula:

###### Test Plans
- The goal of planning provides a way to identify:
  - Requirements
  - Resources
  - Scheduling
  - Involves the team (developers/marketing/management)
  - All parties need to be involved to ensure a quality product.
  - Key to success is communicating the test plan.

###### Test Plan Document
- Actual look and feel of the document is company specific.
- Needs to define:
  - Test Objectives
  - Approach taken
  - Tools and Environment Required
  - Schedules for testing.

###### Test Plans - Brainstorming
- Purpose / Objectives of the testing:
  - What is in the testing scope?
  - What will be tested, what will be omitted?
  - Degree or level?
- What type of testing?
  - Unit testing
  - Integration Testing
  - Systems Testing
  - End User Testing / Acceptance Testing.

###### Test Plans - Brainstorming (Environment)
- Will systems be available to integrate to or will test systems be required?
- Will the hardware match what is in the field?
- Some real-time environments are hard to reproduce in testing.

###### Test Plans - Brainstorming (Who will Test it?)
- Programmers?
- Testing Team?
- Customers?

###### Test Plans - Brainstorming (Quality Goals)
- What are the quality goals of the product?
  - Must have features completed vs. Nice to have features.
  - Max # of bugs found in the last iteration.
  - Could also be elimination of all severe bugs.

###### When to start testing?
- Entry Conditions:
  - Under what conditions can testing start?
  - Will we do it throughout the cycle?
  - Do we wait for development to complete?
  - Is documentation complete?

###### When to stop testing?
- Exit Conditions:
  - When are we done?
  - Quality achievement level has been obtained.
  - Bug detect frequency (i.e., # bugs/week).
  - Scheduling requirement – Deadline cannot be missed.

###### Hard Date Scheduling
- Fix start and stop dates.
- Advantages:
  - Eases scheduling / resource allocation.
  - Only real solution for outsourcing situations.
- Disadvantages:
  - Difficult to control entry and exit conditions from a quality perspective.
  - Delays can compromise the testing process.

###### Relative Date Scheduling
- Advantages:
  - Start date not set until “Entry Condition” for the test cycle is met.
  - Original estimates for testing time should be closer to reality.
- Disadvantages:
  - Shifted time may not optimize resources.
  - Testing team may be allocated to other projects in the future and may still end up in a time crunch.

###### Test Plans – Resource Planning
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

###### Test Plans – Classifying the “Bugs”
- When is it a bug?
  - Bug classifications are used to confirm where and why a certain behavior is a bug.
  - Project documents confirm the expected behavior/result of an application feature.
  - In most cases, the Project Specification will be used as the guiding document.

###### Bug Classifications
1. Software does not do something in the specification.
2. Software does something that the specification says it should not do.
3. Software does something that the specification does not mention.
4. Software does not do something it should, that is not mentioned in the specification (e.g., missing a feature that is present in similar software).

###### Test Plans – Classifying the “Bugs” (Additional Notes)
- Some bugs do not fit into the standard categories:
  - Any unspecified / incorrect behavior should be reported.
  - Simple – Inconsistent formatting / spelling.
  - Major – Crash (Exceptions, Blue screen of death, Data loss).
- These are aspects we expect to work correctly in any application.
- Generally, the programmer has failed to consider all cases when these bugs occur.
