namespace AdventOfCode.Days
{
    internal class Day1 : IDay
    {
        private readonly int[] _inputs;
   
        public Day1() 
        {
            _inputs = Common.ReadFile("day1.txt").Select(x => Int32.Parse(x)).ToArray();
        }

        public void GetResult()
        {
            Console.WriteLine($"Part 1: {GetResultPart1()}, Part 2: {GetResultPart2()}");
        }

        int Increases(int[] values)
        {
            return _inputs.Select((x, i) => i < values.Length - 1 && values[i] < values[i + 1]).Count(x => x);
        }

        int GetResultPart1()
        {
            return Increases(_inputs);
        }

        int GetResultPart2()
        {
            var grouped = new int[_inputs.Length - 2];
            for (int i = 0; i < _inputs.Length - 2; i++)
            {
                grouped[i] = _inputs[i] + _inputs[i + 1] + _inputs[i + 2];
            }

            return Increases(grouped);
        }

    }
}
