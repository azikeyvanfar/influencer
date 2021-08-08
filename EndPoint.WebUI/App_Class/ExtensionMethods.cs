using System;
using System.Globalization;

namespace EndPoint.WebUI.App_Class
{
    public static class ExtensionMethods
    {
        public enum PersianDateTimeFormat
        {
            yyyyMMdd,
            yyyyMMddHHmm,
            yyyyMMddHHmmss,
        }

        public static string ToPersian(this DateTime dateTime)
        {
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                string year = persianCalendar.GetYear(dateTime).ToString();
                string month = persianCalendar.GetMonth(dateTime).ToString()
                               .PadLeft(2, '0');
                string day = persianCalendar.GetDayOfMonth(dateTime).ToString()
                               .PadLeft(2, '0');
                string hour = dateTime.Hour.ToString().PadLeft(2, '0');
                string minute = dateTime.Minute.ToString().PadLeft(2, '0');
                string second = dateTime.Second.ToString().PadLeft(2, '0');
                return String.Format("{0}/{1}/{2} {3}:{4}:{5}", year, month, day, hour, minute, second);
            }
            catch
            {

                throw;
            }
        }

        public static string ToPersian(this DateTime dateTime, PersianDateTimeFormat format)
        {
            return dateTime.ToString();
        }
    }
}
