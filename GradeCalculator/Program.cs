using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your numerical grade (0 - 100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade entered.");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is: D");
        }
        else
        {
            Console.WriteLine("Your letter grade is: F");
        }
    }
}
