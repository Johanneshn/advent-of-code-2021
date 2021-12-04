using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
     class Common
    {

        public static string[] ReadFile(string filename)
        {
            return File.ReadLines($@"inputs/{filename}").ToArray();
        }
    }
}
