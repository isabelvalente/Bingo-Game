using System;
using System.Collections;
using System.Linq;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randNum = new Random();
            int[] test2 = Enumerable
                .Repeat(0, 25)
                .Select(i => randNum.Next(1, 99))
                .ToArray();
            foreach (var entry in test2)
            {
                Console.WriteLine(entry);
            }
        }
    }
}

