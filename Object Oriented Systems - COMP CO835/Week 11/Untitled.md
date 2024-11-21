### 1. **Class: Book**

| **Class Name**       | **Book**                                                                                                                                                                                                                                                                                                 |
| -------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Responsibilities** | - Maintain book information (e.g., title, author, genre, ISBN, etc.).  <br>- Check book availability (determine if the book is available for checkout).  <br>- Update book status (mark as checked out or available).                                                                                    |
| **Collaborators**    | - **LibraryCatalog** (to maintain a list of books and search for books).  <br>- **Transaction** (for checkout and return operations).                                                                                                                                                                    |
| **Rationale**        | The **Book** class is responsible for keeping track of key information about each book, checking its availability for checkout, and updating its status when checked out or returned. It collaborates with **LibraryCatalog** for inventory management and **Transaction** for checkout/return handling. |

---

### 2. **Class: Member**

| **Class Name**       | **Member**                                                                                                                                                                                                                                             |
| -------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **Responsibilities** | - Store member details (e.g., name, address, contact information).  <br>- Track borrowing history (books borrowed, due dates, and overdue status).  <br>- Manage membership status (active or suspended based on overdue books or fines).              |
| **Collaborators**    | - **Transaction** (to track borrowing history and manage checkout/return records).  <br>- **LibraryStaff** (to manage member status or fines).                                                                                                         |
| **Rationale**        | The **Member** class tracks personal information, borrowing history, and membership status. It interacts with **Transaction** to manage the member’s borrowing and return activity and with **LibraryStaff** for updates to their membership or fines. |

---

### 3. **Class: LibraryCatalog**

| **Class Name**       | **LibraryCatalog**                                                                                                                                                                                                                          |
| -------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Responsibilities** | - Store and manage the entire list of available books in the library.  <br>- Search for books (by title, author, genre, etc.).  <br>- Update book inventory (add new books or remove checked-out ones).                                     |
| **Collaborators**    | - **Book** (to access individual book details).  <br>- **Transaction** (to check book availability during checkout).                                                                                                                        |
| **Rationale**        | The **LibraryCatalog** acts as the repository for all books, enabling the addition, removal, and searching of books. It collaborates with **Transaction** to confirm book availability and ensures that the catalog is updated accordingly. |

---

### 4. **Class: Transaction**

|**Class Name**|**Transaction**|
|---|---|
|**Responsibilities**|- Handle book checkout and return processes (update book status and member history).  <br>- Track due dates and overdue status for books.  <br>- Manage fines (if applicable for late returns).|
|**Collaborators**|- **Book** (to update the status of books being checked out or returned).  <br>- **Member** (to record transaction history and ensure borrowing limits are not exceeded).|
|**Rationale**|The **Transaction** class manages the lifecycle of a book during checkout and return. It works with **Book** to adjust availability and status, and with **Member** to track borrowing history and enforce policies such as fines for late returns.|

---

### 5. **Class: LibraryStaff**

|**Class Name**|**LibraryStaff**|
|---|---|
|**Responsibilities**|- Manage library operations (e.g., issuing new memberships, suspending accounts for overdue books).  <br>- Assist with member transactions (help with checkouts and returns if needed).  <br>- Enforce library policies (e.g., fines, membership validity).|
|**Collaborators**|- **Member** (to update membership status and manage fines).  <br>- **Transaction** (to assist with managing transactions and handling issues like overdue fines).|
|**Rationale**|The **LibraryStaff** class is responsible for managing member accounts, assisting with transactions, and enforcing library policies. It works with **Member** to handle account status and fines, and with **Transaction** to ensure smooth checkout and return processes.|