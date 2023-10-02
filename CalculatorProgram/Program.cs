using System.Collections.Concurrent;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("---------------------");
            Console.WriteLine(" Calculator Program ");
            Console.WriteLine("---------------------");

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add"); // \t adds in a tab spacing
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.WriteLine();
            Console.Write("Please enter an option: ");

            //create a switch to read user input 

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;





            }

            Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");

        }
        while(Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine();
        Console.WriteLine("Bye!");
        Console.ReadKey();
    }
}