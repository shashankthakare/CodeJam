using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class InputBoxChecker {
  String[] CheckPrefix(int smallest, int largest, int[] numbers) {
   string[] sol = new string[numbers.Length];
   for (int i = 0; i < numbers.Length; i++) {
    int n = numbers[i];
    int largest1 = largest;
    int smallest1 = smallest;
    do {

     if (n > largest1) {
      sol[i] = "INVALID";
      break;
     } else if (n >= smallest1 && n <= largest1) {
      sol[i] = "VALID";
      break;
     }
     largest1 /= 10;
     smallest1 /= 10;
    } while (true);
   }
   return sol;
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   InputBoxChecker inputBoxChecker = new InputBoxChecker();
   do {
    string[] values = input.Split('|');
    int[] numbers = Array.ConvertAll < string, int > (values[2].Split(','), delegate(string s) {
     return Int32.Parse(s);
    });
    Console.WriteLine(string.Join(",", inputBoxChecker.CheckPrefix(Int32.Parse(values[0]), Int32.Parse(values[1]), numbers)));
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}