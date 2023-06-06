using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Date_Calculation
{
    internal class LeapYear
    {

        public static bool isLeapYear(DateTime value)
        { // todo
            var result = false;


            if (value.Year % 400 == 0 || value.Year % 4 == 0 && value.Year % 100 != 0)
            {
                result = true;
            }


            return result;
        }
        //今年第一個星期日
        public static DateTime FirstSunday(DateTime value)
        {
            DateTime getdate = new DateTime(value.Year, 1, 1);
            DayOfWeek dayOfWeek = getdate.DayOfWeek;

            if (dayOfWeek != DayOfWeek.Sunday)
            {
                int daysUntilFirstSunday = (7 - (int)dayOfWeek + 1) % 7; //不看GPT真想不到的算式@@
                return getdate.AddDays(daysUntilFirstSunday);
            }

            return getdate;
        }

        // 取得某日期之後的第一個星期日
        public static DateTime GetNextSunday(DateTime value)
        {
            DayOfWeek dayOfWeek = value.DayOfWeek;

            if (dayOfWeek != DayOfWeek.Sunday)
            {
                int valueNextSunday = (7 - (int)dayOfWeek) ;
                return value.AddDays(valueNextSunday);
            }

            return value;
        }
        //一年有多少個星期日  
        public static int GetAllSunday(DateTime value)
        {
            
            DateTime getdate = new DateTime(value.Year, 1, 1);
            var count = 0; 
            var Calculate = GetNextSunday(getdate);

            var Target = getdate.AddYears(1); 
            while (Calculate < Target)
            {
                Calculate = GetNextSunday(Calculate.AddDays(7));
                
                count++;

            }

            return count;
        }

        //計算兩個日期相距多少天(有小數點)
        public static double CountdownDays(DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate - startDate;
            return difference.TotalDays;
        }
        //計算兩個日期相距多少小時(有小數點)
        public static double Countdownhours(DateTime startDate, DateTime endDate)
        {
            TimeSpan difference = endDate - startDate;
            return difference.TotalHours;
        }

        // 刪除 DateTime 的秒和毫秒
        public static DateTime DeleteSeconds(DateTime value)
        {
            return value.AddMilliseconds(-value.Millisecond).AddSeconds(-value.Second); 
            
        }
    }
}
