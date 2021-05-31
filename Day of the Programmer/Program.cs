using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_the_Programmer
{
    class Program
    {
        /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     * 1998
     * 2017
     * 1880
     * YEar
     */

        public static string dayOfProgrammer(int year)
        {
            int day = 0;
            string month = "09";
            if(year == 1918)
            {
                day = 26;
            }
            else if((year % 4 == 0) && (year < 1918 || year % 400 == 0 || year % 100 != 0))
            {
                day = (256) - (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31);

            }
            else
            {
                day = 13;

            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat(@"{0}.{1}.{2}",day,month,year);
            return stringBuilder.ToString();
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Program.dayOfProgrammer(year);

            Console.WriteLine(result);

        }
    }
}
