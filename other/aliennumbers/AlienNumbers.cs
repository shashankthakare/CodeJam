using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam {
 class AlienNumbers {

  public virtual string getTargetNumber(string alien_number, string source_language, string target_language) {
   int iSrcLangBaseNum = source_language.Trim().Length;
   int iTgtLangBaseNum = target_language.Trim().Length;

   int iAlienNumInDecSystem = 0;
   int iAlienNumLen = alien_number.Length;

   for (int i = 0; i < iAlienNumLen; i++) {
    iAlienNumInDecSystem += source_language.IndexOf(alien_number[i]) * Math.Pow(iSrcLangBaseNum, (iAlienNumLen - 1 - i));
   }

   StringBuilder sbTgtLangNum = new StringBuilder();
   int tempNum = iAlienNumInDecSystem;

   while (true) {
    sbTgtLangNum.Append(strTgtLang[tempNum % iTgtLangBaseNum]);
    if ((tempNum / iTgtLangBaseNum) == 0) {
     break;
    } else {
     tempNum /= iTgtLangBaseNum;
    }
   }

   return sbTgtLangNum.reverse().ToString();
  }


  #region Testing code Do not change
  public static void Main(String[] args) {
   String input = Console.ReadLine();
   AlienNumbers alienNumbers = new AlienNumbers();
   int cse = 1;
   do {
    var values = input.Split(' ');
    string validationOp = alienNumbers.getTargetNumber(values[0], values[1], values[2]);
    Console.WriteLine("Case #{0}: {1}", cse++, validationOp);
    input = Console.ReadLine();
   } while (input != "-1");
  }#endregion
 }
}