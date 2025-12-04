using System;
using System.Collections.Generic;
using System.Linq;
using Workshop6;

class Program
{
    static void Main()
    {
        // LINQ – Projection
        NumberSquarer squarer = new NumberSquarer();
        squarer.SquareNumbers();

        // LINQ – Filtering (Books > 1000)
        List<Book> books = new List<Book>
        {
            new Book("C# Mastery", 1500),
            new Book("Python Basics", 800),
            new Book("Data Structures", 1200),
            new Book("AI Essentials", 950),
            new Book("Web Development", 1800)
        };

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("Premium Books (Price > 1000):");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine($"{book.Title} - Rs. {book.Price}");
        }
        Console.WriteLine();

        // LINQ – Sorting Students
        List<Student> students = new List<Student>
        {
            new Student("Sanjay"),
            new Student("Aarohi"),
            new Student("Bibek"),
            new Student("Ritesh"),
            new Student("Manoj"),
            new Student("Sara"),
            new Student("Alisha"),
            new Student("Nirajan"),
            new Student("Kritika"),
            new Student("Dipesh")
        };

        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("AAA Scholarship – Sorted Student Names:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}