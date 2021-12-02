namespace AdventOfCode._1
{
    static internal class day1
    {

        private static int[] ReadFile()
        {
            return File.ReadLines(@"1\input-day1.txt").Select((value) => Int32.Parse(value)).ToArray();

        }

        public static int Sum(int[] values)
        {
            int result = 0;
            int? previousValue = null;
            foreach (var value in values)
            {
                if (value > previousValue)
                {
                    result++;
                }
                previousValue = value;
            }

            return result;
        }

        public static void GetResult()
        {
            Console.WriteLine($"Part 1: {GetResultPart1()}, Part 2: {GetResultPart2()}");
        }
        public static int GetResultPart1()
        {
            return Sum(ReadFile());
        }

        public static int GetResultPart2()
        {
            var file = ReadFile();
            var p2 = new int[file.Length - 2];

            for (int i = 0; i < file.Length - 2; i++)
            {
                p2[i] = file[i] + file[i + 1] + file[i + 2];
            }

            return Sum(p2);
        }

    }
}
