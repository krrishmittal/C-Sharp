using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11_LINQ
{
    /// <summary>
    /// Day 11: LINQ (Language Integrated Query) - Complete Guide
    /// LINQ is a powerful query language integrated into C# for manipulating data.
    /// Introduced in .NET 3.5 and C# 3.0 by Microsoft.
    /// Available in System.Linq namespace.
    /// 
    /// Two Syntax Styles:
    /// 1. Query Syntax (SQL-like): from item in collection where condition select item
    /// 2. Method Syntax (Lambda-based): collection.Where(x => condition).Select(x => x)
    /// Both produce identical results. Method syntax is more common and flexible.
    /// </summary>
    class Program
    {
        public static void Main()
        {
            // Sample Data Sources
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Tom", Email = "tom@gmail.com", Department = "IT", Salary = 50000 },
                new Employee { Id = 2, Name = "Krrish", Email = "krrish@gmail.com", Department = "HR", Salary = 45000 },
                new Employee { Id = 3, Name = "Harman", Email = "harman@gmail.com", Department = "IT", Salary = 55000 },
                new Employee { Id = 4, Name = "Mohit", Email = "mohit@gmail.com", Department = "Finance", Salary = 60000 },
                new Employee { Id = 5, Name = "Rahul", Email = "rahul@gmail.com", Department = "IT", Salary = 52000 }
            };

            Console.WriteLine("═══ SECTION 1: LINQ QUERY SYNTAX TYPES ═══\n");

            // 1. Query Syntax (SQL-like)
            Console.WriteLine("1. Query Syntax:");
            var querySyntax = from num in numbers
                              where num > 5
                              select num;
            Console.WriteLine($"   Numbers > 5: {string.Join(", ", querySyntax)}");

            // 2. Method Syntax (Lambda-based)
            Console.WriteLine("\n2. Method Syntax:");
            var methodSyntax = numbers.Where(x => x > 5);
            Console.WriteLine($"   Numbers > 5: {string.Join(", ", methodSyntax)}");

            // 3. Mixed Syntax
            Console.WriteLine("\n3. Mixed Syntax:");
            var mixedSyntax = (from num in numbers select num).Max();
            Console.WriteLine($"   Max Value: {mixedSyntax}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 2: PROJECTION OPERATORS (Select, SelectMany)
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 2: PROJECTION OPERATORS ═══\n");

            // Select - Projects each element
            Console.WriteLine("1. Select:");
            var names = employees.Select(e => e.Name).ToList();
            Console.WriteLine($"   Employee Names: {string.Join(", ", names)}");

            // Select with Anonymous Type
            Console.WriteLine("\n2. Select with Anonymous Type:");
            var empInfo = employees.Select(e => new { e.Name, e.Department }).Take(3);
            foreach (var emp in empInfo)
                Console.WriteLine($"   {emp.Name} - {emp.Department}");

            // SelectMany - Flattens nested collections
            Console.WriteLine("\n3. SelectMany:");
            List<string> words = new List<string> { "Hello", "World" };
            var characters = words.SelectMany(w => w).ToList();
            Console.WriteLine($"   Characters: {string.Join(", ", characters)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 3: FILTERING OPERATORS (Where, OfType)
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 3: FILTERING OPERATORS ═══\n");

            // Where
            Console.WriteLine("1. Where:");
            var filteredEmployees = employees.Where(e => e.Salary > 50000);
            foreach (var emp in filteredEmployees)
                Console.WriteLine($"   {emp.Name} - Salary: {emp.Salary}");

            // OfType - Filters by type
            Console.WriteLine("\n2. OfType:");
            var mixedData = new List<object> { "Hello", 1, 2, "World", 3, 4.5, true };
            var onlyStrings = mixedData.OfType<string>().ToList();
            var onlyIntegers = mixedData.OfType<int>().ToList();
            Console.WriteLine($"   Strings: {string.Join(", ", onlyStrings)}");
            Console.WriteLine($"   Integers: {string.Join(", ", onlyIntegers)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 4: SORTING OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 4: SORTING OPERATORS ═══\n");

            // OrderBy
            Console.WriteLine("1. OrderBy (Ascending):");
            var sortedByName = employees.OrderBy(e => e.Name).Select(e => e.Name);
            Console.WriteLine($"   {string.Join(", ", sortedByName)}");

            // OrderByDescending
            Console.WriteLine("\n2. OrderByDescending:");
            var sortedBySalaryDesc = employees.OrderByDescending(e => e.Salary).Select(e => $"{e.Name}: {e.Salary}");
            Console.WriteLine($"   {string.Join(" | ", sortedBySalaryDesc)}");

            // ThenBy / ThenByDescending
            Console.WriteLine("\n3. ThenBy (Secondary Sort):");
            var multiSort = employees.OrderBy(e => e.Department).ThenBy(e => e.Name);
            foreach (var emp in multiSort)
                Console.WriteLine($"   {emp.Department} - {emp.Name}");

            // Reverse
            Console.WriteLine("\n4. Reverse:");
            var reversed = numbers.ToList();
            reversed.Reverse();
            Console.WriteLine($"   Reversed: {string.Join(", ", reversed)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 5: PARTITIONING OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 5: PARTITIONING OPERATORS ═══\n");

            // Take
            Console.WriteLine("1. Take:");
            var firstThree = numbers.Take(3);
            Console.WriteLine($"   First 3: {string.Join(", ", firstThree)}");

            // TakeLast
            Console.WriteLine("\n2. TakeLast:");
            var lastThree = numbers.TakeLast(3);
            Console.WriteLine($"   Last 3: {string.Join(", ", lastThree)}");

            // TakeWhile
            Console.WriteLine("\n3. TakeWhile:");
            var takeWhile = numbers.TakeWhile(n => n < 5);
            Console.WriteLine($"   TakeWhile < 5: {string.Join(", ", takeWhile)}");

            // Skip
            Console.WriteLine("\n4. Skip:");
            var skipThree = numbers.Skip(3);
            Console.WriteLine($"   Skip 3: {string.Join(", ", skipThree)}");

            // SkipLast
            Console.WriteLine("\n5. SkipLast:");
            var skipLastThree = numbers.SkipLast(3);
            Console.WriteLine($"   SkipLast 3: {string.Join(", ", skipLastThree)}");

            // SkipWhile
            Console.WriteLine("\n6. SkipWhile:");
            var skipWhile = numbers.SkipWhile(n => n < 5);
            Console.WriteLine($"   SkipWhile < 5: {string.Join(", ", skipWhile)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 6: SET OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 6: SET OPERATORS ═══\n");

            List<int> set1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> set2 = new List<int> { 4, 5, 6, 7, 8 };

            // Distinct
            Console.WriteLine("1. Distinct:");
            var duplicateList = new List<int> { 1, 1, 2, 2, 3, 3 };
            var distinctValues = duplicateList.Distinct();
            Console.WriteLine($"   Distinct: {string.Join(", ", distinctValues)}");

            // Union
            Console.WriteLine("\n2. Union:");
            var union = set1.Union(set2);
            Console.WriteLine($"   Set1 ∪ Set2: {string.Join(", ", union)}");

            // Intersect
            Console.WriteLine("\n3. Intersect:");
            var intersect = set1.Intersect(set2);
            Console.WriteLine($"   Set1 ∩ Set2: {string.Join(", ", intersect)}");

            // Except
            Console.WriteLine("\n4. Except:");
            var except = set1.Except(set2);
            Console.WriteLine($"   Set1 - Set2: {string.Join(", ", except)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 7: QUANTIFIER OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 7: QUANTIFIER OPERATORS ═══\n");

            // All
            Console.WriteLine("1. All:");
            bool allPositive = numbers.All(n => n > 0);
            Console.WriteLine($"   All numbers positive? {allPositive}");

            // Any
            Console.WriteLine("\n2. Any:");
            bool anyGreaterThan5 = numbers.Any(n => n > 5);
            Console.WriteLine($"   Any number > 5? {anyGreaterThan5}");

            // Contains
            Console.WriteLine("\n3. Contains:");
            bool containsFive = numbers.Contains(5);
            Console.WriteLine($"   Contains 5? {containsFive}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 8: AGGREGATE OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 8: AGGREGATE OPERATORS ═══\n");

            // Count
            Console.WriteLine("1. Count:");
            Console.WriteLine($"   Total numbers: {numbers.Count()}");
            Console.WriteLine($"   Numbers > 5: {numbers.Count(n => n > 5)}");

            // Sum
            Console.WriteLine("\n2. Sum:");
            Console.WriteLine($"   Sum of numbers: {numbers.Sum()}");
            Console.WriteLine($"   Total Salaries: {employees.Sum(e => e.Salary)}");

            // Min
            Console.WriteLine("\n3. Min:");
            Console.WriteLine($"   Min number: {numbers.Min()}");
            Console.WriteLine($"   Min salary: {employees.Min(e => e.Salary)}");

            // Max
            Console.WriteLine("\n4. Max:");
            Console.WriteLine($"   Max number: {numbers.Max()}");
            Console.WriteLine($"   Max salary: {employees.Max(e => e.Salary)}");

            // Average
            Console.WriteLine("\n5. Average:");
            Console.WriteLine($"   Average: {numbers.Average():F2}");
            Console.WriteLine($"   Average salary: {employees.Average(e => e.Salary):F2}");

            // Aggregate
            Console.WriteLine("\n6. Aggregate (Custom):");
            var concatenated = employees.Aggregate("", (current, emp) => current + emp.Name + " ");
            Console.WriteLine($"   Names concatenated: {concatenated.Trim()}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 9: ELEMENT OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 9: ELEMENT OPERATORS ═══\n");

            // First / FirstOrDefault
            Console.WriteLine("1. First / FirstOrDefault:");
            Console.WriteLine($"   First: {numbers.First()}");
            Console.WriteLine($"   First > 5: {numbers.First(n => n > 5)}");
            Console.WriteLine($"   FirstOrDefault > 100: {numbers.FirstOrDefault(n => n > 100)}");

            // Last / LastOrDefault
            Console.WriteLine("\n2. Last / LastOrDefault:");
            Console.WriteLine($"   Last: {numbers.Last()}");
            Console.WriteLine($"   LastOrDefault: {numbers.LastOrDefault(n => n > 100)}");

            // Single / SingleOrDefault
            Console.WriteLine("\n3. Single / SingleOrDefault:");
            var singleEmp = employees.SingleOrDefault(e => e.Id == 1);
            Console.WriteLine($"   Single employee with Id=1: {singleEmp?.Name}");

            // ElementAt / ElementAtOrDefault
            Console.WriteLine("\n4. ElementAt / ElementAtOrDefault:");
            Console.WriteLine($"   Element at index 3: {numbers.ElementAt(3)}");
            Console.WriteLine($"   Element at index 100: {numbers.ElementAtOrDefault(100)}");

            // DefaultIfEmpty
            Console.WriteLine("\n5. DefaultIfEmpty:");
            var emptyList = new List<int>();
            var withDefault = emptyList.DefaultIfEmpty(999);
            Console.WriteLine($"   Empty list with default: {string.Join(", ", withDefault)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 10: GROUPING OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 10: GROUPING OPERATORS ═══\n");

            // GroupBy
            Console.WriteLine("1. GroupBy:");
            var groupedByDept = employees.GroupBy(e => e.Department);
            foreach (var group in groupedByDept)
            {
                Console.WriteLine($"   {group.Key}: {string.Join(", ", group.Select(e => e.Name))}");
            }

            // ToLookup
            Console.WriteLine("\n2. ToLookup:");
            var lookup = employees.ToLookup(e => e.Department);
            Console.WriteLine($"   IT Department: {string.Join(", ", lookup["IT"].Select(e => e.Name))}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 11: JOIN OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 11: JOIN OPERATORS ═══\n");

            List<Department> departments = new List<Department>
            {
                new Department { Id = 1, DeptName = "IT" },
                new Department { Id = 2, DeptName = "HR" },
                new Department { Id = 3, DeptName = "Finance" }
            };

            // Inner Join
            Console.WriteLine("1. Inner Join:");
            var innerJoin = employees.Join(
                departments,
                emp => emp.Department,
                dept => dept.DeptName,
                (emp, dept) => new { emp.Name, dept.DeptName }
            );
            foreach (var item in innerJoin.Take(3))
                Console.WriteLine($"   {item.Name} works in {item.DeptName}");

            // GroupJoin
            Console.WriteLine("\n2. GroupJoin:");
            var groupJoin = departments.GroupJoin(
                employees,
                dept => dept.DeptName,
                emp => emp.Department,
                (dept, emps) => new { dept.DeptName, Count = emps.Count() }
            );
            foreach (var item in groupJoin)
                Console.WriteLine($"   {item.DeptName}: {item.Count} employees");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 12: CONCATENATION OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 12: CONCATENATION OPERATORS ═══\n");

            // Concat
            Console.WriteLine("1. Concat:");
            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 4, 5, 6 };
            var concatenatedList = list1.Concat(list2);
            Console.WriteLine($"   Concatenated: {string.Join(", ", concatenatedList)}");

            // Zip
            Console.WriteLine("\n2. Zip:");
            var namesArray = new[] { "Tom", "Krrish", "Harman" };
            var salaries = new[] { 50000, 45000, 55000 };
            var zipped = namesArray.Zip(salaries, (name, salary) => $"{name}: {salary}");
            foreach (var item in zipped)
                Console.WriteLine($"   {item}");

            // Append / Prepend
            Console.WriteLine("\n3. Append / Prepend:");
            var appendResult = numbers.Take(3).Append(100);
            var prependResult = numbers.Take(3).Prepend(0);
            Console.WriteLine($"   Append 100: {string.Join(", ", appendResult)}");
            Console.WriteLine($"   Prepend 0: {string.Join(", ", prependResult)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 13: CONVERSION OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 13: CONVERSION OPERATORS ═══\n");

            // ToList
            Console.WriteLine("1. ToList:");
            var toList = numbers.Where(n => n > 5).ToList();
            Console.WriteLine($"   Type: {toList.GetType().Name}");

            // ToArray
            Console.WriteLine("\n2. ToArray:");
            var toArray = numbers.Where(n => n > 5).ToArray();
            Console.WriteLine($"   Type: {toArray.GetType().Name}");

            // ToDictionary
            Console.WriteLine("\n3. ToDictionary:");
            var toDictionary = employees.ToDictionary(e => e.Id, e => e.Name);
            Console.WriteLine($"   Employee Id 1: {toDictionary[1]}");

            // AsEnumerable / AsQueryable
            Console.WriteLine("\n4. AsEnumerable / AsQueryable:");
            IEnumerable<int> asEnumerable = numbers.AsEnumerable();
            IQueryable<int> asQueryable = numbers.AsQueryable();
            Console.WriteLine($"   AsEnumerable Type: {asEnumerable.GetType().Name}");
            Console.WriteLine($"   AsQueryable Type: {asQueryable.GetType().Name}");

            // Cast
            Console.WriteLine("\n5. Cast:");
            var objectList = new List<object> { 1, 2, 3, 4, 5 };
            var castToInt = objectList.Cast<int>().ToList();
            Console.WriteLine($"   Cast result: {string.Join(", ", castToInt)}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 14: GENERATION OPERATORS
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 14: GENERATION OPERATORS ═══\n");

            // Range
            Console.WriteLine("1. Range:");
            var range = Enumerable.Range(1, 5);
            Console.WriteLine($"   Range(1, 5): {string.Join(", ", range)}");

            // Repeat
            Console.WriteLine("\n2. Repeat:");
            var repeat = Enumerable.Repeat("Hello", 3);
            Console.WriteLine($"   Repeat('Hello', 3): {string.Join(", ", repeat)}");

            // Empty
            Console.WriteLine("\n3. Empty:");
            var empty = Enumerable.Empty<int>();
            Console.WriteLine($"   Empty<int> count: {empty.Count()}");

            // ═══════════════════════════════════════════════════════════════
            // SECTION 15: EQUALITY OPERATOR
            // ═══════════════════════════════════════════════════════════════
            Console.WriteLine("\n═══ SECTION 15: EQUALITY OPERATOR ═══\n");

            // SequenceEqual
            Console.WriteLine("1. SequenceEqual:");
            var seq1 = new List<int> { 1, 2, 3 };
            var seq2 = new List<int> { 1, 2, 3 };
            var seq3 = new List<int> { 3, 2, 1 };
            Console.WriteLine($"   seq1 equals seq2? {seq1.SequenceEqual(seq2)}");
            Console.WriteLine($"   seq1 equals seq3? {seq1.SequenceEqual(seq3)}");

            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              END OF LINQ DEMONSTRATION                       ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        }
    }

    // ═══════════════════════════════════════════════════════════════
    // SUPPORTING CLASSES
    // ═══════════════════════════════════════════════════════════════

    /// <summary>
    /// Employee class for demonstrating LINQ operations
    /// </summary>
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    /// <summary>
    /// Department class for demonstrating Join operations
    /// </summary>
    class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
    }

    /// <summary>
    /// Person class for additional demonstrations
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}


