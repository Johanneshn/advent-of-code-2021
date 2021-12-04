using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    internal class Day2 : IDay
    {
        private readonly List<Tuple<string, int>> _moves;

        public Day2()
        {
            _moves = Common.ReadFile("day2.txt").Select(x =>
            {
                string[] s = x.Split(' ');
                return Tuple.Create(s[0], Int32.Parse(s[1]));
            }).ToList();
        }

        public void GetResult()
        {
            Console.WriteLine($"Part 1: {GetResultPart1()}, Part 2: {GetResultPart2()}");
        }

        int GetResultPart1()
        {
            int horizontal = 0, depth = 0;
            foreach (var item in _moves)
            {
                switch (item.Item1)
                {
                    case "forward":
                        horizontal += item.Item2;
                        break;
                    case "down":
                        depth += item.Item2;
                        break;
                    case "up":
                        depth -= item.Item2;
                        break;

                }
            }

            return horizontal * depth;
        }

        int GetResultPart2()
        {
            int horizontal = 0, depth = 0, aim = 0;
            foreach (var item in _moves)
            {
                switch (item.Item1)
                {
                    case "forward":
                        horizontal += item.Item2;
                        depth += aim * item.Item2;
                        break;
                    case "down":
                        aim += item.Item2;
                        break;
                    case "up":
                        aim -= item.Item2;
                        break;

                }
            }

            return horizontal * depth;
        }





    }
}
