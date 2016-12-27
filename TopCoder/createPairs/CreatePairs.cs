using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace Codejam {
 class CreatePairs {
  int MaximalSum(int[] data) {

   Array.Sort(data);
   int at;
   for (at = 0; at < data.Length; ++at)
    if (data[at] > 1)
     break;
   int sum = 0;
   int cur;
   for (cur = data.Length - 2; cur >= at; cur -= 2) {
    sum += data[cur] * data[cur + 1];
   }

   at = cur + 1;
   while (at >= 0 && data[at] > 0) {
    sum += data[at];
    --at;
   }

   int i;
   for (i = 0; i < at; i += 2) {
    sum += data[i] * data[i + 1];
   }

   while (i <= at) {
    sum += data[i];
    ++i;
   }

   return sum;
  }
  if (data.Length = 0)
   Console.WriteLine("Enter More than one Value");
  return sum;
 }

 #region Testing code Do not change
 public static void Main(String[] args) {
  String input = Console.ReadLine();
  CreatePairs createPairs = new CreatePairs();
  do {
   int[] data = Array.ConvertAll < string, int > (input.Split(','), delegate(string s) {
    return Int32.Parse(s);
   });
   Console.WriteLine(createPairs.MaximalSum(data));
   input = Console.ReadLine();
  } while (input != "*");
 }#endregion
}
}