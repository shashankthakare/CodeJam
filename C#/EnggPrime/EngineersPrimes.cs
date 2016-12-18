using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam {
 public class EngineersPrimes {
  long SmallestNonPrime(int N) {
   long[] primes = new long[N + 1];
   if (N == 1) {
    return 9;
   }
   primes[0] = 2;
   int cur = 1;
   double lim = 0;
   long i = 3;
   Main:
    for (i = 3; cur <= N;) { //finding first N primes
     lim = Math.Sqrt(i);
     for (int j = 1; primes[j] <= lim && j < cur; j++) {
      if (i % primes[j] == 0) {
       i += 2;
       goto Main;
      }
     }
     primes[cur] = i;
     cur++;
     i += 2;
    }

   return primes[N] * primes[N];
  }

  #
  region Testing code Do not change
  public static void Main(String[] args) {
   EngineersPrimes engineersPrimes = new EngineersPrimes();
   String input = Console.ReadLine();
   do {
    Console.WriteLine(engineersPrimes.SmallestNonPrime(Int32.Parse(input)));
    input = Console.ReadLine();
   } while (input != "-1");
  }#
  endregion
 }
}