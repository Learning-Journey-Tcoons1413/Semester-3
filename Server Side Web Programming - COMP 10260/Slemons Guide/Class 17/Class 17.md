SQL Injection

###### **Info On execute() and prepare()**
- The `execute()` method is called with an **associative array**, where the keys are the named parameters (`:author`, `:is_published`), and the values are the user inputs (`$author`, `$is_published`).
- This step **binds** the user inputs to the prepared statement, ensuring they are correctly escaped and not interpreted as part of the SQL query itself.

Basically using prepared statements and positional and named parameters will prevent SQL injections.
###### ==Working example found in Sam Scott videos Class 17==

[Watch](https://www.youtube.com/embed/ciNHn38EyRc) SQL Injection Video 


