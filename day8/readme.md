# Day 8 - Collections in C# (Generics)

## Topics Covered

### 1. **System.Collections.Generic Namespace**
   - The `System.Collections.Generic` namespace provides type-safe collection classes
   - Essential for working with dynamic data structures in C#
   - Contains classes like `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, `Queue<T>`, `Stack<T>`, and `LinkedList<T>`

### 2. **List\<T\> Class**
   - A dynamic array that can grow and shrink automatically
   - **Add()** - Adds element to the end of the list
   - **Remove()** - Removes the first occurrence of an element
   - **Insert()** - Adds element at a specific index
   - **RemoveAt()** - Removes element at a specific index
   - **Contains()** - Checks if an element exists in the list
   - **Count** - Property that returns the number of elements
   - Access elements using index like arrays: `list[0]`
   - Can use LINQ methods like `Count(x => x == value)` to count specific elements

### 3. **Dictionary\<TKey, TValue\> Class**
   - Stores key-value pairs for fast lookup
   - Keys must be unique, values can be duplicated
   - **Add()** - Adds a new key-value pair
   - **Indexer** - `dictionary[key] = value` to add or update
   - **ContainsKey()** - Checks if a key exists before accessing
   - **TryGetValue()** - Safely retrieves value without throwing exception
   - **Remove()** - Removes entry by key
   - Prevents `KeyNotFoundException` by checking key existence first

### 4. **HashSet\<T\> Class**
   - Stores only unique elements (no duplicates allowed)
   - Duplicates are automatically ignored when adding
   - **Add()** - Returns `false` if element already exists
   - Useful for removing duplicates from data
   - Provides fast lookup operations

### 5. **Queue\<T\> Class - FIFO**
   - Follows First In First Out (FIFO) principle
   - **Enqueue()** - Adds element to the back of the queue
   - **Dequeue()** - Removes and returns the front element
   - **Peek()** - Returns front element without removing it
   - **Count** - Returns number of elements in the queue
   - Useful for processing items in order they were added

### 6. **Stack\<T\> Class - LIFO**
   - Follows Last In First Out (LIFO) principle
   - **Push()** - Adds element to the top of the stack
   - **Pop()** - Removes and returns the top element
   - **Peek()** - Returns top element without removing it
   - **Count** - Returns number of elements in the stack
   - Useful for undo operations, expression parsing, backtracking

### 7. **LinkedList\<T\> Class**
   - A doubly-linked list implementation
   - **AddFirst()** - Adds element at the beginning
   - **AddLast()** - Adds element at the end
   - **AddAfter()** - Adds element after a specific node
   - **AddBefore()** - Adds element before a specific node
   - Access nodes using `First`, `Last`, and `Next` properties
   - Efficient for frequent insertions/deletions in the middle

### 8. **List\<T\> Sorting and Searching**
   - **Sort()** - Sorts elements in ascending order
   - **Reverse()** - Reverses the order of elements
   - **Find()** - Finds first element matching a condition (lambda)
   - **FindAll()** - Returns all elements matching a condition
   - Use `string.Join()` to display list contents as comma-separated values

### 9. **Collection Initializers**
   - Initialize collections with values inline using curly braces
   - Cleaner syntax for creating pre-populated collections
   - Works with `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, etc.
   - Example: `List<int> nums = new List<int> { 1, 2, 3 };`
   - Dictionary syntax: `{ { "key", value }, { "key2", value2 } }`

### 10. **LINQ with Collections**
   - LINQ (Language Integrated Query) provides powerful querying capabilities
   - Requires `using System.Linq;` namespace
   - **Where()** - Filters elements based on a condition
   - **Select()** - Transforms/projects elements
   - **OrderBy()** / **OrderByDescending()** - Sorts elements
   - **Concat()** - Combines two collections
   - **Distinct()** - Returns unique elements
   - **Except()** - Returns elements in first but not in second collection

### 11. **Using Dictionary as Frequency Counter**
   - Similar to `unordered_map` in C++
   - Pattern for counting occurrences:
     ```csharp
     if (freq.ContainsKey(key))
         freq[key]++;
     else
         freq[key] = 1;
     ```
   - Iterate with `foreach (var kvp in dict)` to access `Key` and `Value`
   - Find maximum value by iterating and comparing

### 12. **Set Operations with LINQ**
   - **Union()** - All unique elements from both collections
   - **Intersect()** - Elements common to both collections
   - **Except()** - Elements in first but not in second
   - **Concat()** - Combines collections (keeps duplicates)
   - **Distinct()** - Removes duplicate elements
   - Convert to List using `.ToList()` method
