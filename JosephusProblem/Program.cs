using System;
using System.Collections.Generic;
using System.Linq;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            void LastPersonStanding(int numberOfPeople, int killingInterval)
            {
                IEnumerable<int> numRange = Enumerable.Range(1, numberOfPeople);

                Console.WriteLine("The Beginning");
                Console.WriteLine($"we are starting with {numberOfPeople} people.");
                Console.WriteLine($"The killing interval is {killingInterval}.");
                Console.WriteLine("___________________");
                Console.WriteLine("");

                foreach (int num in numRange)
                {
                    Console.WriteLine(num);
                }

                List<int> rangeList = numRange.ToList();

                Console.WriteLine("");
                int peopleLeft = rangeList.Count;
                var indexOfInterval = rangeList[killingInterval] - 2;

                while (peopleLeft >= killingInterval)
                {
                    var roundNum = 0;
                    roundNum++;

                    rangeList.RemoveAt(indexOfInterval);

                    Console.WriteLine($"Round {roundNum}");
                    Console.WriteLine("___________________");
                    Console.WriteLine("");

                    foreach (int num in rangeList)
                    {
                        Console.WriteLine(num);
                    }
                    Console.WriteLine($"There are only {peopleLeft} people left.");
                    Console.ReadLine();
                }
                    Console.ReadLine();
            }

            LastPersonStanding(10, 3);
        }
    }
}
