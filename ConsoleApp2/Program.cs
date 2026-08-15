using System;
using System.Data;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        bool systemact = true;

        do
        {
            Console.WriteLine("Welcome to a simple console UI.");
            Console.WriteLine("Please choose a program below: ");
            Console.WriteLine("1. Calculator\n2. Bool Checker\n3. Exit\n");

            string systemanswer = Console.ReadLine();

            switch (systemanswer)
            {
                case "1":
                    ExecutarCalculadora();
                    break;

                case "2":
                    ExecutarBoolChecker();
                    break;

                case "3":
                    Console.WriteLine("Exiting the system... Goodbye and thank you for supporting!!!");
                    Console.WriteLine("By BrandaoCode");
                    await Task.Delay(3000);
                    systemact = false;
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try again.\n");
                    break;
            }

        } while (systemact);
    }

    private static void ExecutarCalculadora()
    {
        while (true)
        {
            try
            {
                DataTable table = new DataTable();
                Console.WriteLine("\nWrite your operation (e.g., 5 + 5):");
                string expression = Console.ReadLine();

                var result = table.Compute(expression, "");
                Console.WriteLine($"Result: {result}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The expression was invalid! Error: " + ex.Message + "\n");
            }

            Console.WriteLine("Use calculator again? 1. Yes 2. No");
            string tryagain = Console.ReadLine();
            if (tryagain == "2") break;
        }
    }

    private static void ExecutarBoolChecker()
    {
        while (true)
        {
            Console.WriteLine("\nChoose a boolean value:\n1. True\n2. False\n3. Go back to menu");
            string boolanswer = Console.ReadLine();

            if (boolanswer == "1")
            {
                Console.WriteLine("The value is True");
            }
            else if (boolanswer == "2")
            {
                Console.WriteLine("The value is False");
            }
            else if (boolanswer == "3")
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid Value, try again? 1. Yes 2. No");
                string tryagain3 = Console.ReadLine();
                if (tryagain3 != "1") break;
            }
        }
    }
}
