using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Common
{
    public abstract class Day
    {
        public string Name { get; set; }
        public string InputPath { get; set; }

        public List<string> strContent { get; set; }

        public Day(int day, int year)
        {
            Name = $"Day{day} {year}";
            InputPath = $"{year}\\day{day}\\input.txt";
            strContent = Processor.GetContent(InputPath);
        }

        public abstract string Part1();

        public abstract string Part2();

        public void Solve()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Part 1: ");
            Console.WriteLine(Part1());
            Console.WriteLine("Part 2: ");
            Console.WriteLine(Part2());
        }
    }
}
