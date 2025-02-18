using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            int divisors = 0;

            for(int i= 1; i<= number; i++)
            {
                if(number % i == 0)
                {
                    divisors++;

                }
            }
            if(divisors == 2)
            {
                Console.Write("this is prime number");
            }
            else
            {
                Console.Write("this is not a prime number");
            }



        }
    }
}
