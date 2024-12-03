using adventofcode.Common;

namespace adventofcode
{
    public class Day1_2023 : Day
    {

        public Day1_2023() : base(1, 2023)
        {

        }
        override public string Part1()
        {
            try
            {
                var sum = 0;
                foreach (var line in strContent)
                {
                    var newline = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (Char.IsDigit(line[i]))
                        {
                            newline += line[i];
                        }
                    }
                    var digits = new string(newline.Where(c => char.IsDigit(c)).ToArray());
                    if (digits != "")
                    {
                        var value = Int32.Parse(digits.Substring(0, 1) + digits.Substring(digits.Length - 1, 1));
                        sum += value;
                    }
                }

                return sum.ToString();

            }
            catch (IOException e)
            {
                return "The file could not be read:" + e.Message;
            }
        }
        override public string Part2()
        {
            try
            {
                var sum = 0;
                foreach (var line in strContent)
                {
                    var newline = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (Char.IsDigit(line[i]))
                        {
                            newline += line[i];
                        }
                        else if (line.Length - i + 1 > 3 && line.Substring(i, 3) == "one")
                        {
                            newline += "1";
                        }
                        else if (line.Length - i + 1 > 3 && line.Substring(i, 3) == "two")
                        {
                            newline += "2";
                        }
                        else if (line.Length - i + 1 > 5 && line.Substring(i, 5) == "three")
                        {
                            newline += "3";
                        }
                        else if (line.Length - i + 1 > 4 && line.Substring(i, 4) == "four")
                        {
                            newline += "4";
                        }
                        else if (line.Length - i + 1 > 4 && line.Substring(i, 4) == "five")
                        {
                            newline += "5";
                        }
                        else if (line.Length - i + 1 > 3 && line.Substring(i, 3) == "six")
                        {
                            newline += "6";
                        }
                        else if (line.Length - i + 1 > 5 && line.Substring(i, 5) == "seven")
                        {
                            newline += "7";
                        }
                        else if (line.Length - i + 1 > 5 && line.Substring(i, 5) == "eight")
                        {
                            newline += "8";
                        }
                        else if (line.Length - i + 1 > 4 && line.Substring(i, 4) == "nine")
                        {
                            newline += "9";
                        }

                    }
                    var digits = new string(newline.Where(c => char.IsDigit(c)).ToArray());
                    if (digits != "")
                    {
                        var value = Int32.Parse(digits.Substring(0, 1) + digits.Substring(digits.Length - 1, 1));
                        sum += value;
                    }
                }

                return sum.ToString();

            }
            catch (IOException e)
            {
                return "The file could not be read:" + e.Message;
            }
        }
    }
}