using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate 50 random numbers to be called out
            Random randNum = new Random();
            int[] bingoNum = Enumerable
                .Repeat(0, 50)
                .Select(i => randNum.Next(1, 50))
                .ToArray();
            Console.WriteLine(bingoNum);
            foreach (var entry in bingoNum)
            {
                Console.WriteLine("The chosen number is " + entry);
            }

            //Player chooses their numbers
            List<int> arr = new List<int>();
            Console.WriteLine("Choose your the numbers");
            for (int i = 0; i < 5; i++)
                arr.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine(" Your numbers are \n");
            foreach (int v in arr)
                Console.WriteLine("{0}\n", v);
            int[] playerNums = arr.ToArray();


            //Match player number with chosen numbers
bourner            for (int i = 0; i < bingoNum.Length; i++)
            {
                for (int j = 0; j < playerNums.Length; j++)
                {
                    if (bingoNum[i] == playerNums[j])
                    {
                        Console.WriteLine(bingoNum[i] + " is a match");
                    }
                }
            }

            //Bingo is declared if 5 cards match

        }

    }
}


