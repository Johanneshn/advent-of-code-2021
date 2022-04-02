namespace AdventOfCode.Days
{
    internal class Day3 : IDay
    {
        private readonly List<string> _entries;

        public Day3()
        {
             _entries = Common.ReadFile("day3.txt").ToList();
        }

        public void GetResult()
        {
            Console.WriteLine($"Part 1: {GetResultPart1()}, Part 2: {GetResultPart2()}");
        }

        int GetResultPart1()
        {
            
            int[] signals = new int[_entries[0].Length];
            foreach (string line in _entries)
            {
                for (int j = 0; j < line.Length; j++)
                    signals[j] += line[j] == '1' ? 1 : 0;
            }

            var gamma = new string(signals.Select(b => b > _entries.Count / 2 ? '1' : '0').ToArray());
            var epsilon = new string(signals.Select(b => b < _entries.Count / 2 ? '1' : '0').ToArray());
            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }

        int GetResultPart2()
        {
            var o2 = Filter(_entries, 0, (a, b) => { return a >= b ? '1' : '0'; });
            var co2 = Filter(_entries, 0, (a, b) => { return a < b ? '1' : '0'; });

            return Convert.ToInt32(o2, 2) * Convert.ToInt32(co2, 2);
        }

        private string Filter(List<string> lines, int position, Func<int, int, char> f)
        {

            if (lines.Count == 1)
            {
                return lines[0];
            }

            int ones = lines.Where(line => line[position] == '1').Count();
            int zeroes = lines.Count - ones;
            char seeking = f(ones, zeroes);
            var keep = lines.Where(l => l[position] == seeking).ToList();

            return Filter(keep, position + 1, f);
        }
    }
}
