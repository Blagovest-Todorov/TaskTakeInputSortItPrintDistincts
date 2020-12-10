using System;
using System.Linq;
using System.Collections.Generic;

namespace _14.TaskShorsWordsSortedusingLinq
{
    class Program
    {
        static void Main(string[] args)
        { 
             // Task 1.Read text , make all to lower Case so to be  case insensitive, take the elements less than 5 symbols, order elements aplhabeticalli, 
             //take only not duplicate elemetns and print them.

            // delimiter --sequence of deviding characters ! , . ; : ?! 
            // In softUni You can study Javba, C#, PHP, and JavaScript. Java and C#  developers graduate in 2-3 years.Go In!

            char[] delimiters = 
                     new char[] { '.', ',', ':', ';','/','\\', '?', '(', ')', '[',']', '"', '\'','!', ' '};  // We make an Char array of bin chars
            string[] words =                                                      // We make qn array of afterworked text after removed delimeters
                     Console.ReadLine()
                     .ToLower()
                     .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);  
            // we take the input to lower case, and split by the given criteria, remove symbols by given criteria
            // StringSplitOptions.RemoveEmptyEntries -> we remose the white space, empty spaces by using this method!!!

            string[] outputWords = words.Where(x => x.Length < 5)  // We take elements less than 5 symbols long and create new array where to store
                                         .OrderBy(x => x)   // we sort by aplhabetically
                                         .Distinct().ToArray(); // We remove copies, ie duplicate element, we take only one copy.and make Array
            Console.WriteLine(string.Join(" ", outputWords));   // print the output using method string.Join();

            // Linq a way make the filtering, we make some checks,  and sorting without using foreach or for loop !!!!
            // Linq is kind of abstract way to do operations.

        }
    }
}
