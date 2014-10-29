using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy_Lists_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOverAList();
            LoopOverWordsInAString("Let's see how this works");
            Console.ReadKey();
        }

        static void LoopOverAList()
        {
            //Create a list of sports
            List<string> SportsList = new List<string>() { "Basketball", "PingPong" };
            //Add Football to the list
            SportsList.Add("Football");
            //Loop over the sports list and display all elements
            //that contain the word "ball"
            for (int i = 0; i < SportsList.Count(); i = i + 1)
            {
                //Get the current sport out of the list
                string currentSport = SportsList[i];
                //Check to see if the sport has "ball" in it
                if (currentSport.Contains("ball"))
                {
                    //Its true
                    Console.WriteLine(currentSport);
                }

            }


        }
        static void LoopOverWordsInAString(string inputString)
        {
            List<string> wordList = inputString.Split(' ').ToList();
            for (int i = 0; i < wordList.Count(); i = i + 1)
            {
                Console.WriteLine(wordList[i]);

            }
        }


    }
}
