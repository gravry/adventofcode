using adventofcode.Common;

namespace adventofcode
{
    public class Day2_2023 : Day
    {

        public Day2_2023() : base(2, 2023)
        {

        }

        override public string Part1()
        {
            var sum = 0;
            var i = 0;

            foreach (var line in strContent)
            {
                i++;
                var gamesString = line.Split(":")[1].Split(";");
                if (gamesString.Length > 0)
                {
                    var gameValid = true;
                    foreach (var game in gamesString)
                    {
                        var blocks = game.Split(", ");

                        foreach (var block in blocks)
                        {
                            var subBlock = block.Trim().Split(" ");
                            if (subBlock[1] == "red")
                            {
                                if (Int32.Parse(subBlock[0]) > 12)
                                {
                                    gameValid = false;
                                }
                            }
                            else if (subBlock[1] == "green")
                            {
                                if (Int32.Parse(subBlock[0]) > 13)
                                {
                                    gameValid = false;
                                }
                            }
                            else if (subBlock[1] == "blue")
                            {
                                if (Int32.Parse(subBlock[0]) > 14)
                                {
                                    gameValid = false;
                                }
                            }
                        }
                    }
                    if (gameValid)
                    {
                        sum += i;
                    }
                }

            }

            return sum.ToString();
        }

        override public string Part2()
        {
            var sum = 0;
            var i = 0;

            foreach (var line in strContent)
            {
                i++;
                var gamesString = line.Split(":")[1].Split(";");
                if (gamesString.Length > 0)
                {
                    var redBlocks = 0;
                    var blueBlocks = 0;
                    var greenBlocks = 0;
                    foreach (var game in gamesString)
                    {
                        var blocks = game.Split(", ");

                        foreach (var block in blocks)
                        {
                            var subBlock = block.Trim().Split(" ");

                            if (subBlock[1] == "red")
                            {
                                if (Int32.Parse(subBlock[0]) > redBlocks) redBlocks = Int32.Parse(subBlock[0]);
                            }
                            else if (subBlock[1] == "green")
                            {
                                if (Int32.Parse(subBlock[0]) > greenBlocks) greenBlocks = Int32.Parse(subBlock[0]);
                            }
                            else if (subBlock[1] == "blue")
                            {
                                if (Int32.Parse(subBlock[0]) > blueBlocks) blueBlocks = Int32.Parse(subBlock[0]);
                            }
                        }

                    }
                    var power = redBlocks * blueBlocks * greenBlocks;
                    sum += power;
                }

            }

            return sum.ToString();
        }
    }
}