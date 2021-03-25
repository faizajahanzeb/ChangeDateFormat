using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp10
{
    class Program
    {
        public static List<string> ChangeDateFormat(List<string> dates)
        {
            List<string> newdates = new List<string>();

            string[] patterns = { "yyyy-dd-MM", "yyyy-MM-dd", "yyyy/dd/MM", "yyyy/MM/dd", "dd/MM/yyyy", "MM/dd/yyyy", "dd-MM-yyyy", "MM-dd-yyyy" };
            DateTime parsedDate;

            foreach (var dateValue in dates)
            {
                foreach (var pattern in patterns)
                {
                    if (DateTime.TryParseExact(dateValue, pattern, null,
                                              DateTimeStyles.None, out parsedDate))
                    {
                        //Console.WriteLine("Converted '{0}' to {1:d}.", dateValue, parsedDate);
                        newdates.Add(parsedDate.ToString("yyyyMMdd"));
                    }
                 
                }
            }
            return newdates;
           
        }
        static void Main(string[] args)
        {
            var input = new List<string> { "2010/03/30", "15/12/2016", "11-15-2012", "20130720", "30-12-2011", "12-30-2011", "12/30/2011","2010-03-30",  "15/12/2016", "2010/30/03", "2010-30-03",
                              "30-12-11", "12-30-11" };
             ChangeDateFormat(input).ForEach(Console.WriteLine);
                              
            Console.ReadKey();
        }
    }
}
