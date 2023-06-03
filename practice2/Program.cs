using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 197; // 要判断的数

            if (Judge.IsPrime(number))
                Console.WriteLine(number + " 是質數");
            else
                Console.WriteLine(number + " 不是質數");
        }
    }
}
