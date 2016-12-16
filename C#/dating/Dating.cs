using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class Dating {
  String Dates(String circle, int k) {
   string res = "";
   int t = 0;
   do {
    if (circle.Length == 0) break;
    int p1 = (t + k - 1) % circle.Length, p2 = find(circle[p1], circle);
    if (p2 == -1) break;
    res += "" + circle[p1] + "" + circle[p2] + " ";
    t = p1;
    for (int tx = 0; tx < 100; tx++) {
     t = (t + 1) % circle.Length;
     if (t != p1 && t != p2) break;
    }
    char cc = circle[t];
    string s1 = "";
    for (int i = 0; i < circle.Length; i++)
     if (i != p1 && i != p2) s1 += circle[i];
    circle = s1;
    t = circle.IndexOf(cc);
   } while (true);
   return res.Trim();
  }

  int find(char c, string circle) {
   if (c >= 'a' && c <= 'z') {
    for (char cc = 'A'; cc <= 'Z'; cc++)
     if (circle.IndexOf(cc) >= 0) return circle.IndexOf(cc);
   } else {
    for (char cc = 'a'; cc <= 'z'; cc++)
     if (circle.IndexOf(cc) >= 0) return circle.IndexOf(cc);
   }
   return -1;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   Dating dating = new Dating();

   do {
    string[] values = input.Split(',');
    Console.WriteLine(dating.Dates(values[0], Int32.Parse(values[1])));
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}