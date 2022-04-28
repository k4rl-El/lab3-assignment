using System.ComponentModel.DataAnnotations;
using System;

namespace lab3_assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            // lab3 question: write a c# program to check prime number
            Console.WriteLine("input the number you would like to check");
            int prime_number =  int.Parse(Console.ReadLine());
            bool is_prime = true;
            for(int i = 2; i < prime_number/2; i++ )
            {
                if (prime_number % i == 0)
                {
                   is_prime = false;
                }
            }

            if (is_prime == true )
            {
                Console.WriteLine(prime_number + " is a prime number");
            }
            else
            {
                Console.WriteLine(prime_number + " is not a prime number");
            }


           
        

        }
    }
}
