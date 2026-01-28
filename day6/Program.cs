// <summary>
// Day 6 - Strings and Arrays in C#
// 
// This program demonstrates string and array operations including:
// - String characteristics and properties
// - String creation and concatenation
// - Common string methods (IndexOf, Contains, Split, Join, etc.)
// - String manipulation (Trim, Replace, Insert, Remove, etc.)
// - Array methods (Sort, Search, Find, Reverse, etc.)
// - Array properties and operations
// </summary>

using System;

class Program
{
    public static void Main(){    
    // ===== EXAMPLE 1: String Basics =====
    // Strings in C# can be created using string or System.String
    // String concatenation using the + operator
    // 
    


    // ===== EXAMPLE 2: String Characteristics =====
    // Key properties of strings in C#:
    // 
    // Immutable: Once created, content cannot be altered
    // Any modification creates a new string
    // 
    // Reference Type: Strings are reference types but behave like value types
    // in some scenarios such as comparison
    // 
    // Unicode Support: Strings can contain any Unicode character
    // Allows support for multiple languages
    // 
    // Null and Embedded Nulls: Strings can be null and may contain
    // embedded null characters (\0)
    // 
    // Operator Overloading: Supports + for concatenation and == for comparison


    // ===== EXAMPLE 3: Reading String from User Input =====
    // Console.ReadLine() reads a line of text from the user
    // 
    // Console.WriteLine("Enter the String");
    // String read_user = Console.ReadLine();
    // Console.WriteLine("User Entered: " + read_user);


    // ===== EXAMPLE 4: Creating String from Character Array =====
    // Strings can be created from char arrays
    // Substring method extracts a portion of the string
    // 
    // char[] chars = { 'k', 'r', 'r', 'i', 's', 'h' };
    // string str = new string(chars);
    // Console.WriteLine(str);
    // string substr = str.Substring(start, end);


    // ===== EXAMPLE 5: String Properties =====
    // Length property returns the number of characters in a string
    // 
    // string res = "    is the Organisation Name";
    // Console.WriteLine(res);
    // Console.WriteLine("Length: " + res.Length);


    // ===== EXAMPLE 6: String Search Methods =====
    // IndexOf: Finds the index of first occurrence of a character or substring
    // StartsWith: Checks if string starts with a specified substring
    // EndsWith: Checks if string ends with a specified substring
    // Contains: Checks if string contains a specified substring
    // 
    // string res = "    is the Organisation Name";
    // 
    // Console.WriteLine(res.IndexOf("the"));
    // Console.WriteLine(res.StartsWith("is"));
    // Console.WriteLine(res.EndsWith("name"));
    // Console.WriteLine(res.Contains("name"));


    // ===== EXAMPLE 7: String Case Conversion =====
    // ToUpper: Converts all characters to uppercase
    // ToLower: Converts all characters to lowercase
    // 
    // string res = "    is the Organisation Name";
    // 
    // Console.WriteLine(res.ToUpper());
    // Console.WriteLine(res.ToLower());


    // ===== EXAMPLE 8: String Modification Methods =====
    // Insert: Inserts a string at a specified index
    // Remove: Removes characters from a string starting at specified index
    // Replace: Replaces occurrences of a substring with another substring
    // 
    // string res = "    is the Organisation Name";
    // 
    // Console.WriteLine(res.Insert(24, " hi"));
    // Console.WriteLine(res.Remove(5, 7));
    // Console.WriteLine(res.Replace("the", "welcome to "));


    // ===== EXAMPLE 9: String Split and Join =====
    // Split: Splits a string into an array based on a delimiter
    // Join: Combines an array of strings into a single string with delimiter
    // 
    // string res = "    is the Organisation Name";
    // 
    // string[] parts = res.Split();
    // foreach (string r in parts)
    // {
    //     Console.Write(r + " + ");
    // }
    // Console.WriteLine();
    // 
    // string s1 = string.Join(" ", parts);
    // Console.WriteLine(s1);


    // ===== EXAMPLE 10: String Padding and Trimming =====
    // PadLeft: Pads string with spaces or specified character on the left
    // PadRight: Pads string with spaces or specified character on the right
    // Trim: Removes leading and trailing whitespaces
    // 
    // string res = "    is the Organisation Name";
    // 
    // string s1 = res.PadLeft(40);
    // Console.WriteLine(s1);
    // 
    // string s2 = res.PadRight(40, '*');
    // Console.WriteLine(s2);
    // 
    // string s3 = res.Trim();
    // Console.WriteLine(s3);


    // ===== EXAMPLE 11: Array Sorting and Properties =====
    // Sort: Arranges array elements in ascending order
    // IsFixedSize: Checks if array has a fixed size (always true)
    // Rank: Returns the number of dimensions in the array
    // 
    // int[] num = { 5, 2, 9, 1, 7 };
    // 
    // Array.Sort(num);
    // Console.WriteLine("Sort(): " + string.Join(", ", num));
    // 
    // Console.WriteLine("IsFixedSize: " + ((System.Collections.IList)num).IsFixedSize);
    // Console.WriteLine("Rank: " + num.Rank);


    // ===== EXAMPLE 12: Array AsReadOnly and BinarySearch =====
    // AsReadOnly: Creates a read-only wrapper for the array
    // BinarySearch: Searches for an element in a sorted array
    // Returns the index if found, negative value if not found
    // 
    // int[] num = { 5, 2, 9, 1, 7 };
    // Array.Sort(num);
    // 
    // var readOnly = Array.AsReadOnly(num);
    // Console.WriteLine("AsReadOnly(): " + string.Join(", ", readOnly));
    // 
    // int index = Array.BinarySearch(num, 2);
    // Console.WriteLine("BinarySearch(2): " + index);


    // ===== EXAMPLE 13: Array Comparison and Empty =====
    // Equals: Compares array references (not element values)
    // Empty: Creates an empty array with zero length
    // 
    // int[] num = { 1, 2, 5, 7, 9 };
    // int[] num2 = { 1, 2, 5, 7, 9 };
    // 
    // Console.WriteLine("Equals(): " + num.Equals(num2));
    // 
    // int[] emptyArr = Array.Empty<int>();
    // Console.WriteLine("Empty(): Length = " + emptyArr.Length);


    // ===== EXAMPLE 14: Array Exists and Find =====
    // Exists: Checks if any element matches the specified condition
    // Find: Returns the first element that matches the condition
    // FindAll: Returns all elements that match the condition
    // 
    // int[] num = { 1, 2, 5, 7, 9 };
    // 
    // bool exists = Array.Exists(num, x => x > 8);
    // Console.WriteLine("Exists(x > 8): " + exists);
    // 
    // int found = Array.Find(num, x => x > 4);
    // Console.WriteLine("Find(x > 4): " + found);
    // 
    // int[] foundAll = Array.FindAll(num, x => x > 4);
    // Console.WriteLine("FindAll(x > 4): " + string.Join(", ", foundAll));


    // ===== EXAMPLE 15: Array FindIndex and FindLast =====
    // FindIndex: Returns the index of first element matching condition
    // FindLast: Returns the last element that matches the condition
    // FindLastIndex: Returns the index of last element matching condition
    // 
    // int[] num = { 1, 2, 5, 7, 9 };
    // 
    // int findIndex = Array.FindIndex(num, x => x == 7);
    // Console.WriteLine("FindIndex(7): " + findIndex);
    // 
    // int last = Array.FindLast(num, x => x > 4);
    // Console.WriteLine("FindLast(x > 4): " + last);
    // 
    // int lastIndex = Array.FindLastIndex(num, x => x > 4);
    // Console.WriteLine("FindLastIndex(x > 4): " + lastIndex);


    // ===== EXAMPLE 16: Array Manipulation Methods =====
    // SetValue: Sets the value of an element at specified index
    // Reverse: Reverses the order of elements in the array
    // ToString: Returns the type name of the array
    // 
    // int[] num = { 1, 2, 5, 7, 9 };
    // 
    // Console.WriteLine("ToString(): " + num.ToString());
    // 
    // num.SetValue(100, 0);
    // Console.WriteLine("SetValue(100, 0): " + string.Join(", ", num));
    // 
    // Array.Reverse(num);
    // Console.WriteLine("Reverse(): " + string.Join(", ", num));


    // ===== EXAMPLE 17: Additional Array Methods =====
    // Resize: Resizes a one-dimensional array to the specified size
    // GetUpperBound: Gets the index of the last element of a dimension
    // 
    // Note: These methods are useful for dynamic array operations
    }
}
