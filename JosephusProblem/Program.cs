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
                Console.WriteLine("");

                var circleOfPeople = new List<int>();

                for (var i = 1; i <= numberOfPeople; i++)
                {
                    circleOfPeople.Add(i);
                }

                int Counter = 1;
                int roundNum = 1;

                do
                {
                    for (var i = 0; i < circleOfPeople.Count; i++)
                    {
                        if (Counter == killingInterval)
                        {
                            circleOfPeople.RemoveAt(0);
                            Counter = 1;
                            Console.WriteLine($"Round {roundNum}");
                            Console.WriteLine("___________________");
                            Console.WriteLine("");
                            roundNum++;
                            foreach(int person in circleOfPeople)
                            {
                                Console.WriteLine(person);
                            }
                            Console.WriteLine("");
                        }
                        else
                        {
                            circleOfPeople.Add(circleOfPeople[0]);
                            circleOfPeople.RemoveAt(0);
                            Counter++;
                            i--;
                        }
                    }
                }
                while (circleOfPeople.Count > 1);
                Console.WriteLine($"The last person standing is in the number {circleOfPeople[0]} position.");
            }
            LastPersonStanding(10, 3);
            Console.ReadLine();
            }
        }
    }
