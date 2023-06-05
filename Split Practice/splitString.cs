using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Practice
{
    internal class splitString
    {
        public string Calculate( string result)
        {
            string[] text = result.Split(',',' ',',');
            string value = string.Empty;

            


            foreach (string s in text) { value += s; }
            
            return value;
        }
    }
}
