using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            List<int> numbers = new List<int>();    //Create a List called "numbers"


            var index = 0;   //Create a variable (index of type int with an initializer of 0
            do      // Create a do-while loop
            {                index++;    // Increment your variable by 1
                numbers.Add(index);  // Then add your variable to "numbers"

            } while (index < 100); // While your variable (index) is less than 100



            // Create a while loop
            while (index < 200)   // While your variable is less than 200
            {                index += 1;    // Increment your variable by 1
                numbers.Add(index);    // Then add your variable to "numbers"
            }



            Console.WriteLine("Increase:");



            // Create a foreach loop
            // Write your variable to the console
            foreach (int number in numbers)            {                Console.WriteLine(number);            }            Console.WriteLine("");            Console.WriteLine("Decrease:");



            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i > 0; i--)            {                Console.WriteLine($"The number {numbers[i]} is at the {i} index");   // Write to the console "numbers" at index i
            }
        }
    }
}
