# Day 7 - File I/O Operations in C#

## Topics Covered

### 1. **System.IO Namespace**
   - The `System.IO` namespace provides classes for reading and writing to files
   - Essential for file input/output operations in C#
   - Contains classes like `StreamReader`, `StreamWriter`, `File`, and more

### 2. **StreamWriter Class**
   - Used to write characters to a file in a particular encoding
   - **Constructor:** `StreamWriter("filename")` - Opens/creates a file for writing (overwrites existing content)
   - **Append Mode:** `StreamWriter("filename", append: true)` - Opens file in append mode to add content without overwriting
   - **WriteLine()** - Writes a line of text to the file followed by a line terminator
   - **Close()** - Closes the stream and releases resources
   - Always close the stream when done to prevent resource leaks

### 3. **StreamReader Class**
   - Used to read characters from a file in a particular encoding
   - **Constructor:** `StreamReader("filename")` - Opens a file for reading
   - **ReadLine()** - Reads a line of text from the file and returns it as a string
   - Returns `null` when end of file is reached
   - **Close()** - Closes the stream and releases resources
   - Efficient for reading files line by line

### 4. **File Reading Pattern**
   - Use a `while` loop with `ReadLine()` to read all lines
   - Check if line is `null` to detect end of file
   - Process each line within the loop
   - Example pattern:
     ```csharp
     while (line != null) {
         Console.WriteLine(line);
         line = sr.ReadLine();
     }
     ```

### 5. **File Writing Patterns**
   - **Overwrite Mode:** Default behavior, replaces existing file content
   - **Append Mode:** Adds new content to the end of existing file
   - Use loops to write multiple lines efficiently
   - Example: Writing numbers 0-9 to a file

### 6. **Exception Handling for File I/O**
   - Always use `try-catch` blocks when working with files
   - Common exceptions: `FileNotFoundException`, `IOException`, `UnauthorizedAccessException`
   - **try block:** Contains file operation code
   - **catch block:** Handles exceptions and displays error messages
   - Prevents application crashes due to file access issues

### 7. **File I/O Best Practices**
   - Always close streams after use to free resources
   - Use exception handling to manage errors gracefully
   - Specify file paths carefully (relative vs absolute paths)
   - Consider using `using` statements for automatic resource disposal
   - Validate file existence before attempting to read

### 8. **Alternative File I/O Methods**
   - **File.ReadAllText()** - Reads entire file content as a single string
   - **File.ReadAllLines()** - Reads all lines into a string array
   - **File.AppendAllText()** - Quick one-liner to append text to a file
   - **File.AppendAllLines()** - Appends multiple lines to a file
   - These static methods are simpler for basic operations

### 9. **Reading and Writing Workflow**
   - Create/open file with `StreamWriter` or `StreamReader`
   - Perform read/write operations
   - Close the stream to save changes and free resources
   - Handle exceptions at each step
   - Workflow can be combined (write first, then read to verify)
