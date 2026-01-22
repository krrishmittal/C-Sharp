# Day 11 - LINQ (Language Integrated Query) in C#

## Topics Covered

### 1. **What is LINQ?**
   - LINQ is a powerful query language integrated into C#
   - Introduced in .NET 3.5 and C# 3.0 by Microsoft
   - Available in `System.Linq` namespace
   - Provides consistent way to query data from various sources

### 2. **LINQ Query Syntax Types**
   - **Query Syntax (SQL-like)**:
     ```csharp
     var querySyntax = from num in numbers
                       where num > 5
                       select num;
     ```
   - **Method Syntax (Lambda-based)**:
     ```csharp
     var methodSyntax = numbers.Where(x => x > 5);
     ```
   - **Mixed Syntax**:
     ```csharp
     var mixedSyntax = (from num in numbers select num).Max();
     ```

### 3. **Projection Operators (Select, SelectMany)**
   - **Select** - Projects each element into a new form
     ```csharp
     var names = employees.Select(e => e.Name).ToList();
     var empInfo = employees.Select(e => new { e.Name, e.Department });
     ```
   - **SelectMany** - Flattens nested collections
     ```csharp
     List<string> words = new List<string> { "Hello", "World" };
     var characters = words.SelectMany(w => w).ToList();
     ```

### 4. **Filtering Operators (Where, OfType)**
   - **Where** - Filters elements based on a condition
     ```csharp
     var filteredEmployees = employees.Where(e => e.Salary > 50000);
     ```
   - **OfType** - Filters elements by type
     ```csharp
     var mixedData = new List<object> { "Hello", 1, 2, "World", 3, 4.5, true };
     var onlyStrings = mixedData.OfType<string>().ToList();
     var onlyIntegers = mixedData.OfType<int>().ToList();
     ```

### 5. **Sorting Operators**
   - **OrderBy** - Sorts in ascending order
     ```csharp
     var sortedByName = employees.OrderBy(e => e.Name);
     ```
   - **OrderByDescending** - Sorts in descending order
     ```csharp
     var sortedBySalaryDesc = employees.OrderByDescending(e => e.Salary);
     ```
   - **ThenBy / ThenByDescending** - Secondary sorting
     ```csharp
     var multiSort = employees.OrderBy(e => e.Department).ThenBy(e => e.Name);
     ```
   - **Reverse** - Reverses the order of elements

### 6. **Partitioning Operators**
   - **Take** - Returns first n elements: `numbers.Take(3)`
   - **TakeLast** - Returns last n elements: `numbers.TakeLast(3)`
   - **TakeWhile** - Takes elements while condition is true: `numbers.TakeWhile(n => n < 5)`
   - **Skip** - Skips first n elements: `numbers.Skip(3)`
   - **SkipLast** - Skips last n elements: `numbers.SkipLast(3)`
   - **SkipWhile** - Skips elements while condition is true: `numbers.SkipWhile(n => n < 5)`

### 7. **Set Operators**
   - **Distinct** - Removes duplicate elements
     ```csharp
     var distinctValues = duplicateList.Distinct();
     ```
   - **Union** - Combines two sequences (no duplicates)
     ```csharp
     var union = set1.Union(set2);
     ```
   - **Intersect** - Returns common elements
     ```csharp
     var intersect = set1.Intersect(set2);
     ```
   - **Except** - Returns elements in first but not in second
     ```csharp
     var except = set1.Except(set2);
     ```

### 8. **Quantifier Operators**
   - **All** - Checks if all elements match a condition
     ```csharp
     bool allPositive = numbers.All(n => n > 0);
     ```
   - **Any** - Checks if any element matches a condition
     ```csharp
     bool anyGreaterThan5 = numbers.Any(n => n > 5);
     ```
   - **Contains** - Checks if sequence contains a specific element
     ```csharp
     bool containsFive = numbers.Contains(5);
     ```

### 9. **Aggregate Operators**
   - **Count** - Returns the number of elements
   - **Sum** - Returns the sum of values
   - **Min** - Returns the minimum value
   - **Max** - Returns the maximum value
   - **Average** - Returns the average of values
   - **Aggregate** - Applies a custom accumulator function
     ```csharp
     var concatenated = employees.Aggregate("", (current, emp) => current + emp.Name + " ");
     ```

### 10. **Element Operators**
   - **First / FirstOrDefault** - Returns first element (or default if empty)
   - **Last / LastOrDefault** - Returns last element (or default if empty)
   - **Single / SingleOrDefault** - Returns single element (throws if multiple)
   - **ElementAt / ElementAtOrDefault** - Returns element at specified index
   - **DefaultIfEmpty** - Returns default value if sequence is empty
     ```csharp
     var emptyList = new List<int>();
     var withDefault = emptyList.DefaultIfEmpty(999);
     ```

### 11. **Grouping Operators**
   - **GroupBy** - Groups elements by a key
     ```csharp
     var groupedByDept = employees.GroupBy(e => e.Department);
     foreach (var group in groupedByDept)
     {
         Console.WriteLine($"{group.Key}: {string.Join(", ", group.Select(e => e.Name))}");
     }
     ```
   - **ToLookup** - Creates a lookup with multiple values per key
     ```csharp
     var lookup = employees.ToLookup(e => e.Department);
     ```

### 12. **Join Operators**
   - **Inner Join** - Joins two sequences based on matching keys
     ```csharp
     var innerJoin = employees.Join(
         departments,
         emp => emp.Department,
         dept => dept.DeptName,
         (emp, dept) => new { emp.Name, dept.DeptName }
     );
     ```
   - **GroupJoin** - Joins and groups results
     ```csharp
     var groupJoin = departments.GroupJoin(
         employees,
         dept => dept.DeptName,
         emp => emp.Department,
         (dept, emps) => new { dept.DeptName, Count = emps.Count() }
     );
     ```

### 13. **Concatenation Operators**
   - **Concat** - Concatenates two sequences
     ```csharp
     var concatenatedList = list1.Concat(list2);
     ```
   - **Zip** - Combines elements from two sequences pairwise
     ```csharp
     var zipped = namesArray.Zip(salaries, (name, salary) => $"{name}: {salary}");
     ```
   - **Append / Prepend** - Adds element at end or beginning
     ```csharp
     var appendResult = numbers.Take(3).Append(100);
     var prependResult = numbers.Take(3).Prepend(0);
     ```

### 14. **Conversion Operators**
   - **ToList** - Converts to List<T>
   - **ToArray** - Converts to array
   - **ToDictionary** - Converts to Dictionary
     ```csharp
     var toDictionary = employees.ToDictionary(e => e.Id, e => e.Name);
     ```
   - **AsEnumerable** - Returns as IEnumerable<T>
   - **AsQueryable** - Returns as IQueryable<T>
   - **Cast** - Casts elements to specified type
     ```csharp
     var castToInt = objectList.Cast<int>().ToList();
     ```

### 15. **Generation Operators**
   - **Range** - Generates a sequence of integers
     ```csharp
     var range = Enumerable.Range(1, 5);  // 1, 2, 3, 4, 5
     ```
   - **Repeat** - Generates a sequence with repeated value
     ```csharp
     var repeat = Enumerable.Repeat("Hello", 3);  // "Hello", "Hello", "Hello"
     ```
   - **Empty** - Returns an empty sequence
     ```csharp
     var empty = Enumerable.Empty<int>();
     ```

### 16. **Equality Operator**
   - **SequenceEqual** - Checks if two sequences are equal
     ```csharp
     var seq1 = new List<int> { 1, 2, 3 };
     var seq2 = new List<int> { 1, 2, 3 };
     bool areEqual = seq1.SequenceEqual(seq2);  // true
     ```

### 17. **Key Points to Remember**
   - LINQ provides type-safe queries with compile-time checking
   - Query syntax is SQL-like, Method syntax uses lambda expressions
   - Both syntaxes produce identical results
   - LINQ supports deferred execution (query executes when enumerated)
   - Use `ToList()`, `ToArray()` for immediate execution
   - Built-in operators cover filtering, projection, sorting, grouping, joining, and more
   - LINQ works with any `IEnumerable<T>` or `IQueryable<T>` source
