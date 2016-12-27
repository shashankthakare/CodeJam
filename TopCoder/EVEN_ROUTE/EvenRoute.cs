using System;
using System.Linq;

namespace CodeJam {
 class EvenRoute {
  string IsItPossible(int[] x, int[] y, int wantedParity) {
   int n = x.Length;
   for (int i = 0; i < n; i++) {
    int tmp = x[i] + y[i];
    if ((tmp & 1) == wantedParity) {
     return "CAN";
    }
   }
   return "CANNOT";
  }

  #region Testing code Do not change
  public static void Main(String[] args) {
   EvenRoute evenRoute = new EvenRoute();
   String input = Console.ReadLine();
   do {
    var inputParts = input.Split('|');
    var x = inputParts[0].Split(',').ToList().Select(ix => int.Parse(ix)).ToArray();
    var y = inputParts[1].Split(',').ToList().Select(iy => int.Parse(iy)).ToArray();
    int wantedParity = int.Parse(inputParts[2]);
    Console.WriteLine(evenRoute.IsItPossible(x, y, wantedParity));
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}