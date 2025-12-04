using System;
using System.Collections.Generic;
using System.Linq;
using Workshop6;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task 5: LINQ Continued\n");

        // 1️⃣ Aggregation Operators (Sum, Count, Min, Max, Average)
        Console.WriteLine("Supermarket Sales Summary:\n");

        List<CashierSales> salesList = new List<CashierSales>
        {
            new CashierSales("Ramesh", 5500),
            new CashierSales("Sita", 4200),
            new CashierSales("Kamal", 7800),
            new CashierSales("Bina", 3000),
            new CashierSales("Raju", 6500)
        };

        int totalCashiers = salesList.Count();
        double totalSales = salesList.Sum(cs => cs.SalesAmount);
        double highestSale = salesList.Max(cs => cs.SalesAmount);
        double lowestSale = salesList.Min(cs => cs.SalesAmount);
        double averageSale = salesList.Average(cs => cs.SalesAmount);

        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: Rs. {totalSales}");
        Console.WriteLine($"Highest Sale: Rs. {highestSale}");
        Console.WriteLine($"Lowest Sale: Rs. {lowestSale}");
        Console.WriteLine($"Average Sale: Rs. {averageSale:F2}\n");


        // 2️⃣ Quantifier Operators (Any, All)
        Console.WriteLine("Election Commission Age Check:\n");

        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant("Ritesh", 20),
            new Applicant("Aarav", 17),
            new Applicant("Suman", 19),
            new Applicant("Priya", 18),
            new Applicant("Deepa", 16)
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine($"Any applicant under 18? -> {anyUnder18}");
        Console.WriteLine($"Are all applicants above 16? -> {allAbove16}\n");


        // 3️⃣ Element Operators (First, Last, FirstOrDefault)
        Console.WriteLine("Music App – Song Duration Analysis:\n");

        List<Music> songs = new List<Music>
        {
            new Music("Feel Good", 180),
            new Music("Calm Breeze", 250),
            new Music("Hard Beat", 300),
            new Music("Long Journey", 380),
            new Music("Night Sky", 240)
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.FirstOrDefault(s => s.DurationSeconds > 240); // > 4 min
        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600); // safe result

        Console.WriteLine($"First Song: {firstSong.SongName}");
        Console.WriteLine($"Last Song: {lastSong.SongName}");

        Console.WriteLine($"First Song > 4 min: {firstAbove4Min?.SongName ?? "No song found"}");
        Console.WriteLine($"First Song > 10 min (safe): {firstAbove10Min?.SongName ?? "No song found"}");
    }
}