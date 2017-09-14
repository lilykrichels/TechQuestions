using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech
{
    class Program
    {

        public int LargestNumber(int[] numArray)
        {

            // Make a method that consists of an array of integers, and then prints out the largest int that that array
            int max = 0;
            foreach (int number in numArray)
            {
                if (max < number)
                {
                    max = number; 
                }
             
            }
            return max; 
        }   

        //make an method that takes in a word and then prints it in reverse without using the reverse mehod 



        static void Main(string[] args)
        {
            //int x = 1;
            //int y = x;
            //x = 10;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Customer customer1 = new Customer(25);
            //Customer customer2 = customer1;

            //Console.WriteLine(customer1.age);
            //customer2.age = 30;
            //Console.WriteLine(customer1.age);
            //Console.WriteLine(customer2.age);

            //Prin ou all of the prime numbers between 1 and 100 to the Console. 
            //bool isPrime = true;

            //for (int i = 2; i <= 100; i++)
            //{
            //    for (int j = 2; j < 100; j++)
            //    {
            //        if (i != j && i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(i + ", ");
            //    }

            //    isPrime = true;
            //} 

            





            

        }
    }
}
