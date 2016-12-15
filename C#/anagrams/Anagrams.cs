using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class Anagrams {

  public int GetMaximumSubset(string[] S) {
   for (int i = 0; i < S.Length; i++) {
    char[] cs = S[i].ToCharArray();
    Array.Sort(cs);
    string st = "";
    for (int j = 0; j < cs.Length; j++) {
     st += cs[j];
    }
    S[i] = st;
   }
   bool[] map = new bool[S.Length];
   for (int i = 0; i < S.Length; i++) {
    for (int j = i + 1; j < S.Length; j++) {
     if (S[i].Equals(S[j])) {
      map[j] = true;
     }
    }
   }
   int @out = 0;
   for (int i = 0; i < S.Length; i++) {
    if (!map[i]) {
     @out++;
    }
   }
   return @out;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   Anagrams anagramSolver = new Anagrams();
   do {
    string[] words = input.Split(',');
    Console.WriteLine(anagramSolver.GetMaximumSubset(words));
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}