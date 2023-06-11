using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Loop_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //撰寫一個可以循環取得 int 的函數
            var generator = new NumberGenerator(0, 3); // 依序傳回 0-3
            for (int i = 0; i < 6; i++)
            {
                int number = generator.GetNumber(); // 依序傳回0、1、2、3、0、1
                Console.WriteLine(number+",");
            }
        }

        
    }
}
