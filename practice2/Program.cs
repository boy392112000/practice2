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

            int number = 0; // 要判斷的數

            for(int i = 1; i <999; i++)
            {
                number = i;
                if (Judge.IsPrime(number))
                    Console.WriteLine(number + " 是質數");
                else
                    Console.WriteLine(number + " 不是質數");
            }
            
        }
    }
}
