using System;

namespace CSharpPlayground
{
    public static class Day01_Records
    {
        // 1. Definition: Records are reference types with value-based equality.
        // Positional records provide a concise syntax for immutable data models.
        public record Person(string FirstName, string LastName, int Age);

        public static void Run()
        {
            Console.WriteLine("=== Day 1: C# Records ===");

            // 2. Creation
            var person1 = new Person("John", "Doe", 30);
            Console.WriteLine($"Original: {person1}");

            // 3. Immutability & Nondestructive Mutation (with expression)
            // Records are immutable by default. You use 'with' to create a copy with changes.
            var person2 = person1 with { Age = 31 };
            Console.WriteLine($"Modified Copy (Age 31): {person2}");
            Console.WriteLine($"Original is unchanged: {person1}");

            // 4. Value-based Equality
            // Unlike classes, records compares values, not references.
            var person3 = new Person("John", "Doe", 30);
            Console.WriteLine($"Is person1 equal to person3 (same values)? {person1 == person3}"); // True

            var person4 = new Person("Jane", "Doe", 25);
            Console.WriteLine($"Is person1 equal to person4? {person1 == person4}"); // False
            
            Console.WriteLine("Concept: Records simplify creating immutable data objects and give you built-in formatting and value equality.");
            Console.WriteLine();
        }
    }
}
