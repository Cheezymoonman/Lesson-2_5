using System;

namespace Lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Value for first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value of second number:");
            number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 * number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            double result2 = (double)number1 / (double)number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result2);


            string name1;

            Console.WriteLine("Enter your name:");
            name1 = (Console.ReadLine());

            string greeting = "Hello" + " " + name1 + "!";
            Console.WriteLine(greeting);

            
            int number3;
            int number4;
            int number5;

            Console.WriteLine("Value of first number:");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value of second number:");
            number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value of third number:");
            number5 = int.Parse(Console.ReadLine());

            int result3 = number3 * number4 * number5;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result3);


            string age;

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            string age2 = "You look younger than" + " " + age + "!";
            Console.WriteLine(age2);
        }
    }
}
