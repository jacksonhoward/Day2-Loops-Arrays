using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Practice_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleIt(21);
            Console.WriteLine(DoubleIt(myAgeDoubled));
            
            //LoopTests();
            VowelCounter2014Tests();
            //Keeos the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Writes "Hello World!" to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static int DoubleIt(int anyNumber)
        {
            return anyNumber * 2;
        }
        /// <summary>
        /// Prints numbers to console from start to end by (i)criments of 1
        /// </summary>
        /// <param name="startNumber">number the loop starts at</param>
        /// <param name="endNumber">Inclusive end point of loop</param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for(int i = startNumber; i <= endNumber; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Runs a series of test for the LoopSomeNumber function
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5, 10);
            LoopSomeNumbers(865, 900);
            LoopSomeNumbers(21, DoubleIt(21));
        }
        /// <summary>
        /// Returns number of vowels in any given string
        /// </summary>
        /// <param name="inpputString">A string that you want to count out the number of vowels</param>
        /// <returns>The number of vowels found</returns>
        static int VowelCounter2014(string inputString)
        {
        //Declare a counter for the vowels
            int numberOfVowelsFound = 0;

            //Loop over each letter of string
            for (int i = 0; i < inputString.Length; i = i + 1)
            {
                string letter = inputString[i].ToString().ToLower();

                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    //Found a vowel
                    numberOfVowelsFound = numberOfVowelsFound + 1;

                }
                if ("aeiou".Contains(letter)) { }
                //loop Complete, tine to write to console
            }
            Console.WriteLine(inputString = " has " + numberOfVowelsFound + " vowels in it ");
            return numberOfVowelsFound;
        }
        static void VowelCounter2014Tests()
        {
            //Count the number of vowels counted
            int totalNumberofVowelsCounted = 0;
            totalNumberofVowelsCounted += VowelCounter2014("Jackie seems like a guy who likes Nickleback");
            totalNumberofVowelsCounted += VowelCounter2014("I like to eat nachos");
            Console.WriteLine("Total vowels Counted:" + totalNumberofVowelsCounted);
        }
    }
}
