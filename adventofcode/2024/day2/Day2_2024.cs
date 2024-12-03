using adventofcode.Common;
using System.Collections;
using System.Collections.Generic;


namespace adventofcode
{
    public class Day2_2024 : Day
    {
        

        public Day2_2024() : base(2,2024)
        {
            
        }

        private bool CheckLevel(List<int> level)
        {
            int unsafelevelnum = 0;
            bool increasing = level[1] - level[0] > 0 ? true : false;
            for (int j = 1; j < level.Count; j++)
            {
                int difference = level[j] - level[j - 1];

                if (increasing && difference < 0)
                {
                    return false;
                }

                if (!increasing && difference > 0)
                {
                    return false;
                }

                if (difference > 3 || difference < -3 || difference == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckLevelRemoved(List<int> level)
        {
            for (int i = 0;i < level.Count; i++)
            {
                List<int> levelcopy = new List<int>(level);
                levelcopy.RemoveAt(i);
                if (CheckLevel(levelcopy))
                {
                    return true;
                }
            }
            return false;
        }
        override public string Part1()
        {
            List<List<int>> list1 = new List<List<int>>();
            int total = 0;
            foreach (string s in strContent)
            {
                string[] rawint = s.Split(' ');
                List<int> row = new List<int>();
                foreach (string s2 in rawint)
                {
                    row.Add(Int32.Parse(s2));
                }
                list1.Add(row);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (CheckLevel(list1[i]))
                {
                    total += 1;
                }
            }

            return total.ToString();
        }

        override public string Part2()
        {
            List<List<int>> levels = new List<List<int>>();
            int total = 0;
            foreach (string s in strContent)
            {
                string[] rawint = s.Split(' ');
                List<int> row = new List<int>();
                foreach (string s2 in rawint)
                {
                    row.Add(Int32.Parse(s2));
                }
                levels.Add(row);
            }

            for (int i = 0; i < levels.Count; i++)
            {
                if (CheckLevel(levels[i]))
                {
                    total += 1;
                }
                else
                {
                    
                    if (CheckLevelRemoved(levels[i]))
                    {
                        total += 1;
                    }

                }
            }

            return total.ToString();
        }


    }
}