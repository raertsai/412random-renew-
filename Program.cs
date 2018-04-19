
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412class
{
    class Program
    {
        static void Main(string[] args)
        {
            // put each number into "list" 
            List<int> numbers = new List <int>();

            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }
            // product six random number
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                // print any number at random
                int r = rand.Next(1, numbers.Count);// numbers.count-->因為list的總數變少
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(numbers[r]+" ");
               
                // and delete the number printed from "list"
                numbers.RemoveAt(r);
            }

            Console.ReadLine();
        }
    }
}
