using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Codejam
{
    class TimeZone
    {

        public string GetTime(string time)
        {
            string mstring = time.Substring(3, 2);
            string hstring = time.Substring(0, 2);
            string gstring = time.Substring(9, 2);
            int min = 24 * 60;
            for (int h = 0; h < 24; h++)
            {
                if (hstring[0] != '?' && hstring[0] - '0' != h / 10)
                    continue;
                if (hstring[1] != '?' && hstring[1] - '0' != h % 10)
                    continue;
                for (int m = 0; m < 60; m++)
                {
                    if (mstring[0] != '?' && mstring[0] - '0' != m / 10)
                        continue;
                    if (mstring[1] != '?' && mstring[1] - '0' != m % 10)
                        continue;
                    for (int g = -9; g < 10; g++)
                    {
                        if (gstring[0] != '?' && (gstring[0] == '-' ^ g < 0))
                            continue;
                        if (gstring[1] != '?' && gstring[1] - '0' != Math.Abs(g))
                            continue;

                        min = Math.Min(min, ((h + 24 - g) % 24) * 60 + m);
                    }
                }
            }
            return string.Format("{0:00}:{1:00}", min / 60, min % 60);
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TimeZone timeZone = new TimeZone();
            do
            {
                string validationOp = timeZone.GetTime(input);
                Console.WriteLine(validationOp);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

