using System;

namespace CodeJam {
 class ACGT {
  int MinChanges(int maxPeriod, string[] acgt) {
   string s = "";
   for (int i = 0; i < acgt.length; i++) {
    s += acgt[i];
   }
   string look = "ACGT";
   int ret = int.MaxValue;
   for (int p = 1; p <= maxPeriod; p++) {
    int tmp = 0;
    for (int i = 0; i < p; i++) {
     int[] cnt = new int[4];
     int tot = 0;
     for (int j = i; j < s.Length; j += p) {
      char c = s[j];
      Console.WriteLine("charAt(" + j + ") p = " + p + " c = " + c);
      cnt[look.IndexOf(c)]++;
      tot++;
     }
     int cur = int.MaxValue;
     for (int j = 0; j < cnt.Length; j++) {
      cur = min(cur, tot - cnt[j]);
     }
     tmp += cur;
    }
    ret = min(ret, tmp);
   }
   return ret;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   ACGT aCGT = new ACGT();
   String input = Console.ReadLine();
   do {
    var inputParts = input.Split('|');
    int maxPeriod = int.Parse(inputParts[0]);
    string[] acgt = inputParts[1].Split(',');
    Console.WriteLine(aCGT.MinChanges(maxPeriod, acgt));
    input = Console.ReadLine();
   } while (input != "-1");
  }
  #endregion
 }
}