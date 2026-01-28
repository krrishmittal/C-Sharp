// <summary>
// Day 8 - Collections in C#
// Generic
// This program demonstrates collection types including:
// - System.Collections.Generic namespace for collections
// - List<T> for dynamic arrays
// - Dictionary<TKey, TValue> for key-value pairs
// - HashSet<T> for unique elements
// - Queue<T> for FIFO operations
// - Stack<T> for LIFO operations
// - LinkedList<T> for linked list operations
// </summary>

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // ===== EXAMPLE 1: Basic List<T> Operations =====
        // List<T> is a dynamic array that can grow/shrink
        // Add() adds element to the end
        // Remove() removes first occurrence of element
        // Count property returns number of elements
        // 
        // List<string> names = new List<string>();
        // names.Add("Alice");
        // names.Add("Bob");
        // names.Add("Charlie");
        // names.Remove("Bob");
        // Console.WriteLine($"Count: {names.Count}"); // returning the total number of elements in the list
        // foreach(string name in names)
        // {
        //     Console.WriteLine(name);
        // }
        // List<int>val=new List<int>();
        // Console.WriteLine("Enter the number of values: ");
        // int n=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter the values: ");
        // for(int i = 0; i < n; i++)
        // {
        //     int data=Convert.ToInt32(Console.ReadLine());
        //     val.Add(data);
        // }
        // for(int i = 0; i < n; i++)
        // {
        //     Console.WriteLine(val[i]);
        // }
        // Console.WriteLine($"count of 1 {val.Count(x=>x==1)}");// returning the count of specific element in the list

        // ===== EXAMPLE 2: List<T> with Index Access =====
        // Access elements using index like arrays
        // Insert() adds element at specific index
        // RemoveAt() removes element at specific index
        // Contains() checks if element exists
        // 
        // List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        // Console.WriteLine($"First element: {numbers[0]}");
        // Console.WriteLine($"Last element: {numbers[numbers.Count - 1]}");
        // numbers.Insert(2, 25);
        // numbers.RemoveAt(0);
        // Console.WriteLine($"Contains 30: {numbers.Contains(30)}");
        // foreach (int num in numbers)
        // {
        //     Console.WriteLine(num);
        // }


        // ===== EXAMPLE 3: Dictionary<TKey, TValue> Basics =====
        // Dictionary stores key-value pairs
        // Keys must be unique, values can be duplicated
        // Access values using keys like array indexing
        // Add() or indexer to add new key-value pairs
        // 
        // Dictionary<int, string> students = new Dictionary<int, string>();
        // students.Add(101, "John");
        // students.Add(102, "Jane");
        // students[103] = "Mike";
        // Console.WriteLine($"Student 101: {students[101]}");
        // Console.WriteLine($"Total students: {students.Count}");
        // foreach (var kvp in students)
        // {
        //     Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        // }


        // ===== EXAMPLE 4: Dictionary with ContainsKey =====
        // ContainsKey() checks if key exists before accessing
        // TryGetValue() safely retrieves value without exception
        // Remove() removes entry by key
        // Prevents KeyNotFoundException
        // 
        // Dictionary<string, int> ages = new Dictionary<string, int>
        // {
        //     { "Alice", 25 },
        //     { "Bob", 30 },
        //     { "Charlie", 35 }
        // };
        // if (ages.ContainsKey("Alice"))
        // {
        //     Console.WriteLine($"Alice's age: {ages["Alice"]}");
        // }
        // if (ages.TryGetValue("David", out int age))
        // {
        //     Console.WriteLine($"David's age: {age}");
        // }
        // else
        // {
        //     Console.WriteLine("David not found");
        // }


        // ===== EXAMPLE 5: HashSet<T> for Unique Elements =====
        // HashSet stores only unique elements
        // Duplicates are automatically ignored
        // Add() returns false if element already exists
        // Useful for removing duplicates from data
        // 
        // HashSet<int> uniqueNumbers = new HashSet<int>();
        // uniqueNumbers.Add(1);
        // uniqueNumbers.Add(2);
        // uniqueNumbers.Add(2);  // Duplicate, won't be added
        // uniqueNumbers.Add(3);
        // Console.WriteLine($"Count: {uniqueNumbers.Count}");
        // foreach (int num in uniqueNumbers)
        // {
        //     Console.WriteLine(num);
        // }


        // ===== EXAMPLE 6: Queue<T> - First In First Out =====
        // Queue follows FIFO principle
        // Enqueue() adds element to the back
        // Dequeue() removes and returns front element
        // Peek() returns front element without removing
        // 
        // Queue<string> queue = new Queue<string>();
        // queue.Enqueue("First");
        // queue.Enqueue("Second");
        // queue.Enqueue("Third");
        // Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        // Console.WriteLine($"Peek: {queue.Peek()}");
        // Console.WriteLine($"Count: {queue.Count}");


        // ===== EXAMPLE 7: Stack<T> - Last In First Out =====
        // Stack follows LIFO principle
        // Push() adds element to the top
        // Pop() removes and returns top element
        // Peek() returns top element without removing
        // 
        // Stack<string> stack = new Stack<string>();
        // stack.Push("Bottom");
        // stack.Push("Middle");
        // stack.Push("Top");
        // Console.WriteLine($"Popped: {stack.Pop()}");
        // Console.WriteLine($"Peek: {stack.Peek()}");
        // Console.WriteLine($"Count: {stack.Count}");


        // ===== EXAMPLE 8: LinkedList<T> Operations =====
        // LinkedList is a doubly-linked list
        // AddFirst() adds at beginning
        // AddLast() adds at end
        // AddAfter()/AddBefore() adds relative to node
        
        // LinkedList<string> linkedList = new LinkedList<string>();
        // linkedList.AddFirst("First");
        // linkedList.AddLast("Last");
        // linkedList.AddAfter(linkedList.First, "Second");
        // linkedList.AddAfter(linkedList.First.Next.Next, "third");

        // foreach (string item in linkedList)
        // {
        //     Console.WriteLine(item);
        // }


        // ===== EXAMPLE 9: List<T> Sorting and Searching =====
        // Sort() sorts elements in ascending order
        // Reverse() reverses the order
        // Find() finds first element matching condition
        // FindAll() returns all matching elements
        // 
        // List<int> scores = new List<int> { 85, 92, 78, 95, 88 };
        // scores.Sort();
        // Console.WriteLine("Sorted: " + string.Join(", ", scores));
        // scores.Reverse();
        // Console.WriteLine("Reversed: " + string.Join(", ", scores));
        // int found = scores.Find(x => x > 90);
        // Console.WriteLine($"First score > 90: {found}");


        // ===== ALTERNATIVE: Collection Initializers =====
        // Initialize collections with values inline
        // Cleaner syntax for creating pre-populated collections
        // Works with List, Dictionary, HashSet, etc.
        // 
        // Example usage:
        // List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        // Dictionary<string, int> inventory = new Dictionary<string, int>
        // {
        //     { "Apples", 10 },
        //     { "Oranges", 5 }
        // };
        // HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };


        // ===== BEST PRACTICES: LINQ with Collections =====
        // LINQ provides powerful querying capabilities
        // Where() filters elements
        // Select() transforms elements
        // OrderBy() sorts elements
        // 
        // Example:
        // using System.Linq;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        var doubled = numbers.Select(n => n * 2);
        var sorted = numbers.OrderByDescending(n => n);
        foreach(int x in evenNumbers)
        {
            Console.WriteLine(x);
        }

        // ===== EXAMPLE 10: Finding Most Frequent Word Pattern =====
        // This example finds words with the same first and last character pattern
        // Uses Dictionary as frequency counter (like unordered_map in C++)
        // Steps:
        // 1. Split string into words
        // 2. Extract first and last character of each word
        // 3. Count frequency of each pattern
        // 4. Find and display the most frequent pattern(s)
        
        // string s="hello my name is krrish my ho hello my my ho";
        // Dictionary<string,int>freq=new Dictionary<string, int>();
        
        // // Split the sentence into individual words using space as delimiter
        // string [] words=s.Split(' ');
        
        // // Array to store first-last character pattern of each word
        // string []val=new string[words.Length];
        
        // // Extract first and last character from each word
        // for(int i = 0; i < words.Length; i++)
        // {
        //     string word=words[i];
        //     char first=word[0];                    // Get first character
        //     char last=word[word.Length-1];         // Get last character
        //     val[i] = first.ToString() + last.ToString();  // Combine as string pattern
        // }
        
        // // Display all patterns (for debugging)
        // foreach (string item in val)
        // {
        //     Console.WriteLine(item);
        // }
        
        // // Count frequency of each pattern using Dictionary
        // for(int i = 0; i < val.Length; i++)
        // {
        //     if (freq.ContainsKey(val[i]))
        //     {
        //         freq[val[i]]++;    // Increment count if pattern exists
        //     }
        //     else
        //     {
        //         freq[val[i]]=1;    // Add new pattern with count 1
        //     }
        // }
        
        // // Find the maximum frequency value
        // int maxi=0;
        // foreach(var k in freq)
        // {
        //     if (k.Value > maxi)
        //     {
        //         maxi=k.Value;      // Update max if current value is greater
        //     }
        // }
        
        // // Display all patterns that have the maximum frequency
        // foreach(var k in freq)
        // {
        //     if (k.Value == maxi)
        //     {
        //         Console.WriteLine(k.Key);  // Print pattern with highest count
        //     }
        // }

        // List<int>l1=new List<int>{1,3,5,6};
        // List<int>l2=new List<int>{1,5,8,9};
        // int n=5;
        // Console.WriteLine("enter elements for l1");
        // for(int i = 0; i < n; i++)
        // {
        //     l1.Add(Convert.ToInt32(Console.ReadLine()));
        // }
        // Console.WriteLine("enter elements for l2");
        // for(int i = 0; i < n; i++)
        // {
        //     l2.Add(Convert.ToInt32(Console.ReadLine()));
        // }
        // List<int>l3=l1.Concat(l2).Distinct().ToList();
        // foreach(int x in l2)
        // {
        //     if (l3.Contains(x))
        //     {
        //         l3.Remove(x);
        //     }
        //     else
        //     {
        //         l3.Add(x);
        //     }
        // }
        // Console.WriteLine("elements for l3");
        // List<int>l3=l1.Except(l2).Concat(l2.Except(l1)).ToList();
        // foreach(int x in l3)    
        // {
        //     Console.WriteLine(x);
        // }
    }
}