using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int number, count = 0;
            Console.WriteLine("Write the num to check: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("num is not a prime num");
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("num is a prime num");
            }
            else
            {
                Console.WriteLine("num is not a prime num");
            }
        }
		
    }
}
