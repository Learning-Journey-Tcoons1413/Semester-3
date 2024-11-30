## Learning Objectives
The assignment will cover website testing (grey box testing) and using the Katalon Recorder to create automated test suites. 

Complete the following assignment and submit it electronically to the assignment folder in MyCanvas. Refer to the course Calendar for the exact submission date and time. This assignment must be completed individually.

---

## Background
You have been tasked with building a set of Katalon automated test suites to test the given website. The full set of requirements for the website functionality is outlined in Appendix A.

The website you will be testing is located at: [https://csunix.mohawkcollege.ca/tooltime/comp10066/A4](https://csunix.mohawkcollege.ca/tooltime/comp10066/A4)

**Default Administrator User:**  
- Username: `admin`  
- Password: `adminP6ss`

> **Note:** The above user is an exception to the requirements in Appendix A. You cannot edit or remove the `admin` user; this is outside the scope of testing. Be respectful as all students are testing the same website.

A reminder of how to install Katalon is provided in Appendix B.

---

## Task 1: Katalon Test Suites
Create the following three test suites:

### 1. `USER_CREATION`
- Test the **User Admin** page (accessible by logging in).
- Ensure the test cases cover all requirements for the **User Admin Page** as listed in Appendix A.
- Use the provided `admin` user for this test suite.
- Each user you create should include the last three digits of your student number in the username. The rest of the username is up to you to decide.

### 2. `USER_FUNCTIONALITY`
- Test the three types of users you can create: **admin**, **non-admin**, and **non-active** users.
- The test cases should cover all the requirements for each user role (what they can and cannot do).
- This test suite **does not** need to test the **User Admin** page, as that was covered in the first test suite.

### 3. `CLEANUP`
- Return the website to its original state using the `admin` account. 
- Delete any accounts created in the first test suite.

> **Note:** Each test suite should contain one or more test cases. Remember, each test case should only test one thing (e.g., do not combine multiple tests like creating and deleting a user in the same test case).

---

## Task 2: Bug Report
For each bug found, you must raise a bug report containing the following information:

- **Bug Identifier / Number**
- **Test Case Identifier / Number** where the bug was found
- **Bug Description:**
  - Steps to reproduce the bug, including the exact data inputted into the program
  - The **actual result** obtained
  - The **expected result** – what you expected to happen
  - Your opinion on what went wrong (if you can deduce the cause)
  - A **screenshot** of the issue

> Your bug reports will be compiled into a Word document.

---

## Task 3: Procedure for Running the Test Suites
Write a detailed procedure on how to run your submitted test suites. Assume you are handing off the task to a junior tester. The procedure should cover all steps required to open and run the scripts.

> Include this procedure in the same Word document as your Bug Report.

---

## Submission / Evaluation
Your submission must include the following:

### For Task 1:
- Three **krecorder** files, named as indicated above in Task 1.  
  > **Note:** Zip or HTML files will **not** be accepted.

### For Task 2 and Task 3:
- A single **Microsoft Word** (*.docx) or **Adobe Acrobat** (*.pdf) file containing:
  - Bug reports
  - Procedure for running the test suites

---

### Evaluation Criteria:
- **Test Case Formatting** – 15%
- **Test Suites Automation Performance** – 15%
- **Test Case Coverage** – 50%
- **Bug Summary** – 10%
- **Procedure** – 10%

---

## Appendix A: Website Requirements

1. **Homepage:**  
   The website contains a public homepage accessible to all users, whether logged in or out.

2. **Login Page:**  
   The login page is accessible to all users **only** when they are logged out.

3. **Pages Available After Login:**  
   Once logged in, users will have access to the following pages based on their role:
   - Welcome page
   - Directory page
   - User Admin page
   - View Logs page

4. **Logout:**  
   After logging in, a **logout** link will be displayed. Clicking it will log the user out.

5. **User Roles:**  
   The website supports three user roles:
   - **Admin:** Access to the welcome page, directory page, user admin page, and view logs page.
   - **Non-Admin:** Access to the welcome page and directory page only.
   - **Non-Active:** Cannot log in and cannot access any non-public pages.

6. **Welcome Page:**  
   Displays a welcome message to the logged-in user.

7. **Directory Page:**  
   Allows users to search for local companies by inputting a city. Also has a way to clear search results.

8. **View Logs Page:**  
   Displays logs of login and logout activities for each day. Logs include:
   - Timestamp
   - Client IP address
   - Username
   - Action taken (login or logout)

   > Only one day's logs can be viewed at a time, grouped by day, month, and year.

9. **User Admin Page:**  
   Allows the creation, editing, and deletion of users:
   - Each new user gets an auto-generated user ID.
   - A new user requires the following information:
     - **Username:** 5 to 15 characters in length
     - **Password:** At least 8 characters, containing an upper-case letter, a lower-case letter, and a digit.
     - **Active status:** Whether the user is active or not.
     - **Administrator status:** Whether the user is an admin.
   - The User Admin page will also allow the clearing of the form and deletion of users.
