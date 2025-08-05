using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is: Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is: Isosceles");
        }
        else
        {
            Console.WriteLine("The triangle is: Scalene");
        }
    }
}
