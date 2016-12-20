using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class PalindromeMaker {
  String Make(String baseString) {
   char[] c = baseString.ToCharArray();
   Array.Sort(c);
   int n = c.Length;
   int oc = 0;
   char mc = 0;
   int[] cnt = new int[26];
   for (int i = 0; i < n; i++) {
    if (cnt[c[i] - 'A'] != 0) {
     continue;
    }
    int cc = 0;
    for (int j = 0; j < n; j++) {
     if (c[i] == c[j]) {
      cc++;
     }
    }
    if (cc % 2 == 1) {
     oc++;
     mc = c[i];
    }
    cnt[c[i] - 'A'] = cc;
   }
   if (oc > 1) {
    return "";
   }
   string r = "";
   for (int i = 0; i < 26; i++) {
    for (int j = 0; j < cnt[i] / 2; j++) {
     r += (char)('A' + i);
    }
   }
   if (oc == 1) {
    r += mc;
   }
   for (int i = 25; i >= 0; i--) {
    for (int j = 0; j < cnt[i] / 2; j++) {
     r += (char)('A' + i);
    }
   }
   return r;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   PalindromeMaker palindromeMaker = new PalindromeMaker();
   do {
    Console.WriteLine(palindromeMaker.Make(input));
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}