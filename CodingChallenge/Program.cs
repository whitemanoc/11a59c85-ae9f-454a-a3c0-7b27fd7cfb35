using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge
{
    public class Program
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("hello world!");
        }

        public string FindSequence(string input)
        {
            var stringSplit = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            List<int> list = new List<int>();
            list.AddRange(stringSplit.Select(x => Convert.ToInt32(x)));
            var largestCount = 0;
            List<int> longestSequence = new List<int>();
            var currentCount = 0;
            List<int> currentSequence = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                currentCount++;
                currentSequence.Add(list[i]);
                Console.WriteLine(list[i]);

                if(i == list.Count - 1)
                {
                    if (largestCount < currentCount)
                    {
                        largestCount = currentCount;
                        longestSequence = currentSequence;
                    }
                    currentCount = 0;
                    currentSequence.Clear();

                    break;
                }
                else if(list[i] > list[i + 1])
                {
                    if( largestCount < currentCount)
                    {
                        largestCount = currentCount;
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentCount = 0;
                    currentSequence.Clear();
                }
            }

            string result = "";
            foreach (int i in longestSequence)
            {
                string number = i.ToString();
                if (i.Equals(longestSequence.Last()))
                {
                    result += number;
                }
                else
                {
                    result += number + " ";
                }
            }
            
            return result;
        }
    }
}
