using System;

namespace BDDprovaautomacao.utils
{
        public static class DateUtils
        {
            public static String DateWithoutSlashes()
            {
                DateTime now = DateTime.Now;
                return String.Format("{0:ddMMyyyyHHmmss}", now);
            }

            public static String DateNowWithDot()
            {
                DateTime now = DateTime.Now;
                return String.Format("{0:dd.MM.yyyy}", now);
            }

            public static String DateNowWithDotMoreDays(double days)
            {
                DateTime now = DateTime.Now;
                return String.Format("{0:dd.MM.yyyy}", now.AddDays(days));
            }
        }
}