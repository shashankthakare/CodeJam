using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class NoPointSegment
    {
        public string Intersection(int[] seg1, int[] seg2)
        {
            int s10 = Math.Min(s1[0], s1[2]);
			int s11 = Math.Min(s1[1], s1[3]);
			int s12 = Math.Max(s1[0], s1[2]);
			int s13 = Math.Max(s1[1], s1[3]);
			int s20 = Math.Min(s2[0], s2[2]);
			int s21 = Math.Min(s2[1], s2[3]);
			int s22 = Math.Max(s2[0], s2[2]);
			int s23 = Math.Max(s2[1], s2[3]);
			if (s10 > s22 || s12 < s20 || s11 > s23 || s13 < s21)
			{
				return "NO";
			}

			int x1 = Math.Max(s10, s20);
			int x2 = Math.Min(s12, s22);
			int y1 = Math.Max(s11, s21);
			int y2 = Math.Min(s13, s23);

			if (x1 == x2 && y1 == y2)
			{
				return "POINT";
			}

			return "SEGMENT";
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            string input = Console.ReadLine();
            NoPointSegment solver = new NoPointSegment();
            do
            {
                var segments = input.Split('|');
                var segParts = segments[0].Split(',');
                var seg1 = new int[4] { int.Parse(segParts[0]), int.Parse(segParts[1]), int.Parse(segParts[2]), int.Parse(segParts[3]) };
                segParts = segments[1].Split(',');
                var seg2 = new int[4] { int.Parse(segParts[0]), int.Parse(segParts[1]), int.Parse(segParts[2]), int.Parse(segParts[3]) };
                Console.WriteLine(solver.Intersection(seg1, seg2));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}