# Day 6 - Strings and Arrays in C#

## Topics Covered

### 1. **String Basics in C#**
   - Strings can be created using `string` or `System.String`
   - String concatenation using the `+` operator
   - Creating strings from character arrays
   - Reading strings from user input using `Console.ReadLine()`

### 2. **String Characteristics**
   - **Immutable:** Once created, content cannot be altered; modifications create new strings
   - **Reference Type:** Strings are reference types but behave like value types in some scenarios
   - **Unicode Support:** Can contain any Unicode character, supporting multiple languages
   - **Null and Embedded Nulls:** Strings can be null and may contain embedded null characters (\0)
   - **Operator Overloading:** Supports `+` for concatenation and `==` for comparison

### 3. **String Properties**
   - **Length** - Returns the number of characters in the string

### 4. **String Search Methods**
   - **IndexOf()** - Finds the index of first occurrence of a character or substring
   - **StartsWith()** - Checks if string starts with a specified substring
   - **EndsWith()** - Checks if string ends with a specified substring
   - **Contains()** - Checks if string contains a specified substring

### 5. **String Case Conversion**
   - **ToUpper()** - Converts all characters to uppercase
   - **ToLower()** - Converts all characters to lowercase

### 6. **String Modification Methods**
   - **Insert()** - Inserts a string at a specified index
   - **Remove()** - Removes characters from a string starting at specified index
   - **Replace()** - Replaces occurrences of a substring with another substring

### 7. **String Split and Join**
   - **Split()** - Splits a string into an array based on a specified delimiter
   - **Join()** - Combines an array of strings into a single string with delimiter
   - Useful for parsing and formatting string data

### 8. **String Padding and Trimming**
   - **PadLeft()** - Pads string with spaces or specified character on the left
   - **PadRight()** - Pads string with spaces or specified character on the right
   - **Trim()** - Removes leading and trailing whitespaces
   - Useful for formatting output and cleaning user input

### 9. **Array Sorting and Properties**
   - **Sort()** - Arranges array elements in ascending order
   - **IsFixedSize** - Checks if array has a fixed size (always true for arrays)
   - **Rank** - Returns the number of dimensions in the array
   - Arrays in C# are zero-indexed

### 10. **Array Search Methods**
   - **BinarySearch()** - Searches for an element in a sorted array (returns index if found)
   - **AsReadOnly()** - Creates a read-only wrapper for the array
   - Binary search requires the array to be sorted first

### 11. **Array Comparison and Creation**
   - **Equals()** - Compares array references (not element values)
   - **Empty()** - Creates an empty array with zero length
   - Reference equality vs value equality

### 12. **Array Find Methods**
   - **Exists()** - Checks if any element matches the specified condition
   - **Find()** - Returns the first element that matches the condition
   - **FindAll()** - Returns all elements that match the condition
   - Uses lambda expressions or predicates for conditions

### 13. **Array Index Methods**
   - **FindIndex()** - Returns the index of first element matching condition
   - **FindLast()** - Returns the last element that matches the condition
   - **FindLastIndex()** - Returns the index of last element matching condition
   - Useful for locating elements based on complex criteria

### 14. **Array Manipulation Methods**
   - **SetValue()** - Sets the value of an element at specified index
   - **Reverse()** - Reverses the order of elements in the array
   - **ToString()** - Returns the type name of the array
   - **Resize()** - Resizes a one-dimensional array to specified size
   - **GetUpperBound()** - Gets the index of the last element of a dimension

### 15. **String and Array Integration**
   - Using `string.Join()` to convert arrays to strings
   - Using `Split()` to convert strings to arrays
   - Combining string and array methods for data processing
   - Lambda expressions with array methods for filtering and searching
