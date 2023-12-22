using System;

namespace ConsoleApp02
{
    internal class Program
    {
        public static void Task1() // Напишите программу, которая проверяет, делится ли введенное число на 3.
        {
            Console.Write("Enter a number:\n>");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0)
                Console.WriteLine($"{num} is divisible by 3");
            else { Console.WriteLine($"{num} is not divisible by 3"); }
        }

        public static void Task2() // Напишите программу, которая проверяет, удовлетворяет ли введенное пользователем число следующим критериям: при делении на 5 в остатке получается 2, а при делении на 7 в остатке получается 1.
        {
            Console.Write("Enter a number:\n>");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number % 5 == 2) && (number % 7 == 1)) // examples: 22, 57, 92
                Console.WriteLine($"{number} satisfy the conditions of the problem");
            else { Console.WriteLine($"{number} doesn't satisfy the conditions of the problem"); }
        }

        public static void Task3() // Напишите программу, которая проверяет, сколько тысяч во введенном пользователем числе (определяется четвертая цифра слева в 10-ном представлении числа).
        {
            Console.Write("Enter a number:\n>");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = input;
            for (int i = 0; i < 3; i++)
            {
                output /= 10;
            }
            output = output % 10;
            Console.WriteLine($"Result: {output}");
        }

        public static void Task4() // Напишите программу, которая проверяет, удовлетворяет ли введенное пользователем число в диапазон от 5 до 10 включительно.
        {
            Console.Write("Enter a number:\n>");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num > 4) && (num < 11))
                Console.WriteLine($"{num} is in range of 5 - 10");
            else
            {
                Console.WriteLine($"{num} is not in range of 5 - 10");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Select Task [1] - [4]:\n>");
            string? input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);
                switch (num)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    default:
                        Console.WriteLine($"Entered \"{num}\" - out of range 1 to 4");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
        }
    }
}