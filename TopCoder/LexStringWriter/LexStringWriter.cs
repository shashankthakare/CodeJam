using System;

public virtual int minMoves(string s)
{
    int res = 0;
    char[] c = s.ToCharArray();
    int leng = c.Length;
    int[][] a = new int[27][2];
    int[][] pos = new int[27][2];
    a[0][0] = 0;
    a[0][1] = 0;
    pos[0][0] = 0;
    pos[0][1] = 0;
    for (int i = 1; i < 27; i++)
    {
      int l = leng;
      int r = -1;
      for (int j = 0; j < leng; j++)
      {
        if (c[j] == ('a' + i - 1))
        {
          l = Math.Min(l, j);
          r = Math.Max(r, j);
        }
      }
      if (r == -1)
      {
        a[i] = a[i - 1];
        pos[i] = pos[i - 1];
      }
      else
      {
        pos[i][0] = l;
        pos[i][1] = r;
        a[i][0] = Math.Min(a[i - 1][0] + Math.Abs(pos[i - 1][0] - r) + Math.Abs(l - r), a[i - 1][1] + Math.Abs(pos[i - 1][1] - r) + Math.Abs(l - r));
        a[i][1] = Math.Min(a[i - 1][0] + Math.Abs(pos[i - 1][0] - l) + Math.Abs(l - r), a[i - 1][1] + Math.Abs(pos[i - 1][1] - l) + Math.Abs(l - r));
      }
    }
    return Math.Min(a[26][0], a[26][1]) + leng;
}