using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Common
{
    public static class Processor
    {
        internal static List<string> GetContent(string content)
        {
            List<string> strContent = new List<string>();
            using (var reader = new StreamReader(content))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine() ?? string.Empty;
                    strContent.Add(line);
                }
            }
            return strContent;
        }
        public static void RunSolve()
        {
            //Day1_2023 day1 = new Day1_2023();
            //day1.Solve();

            //Day2_2023 day2 = new Day2_2023();
            //day2.Solve();

            //Day1_2024 day12024 = new Day1_2024();
            //day12024.Solve();

            Day2_2024 day22024 = new Day2_2024();
            day22024.Solve();


        }

    }
}