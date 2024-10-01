###### Ridgeline Mountain Outfitters (RMO) Overview
- RMO has complex information systems supporting operations and management.
- Due to customer expectations, modern technological capabilities, and competitive pressures, RMO plans to upgrade its sales and marketing support.
- A new **Consolidated Sales and Marketing System (CSMS)** was proposed.
- This major project emerged from the RMO strategic planning process.
###### Project Initiation
- Project initiation is the first phase of the project management life cycle. **SDLC** Part 1.
- Companies decide whether the project is needed and assess its benefits.
- A **Project Initiation Document (PRD)** is developed, outlining:
  - Justification for the project
  - Objectives
  - Organization and structure of the project
- Ensures everyone understands the project from the beginning.
###### RMO Information Systems Strategic Plan
- **Technology architecture**: The set of computing hardware, network hardware, topology, and system software used by the organization.
- **Application architecture**: The information systems that support the organization, including subsystems and supporting technology.
###### RMO Existing Application Architecture
- **Supply Chain Management (SCM)**:  
  - 5 years old, built with Java/Oracle  
  - The Tradeshow system will interface with SCM
- **Phone/Mail Order System**:  
  - 12 years old, built with Visual Studio/MS SQL  
  - Reached capacity, minimal integration
- **Retail Store System**:  
  - Older package solution, minimal integration
- **Customer Support System (CSS)**:  
  - Web-based system, evolved over time with minimal integration
###### Proposed Application Architecture
- Integrate **SCM** and the new **Consolidated Sales and Marketing System (CSMS)**.
###### New Consolidated Sales and Marketing System (CSMS)
- **Sales Subsystem**:  
  - Integrates online, phone, and retail store sales.
- **Order Fulfillment Subsystem**:  
  - Tracks shipments, rates products and services.
- **Customer Account Subsystem**:  
  - Manages shopping history, "Mountain Bucks" rewards.
- **Marketing Subsystem**:  
  - Handles promotional packages, partner relationships, merchandise information, and reporting.
###### Systems Analysis Activities
- The New **CSMS** will require understanding extensive business processes and rules.
- Systems analysis generally begins by identifying problems, obtaining approval, and planning the project.
- For the RMO **CSMS** project, the focus is on analysis activities.

###### Key Systems Analysis Activities
1. **Gather Detailed Information**:  
   - Interviews, questionnaires, observing business processes, documents, vendor research, comments and suggestions.
2. **Define Requirements**:  
   - Modeling functional and non-functional requirements.
3. **Prioritize Requirements**:  
   - Essential, important, vs. nice-to-have features.
4. **Develop User-Interface Dialogs**:  
   - Flow of interaction between user and system.
5. **Evaluate Requirements with Users**:  
   - User involvement and feedback, with adaptations to changes.

###### Summary of Requirements in Systems Analysis and Design

###### Definition of Requirements
- Requirements are documented needs or conditions that a system aims to fulfill. They address physical or functional needs and are essential for solving problems or achieving objectives.

###### Types of Requirements
- **System Requirements**:
  - **Functional Requirements**: Describe the activities the system must perform, including business uses and user functions. Examples include use cases such as making a reservation or processing a claim.
  - **Non-Functional Requirements**: Specify system characteristics and constraints such as performance goals, usability, security, and other quality attributes.

###### Levels of Requirements
- **Business Requirements**: High-level objectives from the organization or customer, recorded in Business Requirements Documents (BRD) or project charters. These describe why the system is needed and the goals it should achieve.
	- Ex) Business needs a new sales system
- **System Requirements**: Detailed descriptions of what the system will do to solve the business need, including user, functional, and non-functional requirements. Documented in a System Requirements Specification (SRS).

	###### 1. User Requirements
	- Define user goals or tasks that the system must support. Represented through use cases, scenarios, or event-response tables.
	
	###### 2. Functional Requirements
	- Specify what the system should do, documented as "shall" statements. They describe the system’s functionality and behavior.
	
	###### 3. Non-Functional Requirements
	- Include performance goals, usability, security, and other attributes like efficiency, scalability, and constraints. Use **FURPS**+ (Functional, Usability, Reliability, Performance, Security) as a framework to categorize these requirements.
	- The + sign includes design constraints as well as implementation, system interface, physical, and supportability requirements
	- If it ends in ITY it is non-functional

###### Challenges in Requirements Gathering
- Poorly defined requirements, lack of stakeholder involvement, unrecorded requirements, changing needs, and scope creep can lead to issues in meeting customer expectations.

###### Requirements Gathering Process
- Involves identifying key stakeholders, documenting project goals, and formalizing requirements in a business requirement document. Business analysts, systems analysts, and subject experts are typically responsible for this process.

###### Distinction Between Functional and Non-Functional Requirements
- **Functional Requirements**: What the system does (e.g., system shall generate a receipt).
- **Non-Functional Requirements**: How the system performs its functions (e.g., performance, usability).

###### Additional Requirements Categories
- **Design Constraints**: Hardware and software restrictions.
- **Implementation Requirements**: Specific tools, languages, or protocols.
- **Interface Requirements**: Links to other systems.
- **Physical Requirements**: Equipment and facility constraints.
- **Supportability Requirements**: Methods for updates and enhancements.

---
###### Stakeholders

###### Understanding Stakeholders
Before determining how a business or system works, it's crucial to understand the stakeholder community. Stakeholders are individuals materially affected by the outcome of the system or project. This includes both those directly and indirectly involved.

###### Types of Stakeholders
- **Internal Stakeholders**: Persons within the organization.
- **External Stakeholders**: Persons outside the organization.
- **Operational Stakeholders**: Individuals who regularly interact with the system.
- **Executive Stakeholders**: Individuals who don’t interact directly but use the information or have financial interests.
- **Customers**: People who directly or indirectly do business with the project sponsors.

###### Examples of Stakeholders
- **Project Stakeholders**:
  - Customers who fund or acquire the product.
  - Users who interact with the product.
  - Requirements Analysts who document and communicate requirements.
  - Designers and Developers who design and implement the system.
  - Testers who verify the product meets quality standards.
  - Documentation Writers who produce manuals and training materials.
  - Project Managers who oversee the project.
  - Legal Staff who ensure compliance with laws and regulations.
  - Manufacturing People who build products containing software.
  - Sales, Marketing, Field Support, and Help Desk staff.
  - Department Managers, Board Members, or Directors who make decisions or influence the project.

---

###### Stakeholder Representation
Due to the potentially large number of stakeholders, it's often impractical to involve everyone directly. Instead, a set of stakeholder representatives can be recruited to ensure various stakeholder roles are included. This approach has implications if representatives do not fully understand the needs of those they represent.

---

###### Stakeholders for RMO CSMS Project
- Phone/mail sales order clerks
- Warehouse and shipping personnel
- Marketing personnel who maintain online catalog information
- Marketing, sales, accounting, and financial managers
- Senior executives
- Customers
- External shippers (e.g., UPS and FedEx)

---

###### Information Gathering Techniques
- Interviewing users and other stakeholders
- Distributing and collecting questionnaires
- Reviewing inputs, outputs, and documentation
- Observing and documenting business procedures
- Researching vendor solutions
- Collecting active user comments and suggestions

---

###### Interviewing Users and Other Stakeholders
- **Prepare**:
  - Establish the interview objective.
  - Determine the correct user(s) and project team members.
  - Build a list of questions and issues.
  - Review related documents and materials.
  - Set the time and location, and inform participants.

- **During**:
  - Arrive on time.
  - Look for exceptions and errors.
  - Probe for details.
  - Take thorough notes.
  - Document unanswered items or open questions.

- **After**:
  - Review notes for accuracy and completeness.
  - Transfer information to models and documents.
  - Identify areas needing clarification.
  - Thank participants and follow up on open questions.

---

###### Interview Session Agenda
- **Setting**:
  - Objective: Determine processing rules for sales commission rates.
  - Date, Time, Location: April 21, 2016, at 9:00 a.m. in William McDougal’s office.
  - User Participants: William McDougal (Vice President of Marketing and Sales) and staff.
  - Project Team Participants: Mary Ellen Green and Jim Williams.

- **Interview/Discussion**:
  1. Who is eligible for sales commissions?
  2. What is the basis for commissions? What rates are paid?
  3. How is commission for returns handled?
  4. Are there special incentives, contests, or programs based on time?
  5. Is there a variable scale for commissions? Are there quotas?
  6. What are the exceptions?

- **Follow-Up**:
  - Important decisions or answers to questions.
  - Open items not resolved with assignments for solution.
  - Date and time of next meeting or follow-up session: April 28, 2016, at 9:00 a.m.

---

###### Additional Techniques
- **Observe and Document Business Processes**:
  - Watch and learn.
  - Document with activity diagrams.

- **Research Vendor Solutions**:
  - Review white papers, vendor literature, and competitors' solutions.

- **Collect Active User Comments and Suggestions**:
  - Feedback on models and tests. Users recognize issues when they see them.

---

###### Models and Modeling
- **Definition**: A model is a representation of some aspect of the system being built.
- **Types of Models**:
  - Textual Model: Written descriptions.
  - Graphical Models: Diagrams and schematics **UML**.
  - Mathematical Models: Formulas, statistics, and algorithms.

- **Unified Modeling Language (UML)**:
  - Standard graphical modeling symbols and terminology used for information systems.

---

###### Reasons for Modeling
- Learning from the modeling process.
- Reducing complexity by abstraction.
- Remembering all details.
- Communicating with development team members and various stakeholders.
- Documenting for future maintenance and enhancement.

---

###### Some Analysis and Design Models
- **Use Case Models, Workflows & Activity Diagrams**:
  - Use Case: Identifies and organizes system requirements.
  - Workflow: Sequence of processing steps for business transactions or customer requests.
  - Activity Diagram: Describes user or system activities and their sequential flow. (Insert Diagram Here)

---

###### Activity Diagrams Symbols
![[Pasted image 20240909183208.png]]

###### Activity Diagram for RMO Order Fulfillment
![[Pasted image 20240909183057.png]]

###### Activity Diagram with Concurrent Paths
![[Pasted image 20240909183114.png]]




