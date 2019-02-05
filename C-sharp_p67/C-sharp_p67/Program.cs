using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate?");
        string p1HourlyEntry = Console.ReadLine();
        double p1HourlyRate = Convert.ToDouble(p1HourlyEntry);
        Console.WriteLine("Hours worked per week?");
        string p1HoursWorkedEntry = Console.ReadLine();
        double p1HoursWorked = Convert.ToDouble(p1HoursWorkedEntry);

        Console.WriteLine("Person 2\nHourly Rate?");
        string p2HourlyEntry = Console.ReadLine();
        double p2HourlyRate = Convert.ToDouble(p2HourlyEntry);
        Console.WriteLine("Hours worked per week?");
        string p2HoursWorkedEntry = Console.ReadLine();
        double p2HoursWorked = Convert.ToDouble(p2HoursWorkedEntry);

        double p1Salary = p1HourlyRate * p1HoursWorked;
        Console.WriteLine("Weekly salary of Person 1:\n" + p1Salary);
        double p2Salary = p2HourlyRate * p2HoursWorked;
        Console.WriteLine("Weekly salary of Person 2:\n" + p2Salary);
        bool salaryDiff = p1Salary > p2Salary;
        Console.WriteLine("Does Person 1 make more money than Person 2?\n" + salaryDiff);
        Console.ReadLine();
    }
}
