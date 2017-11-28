using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwC.Shop.ConsoleClient.Extensions
{
    class DateTimeHelper
    {

        public static bool IsHoliday(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday
                || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
    }

    public static class DateTimeExtensions
    {
        public static bool IsHoliday(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday
                || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        public static DateTime AddWorkingDays(this DateTime dateTime, byte days)
        {
            return dateTime.AddDays(days);
        }
    }

}
