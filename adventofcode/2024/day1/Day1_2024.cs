using adventofcode.Common;
using System.Collections;
using System.Collections.Generic;


namespace adventofcode
{
    public class Day1_2024 : Day
    {
        

        public Day1_2024() : base(1,2024)
        {
            
        }
        override public string Part1()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int total = 0;
            foreach (string s in strContent)
            {
                string[] rawint = s.Split(' ');
                list1.Add(Int32.Parse(rawint[0]));
                list2.Add(Int32.Parse(rawint[3]));
            }

            list1.Sort();
            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                total += Math.Abs(list1[i] - list2[i]);
            }

            return total.ToString();
        }

        override public string Part2()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            int total = 0;
            foreach (string s in strContent)
            {
                string[] rawint = s.Split(' ');
                list1.Add(Int32.Parse(rawint[0]));
                list2.Add(Int32.Parse(rawint[3]));
            }

            list1.Sort();
            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                total += list2.Count(x => x == list1[i]) * i;
            }

            return total.ToString();
        }


    }
}