using System;

namespace FactorialOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to factor");
            numberFactor();
            
            void numberFactor()
            {
                try
                {
                    ulong number = Convert.ToUInt64(Console.ReadLine());
                    for (ulong i = number - 1; i > 0; i--)
                    {
                        number *= i;
                    }
                    Console.WriteLine(number);
                }catch(Exception)
                {
                    Console.WriteLine("You need to enter a number");
                    numberFactor();
                }
            }
        }
    }
}
