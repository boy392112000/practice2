using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYear leapYear = new LeapYear();
            //DateTime dateTime = DateTime.Now;
            //DateTime dateTimetoday = DateTime.Today;
            //DateTime date = new DateTime(2023,5,31);
            //DateTime date2 = new DateTime(1980, 03, 28,10,30,00);


            ////日期加減
            //var add = -1;
            //var a = date.AddDays(add);

            ////小時加減
            //var b = date.AddHours(add);
            ////月份加減
            //var c = date.AddMonths(add);
            //var cd = date.Year;

            //<--閏年的判斷-->
            Console.WriteLine("請輸入日期（yyyy/MM/dd）：");
            string userInput = Console.ReadLine();

            DateTime date;
            bool isValidDate = DateTime.TryParse(userInput, out date);

            if (isValidDate)
            {
                bool isLeapYear = LeapYear.isLeapYear(date);
                Console.WriteLine(userInput + " :" + isLeapYear);
            }
            else
            {
                Console.WriteLine("請輸入正確日期!");
            }


            //<--星期幾判斷-->

            DayOfWeek dayOfWeek = date.DayOfWeek;
            Console.WriteLine(dayOfWeek);

            //<--判斷當年度 1/1號的第一個星期日是幾號-->

            Console.WriteLine(LeapYear.FirstSunday(date).ToString("yyyy/MM/dd"));

            //<--判斷用戶給的最近期禮拜日-->

            Console.WriteLine(LeapYear.GetNextSunday(date).ToString("yyyy/MM/dd"));

            //<--列出某一年的所有星期日-->



        }
    }
}
