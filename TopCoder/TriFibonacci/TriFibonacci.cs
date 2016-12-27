using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] A)
        {
            int i;
						int total;
						int value;
						total = A.Count;
						if (A[0] == -1)
						{
								A[0] = A[3] - (A[2] + A[1]);
								value = A[0];
						}
						if (A[1] == -1)
						{
								A[1] = A[3] - (A[2] + A[0]);
								value = A[1];
						}
						if (A[2] == -1)
						{
								A[2] = A[3] - (A[1] + A[0]);
								value = A[2];
						}
						for (i = 3; i < total; i++)
						{
								if (A[i] == -1)
								{
										A[i] = A[i - 1] + A[i - 2] + A[i - 3];
										value = A[i];
								}
								else
								{
										if (A[i] == A[i - 1] + A[i - 2] + A[i - 3])
												continue;
										else
												return -1;
								}
						}
						if (i == total)
						{
								if (value > 0)
										return value;
								else
										return -1;
						}
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
				string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate(string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}