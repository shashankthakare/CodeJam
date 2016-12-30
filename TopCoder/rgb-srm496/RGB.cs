public class ColoredStrokes
{
  public virtual int getLeast(string[] s)
  {
    int ans = 0;
    int n = s.Length;
    int m = s[0].Length;
    for (int i = 0; i < n; ++i)
    {
      for (int j = 0; j < m; ++j)
      {
        if ((s[i][j] == 'R' || s[i][j] == 'G') && (j == 0 || !(s[i][j - 1] == 'R' || s[i][j - 1] == 'G')))
        {
          ans++;
        }
      }
    }
    for (int j = 0; j < m; ++j)
    {
      for (int i = 0; i < n; ++i)
      {
        if ((s[i][j] == 'B' || s[i][j] == 'G') && (i == 0 || !(s[i - 1][j] == 'B' || s[i - 1][j] == 'G')))
        {
          ans++;
        }
      }
    }
    return ans;
  }


}