namespace Assignment_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculations = true;

            while (continueCalculations)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    continueCalculations = false;
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"The difference between {num1} and {num2} is: {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"The difference between {num1} and {num2} is: {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"The product of {num1} and {num2} is: {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"The division of {num1} by {num2} is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.Write("Do you want to perform another calculation? (y/n): ");
                char continueChoice = Convert.ToChar(Console.ReadLine().ToLower());

                if (continueChoice != 'y')
                {
                    continueCalculations = false;
                }
            }
            Console.WriteLine("Thank you for using the calculator. Goodbye!");
        }
    }
}
