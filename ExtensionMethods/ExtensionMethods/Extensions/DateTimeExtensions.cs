using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
    static class DateTimeExtensions
    {

        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24) return duration.TotalHours.ToString("F2") + " hours";
            else return duration.TotalDays.ToString("F1") + " days";

        }

    }
}
