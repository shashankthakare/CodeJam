using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class FriendScore {
  public int HighestScore(string[] friends) {
   int n = friends.Length;
   int res = 0;
   for (int i = 0; i < n; i++) {
    int count = 0;
    for (int j = 0; j < n; j++)
     if (i != j) {
      if (friends[i][j] == 'Y') count++;
      else
       for (int k = 0; k < n; k++)
        if (i != k && k != j)
         if (friends[i][k] == 'Y' && friends[k][j] == 'Y') {
          count++;
          break;
         }
     }

    if (count > res) {
     res = count;
    }
   }
   return res;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   FriendScore friendScore = new FriendScore();
   do {
    string[] values = input.Split(',');
    int validationOp = friendScore.HighestScore(values);
    Console.WriteLine(validationOp);
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}