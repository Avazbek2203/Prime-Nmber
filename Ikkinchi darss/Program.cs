using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool isNumber;
        do
        {
            Console.Write(" Enter a number : ");
            isNumber = int.TryParse(Console.ReadLine(), out number);
            if (!isNumber)
            {
                Console.WriteLine("Please, input only number!");
            }
        } while (!isNumber);

        if (number > 1)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
        else
        {
            Console.WriteLine(number + "  is not a prime number.");
        }
    }
}



