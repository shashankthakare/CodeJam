using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class CardStraights {
  int LongestStraight(int[] cards) {
   Array.Sort(cards);
   int f = 0;
   int n = cards.Length;
   while (f < n && cards[f] == 0) {
    f++;
   }

   int best = f;
   for (int i = f; i < n; i++) {
    for (int j = i; j < n; j++) {
     int t = 0;
     int l = 1;
     for (int k = i + 1; k <= j; k++) {
      if (cards[k - 1] != cards[k]) {
       t += (cards[k] - cards[k - 1] - 1);
       l += cards[k] - cards[k - 1];
      }
     }
     if (t <= f) {
      if (l + (f - t) > best) {
       best = l + f - t;
      }
     }
    }
   }

   return best;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   CardStraights cardStraights = new CardStraights();
   do {
    int[] cards = Array.ConvertAll < string, int > (input.Split(','), delegate(string s) {
     return Int32.Parse(s);
    });
    Console.WriteLine(cardStraights.LongestStraight(cards));
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}