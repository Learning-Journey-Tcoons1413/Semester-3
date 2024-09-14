*Date: September 11th 2024

**Difference Between StreamReader and StreamWriter in C**

In C#, `StreamReader` and `StreamWriter` are classes used for reading from and writing to streams, respectively. Here's how they differ:

###### 1. Purpose:
- **`StreamReader`**: Used for reading characters from a stream (e.g., reading text from a file).
- **`StreamWriter`**: Used for writing characters to a stream (e.g., writing text to a file).

###### 2. Common Uses:
- **`StreamReader`**: Often used when you need to read text data line by line or character by character from a file or another text-based stream.
- **`StreamWriter`**: Used when you need to write text data, such as lines or individual characters, to a file or stream.

###### 3. Method Examples:
- **`StreamReader`**:
  - `ReadLine()`: Reads a line of characters from the stream.
  - `ReadToEnd()`: Reads all characters from the current position to the end of the stream.
- **`StreamWriter`**:
  - `WriteLine(string)`: Writes a line of text to the stream.
  - `Write(string)`: Writes text without adding a newline character.

###### 4. Reading vs. Writing:
- **`StreamReader`** focuses on **reading** data, meaning it's designed to pull text from a source like a file.
- **`StreamWriter`** focuses on **writing** data, allowing you to push text to a file or other writable medium.

###### 5. File Access:
- When using **`StreamReader`**, the file you're reading from should already exist.
- When using **`StreamWriter`**, it will create a file if it doesn't exist or overwrite an existing file by default (you can append using the appropriate constructor).

###### Example:

```csharp
//Using `StreamReader` to read a file:
using (StreamReader reader = new StreamReader("example.txt"))
{
    string content = reader.ReadToEnd();
    Console.WriteLine(content);
}

//Using `StreamWriter` to write to a file:
using (StreamWriter writer = new StreamWriter("example.txt"))
{
    writer.WriteLine("Hello, World!");
}
```
