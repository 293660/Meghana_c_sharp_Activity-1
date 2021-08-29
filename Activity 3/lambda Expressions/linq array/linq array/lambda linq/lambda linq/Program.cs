using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vals = { 1, -2, 3, 4, 0, -3, 2, 1, 3 };

            var v1 = Array.FindIndex(vals, x => x == 3);
            Console.WriteLine(v1);

            var v2 = Array.FindLastIndex(vals, x => x == 3);
            Console.WriteLine(v2);

            var positive = Array.FindAll(vals, x => x > 0);
            Console.WriteLine(string.Join(",", positive));
        }
    }
}
