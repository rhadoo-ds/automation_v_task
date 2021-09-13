using System;

namespace VismaTask1.Utils
{
    public static class Config
    {
        public static class URLs
        {
            public static string BaseURL = "http://way2automation.com";
            public static string TestURL = "/way2auto_jquery/automation-practice-site.html";
        }
        public static class DateFormatText
        {
            public static string Default = "Default - mm/dd/yy";
            public static string ISO8601 = "ISO 8601 - yy-mm-dd";
            public static string Short = "Short - d M, y";
            public static string Medium = "Medium - d MM, y";
            public static string Full = "Full - DD, d MM, yy";
            public static string WithText = "With text - 'day' d 'of' MM 'in the year' yy";
        }
        public static class DateFormatValue
        {
            public static string Default = "mm/dd/yy";
            public static string ISO8601 = "yy-mm-dd";
            public static string Short = "d M, y";
            public static string Medium = "d MM, y";
            public static string Full = "DD, d MM, yy";
            public static string WithText = "'day' d 'of' MM 'in the year' yy";
        }
        public static class TodayDate
        {
            public static string ISO8601 = DateTime.Today.ToString("yyyy-MM-dd");
            public static string day = DateTime.Today.ToString("dd");
        }
    }
}
