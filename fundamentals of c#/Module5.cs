using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
        int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            //int result = Random.Next();
            dice.Next(1, 7);
            Console.WriteLine(roll);
            int number = 7;
            string text = "seven";
            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);
            roll1 = dice.Next();
            roll2 = dice.Next(101);
            roll3 = dice.Next(50, 101);
            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            //Console.WriteLine(largerValue);
            firstValue = 500;
            secondValue = 600;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);
}
