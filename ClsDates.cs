using System;

namespace Dates
{
    public class ClsDates
    {
        public static Int32 Date2Julian (string in_date)
        {
            Int32 Year, Month, Day;
            Int32 a, m, y, nDate;

            Day = Convert.ToInt32(in_date.Substring(0, 2));
            Month = Convert.ToInt32(in_date.Substring(3, 2));
            Year = Convert.ToInt32(in_date.Substring(6, 4));

            a = (14 - Month) / 12;
            m = Month + 12 * a - 3;
            y = Year + 4800 - a;

            nDate = Day + ((153 * m) + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;

            return (nDate);
        }

        public static string Julian2Date (Int32 in_julian)
        {
            Int32 a, b, c, d, e, m;
            Int32 Day, Month, Year;

            a = in_julian + 32044;
            b = (4 * a + 3) / 146097;
            c = a - 146097 * b / 4;
            d = (4 * c + 3) * 1461;
            e = c - 1461 * d / 4;
            m = (5 * e + 2) / 153;

            Day = e - ((153 * m + 2) / 5) + 1;
            Month = m + 3 - 12 * (m / 10);
            Year = 100 * b + d - 4800 + m / 10;

            return (Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString());   

            //return new DateTime(Year, Month, Day);
        }

        public static Int16 DayInWeek(string in_date)
        {
            Int32 Year, Month, Day;

            Day = Convert.ToInt32(in_date.Substring(0, 2));
            Month = Convert.ToInt32(in_date.Substring(3, 2));
            Year = Convert.ToInt32(in_date.Substring(6, 4));

            DateTime dateValue = new DateTime(Year, Month, Day);
            return (Int16) dateValue.DayOfWeek;
        }

        public static DateTime GetOrthodoxEaster(int year)
        {
            var a = year % 19;
            var b = year % 7;
            var c = year % 4;

            var d = (19 * a + 16) % 30;
            var e = (2 * c + 4 * b + 6 * d) % 7;
            var f = (19 * a + 16) % 30;

            var key = f + e + 3;
            var month = (key > 30) ? 5 : 4;
            var day = (key > 30) ? key - 30 : key;

            return new DateTime(year, month, day);
        }
    }
}
