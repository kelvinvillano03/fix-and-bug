    using System;

namespace fix_and_bug
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;
            string ops;



            Console.WriteLine("Type the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("	a - Add");
            Console.WriteLine("	s - Subtract");
            Console.WriteLine("	m - Multiply");
            Console.WriteLine("	d - Divide");
            Console.WriteLine("Your option? ");

            ops = Console.ReadLine();

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (ops)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Can't divide by zero");
                    }
                    else
                    {
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    }
                    break;


                    Console.Write("Press any key to close the Calculator console app...");
                    Console.ReadKey();
            }
        }
    }
}
