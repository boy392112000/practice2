using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    internal class Judge
    {
        public static bool IsPrime(int value)
        {//判斷是不是質數若value < 2, 傳回false

            bool result = true;
            
            for (var i = 2; i <= value; i++)
            {
                if (value % i == 0 && value != i)
                {
                    result = false;
                }
               
            }

           return result;
        }
    }
}
