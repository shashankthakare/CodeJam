using System;

public class Salary
{
  internal bool ddd = false;
  internal virtual int ss(string s)
  {
    char[] b = s.ToCharArray();
    return ((b[0] - '0') * 10 + b[1] - '0') * 3600 + ((b[3] - '0') * 10 + b[4] - '0') * 60 + ((b[6] - '0') * 10 + b[7] - '0');
  }
  internal string morn = "06:00:00";
  internal string eve = "18:00:00";
  internal virtual int tot(int lo, int hi)
  {
    int r = 0;
    if (lo < ss(morn))
    {
      r += 3 * (Math.Min(ss(morn), hi) - lo);
      lo = ss(morn);
    }
    if (hi > ss(eve))
    {
      r += 3 * (hi - Math.Max(ss(eve), lo));
      hi = ss(eve);
    }
    if (hi > lo)
    {
      r += 2 * (hi - lo);
    }
    return r;
  }
  public virtual int howMuch(string[] arrival, string[] departure, int wage)
  {
    int i, j, k;
    int n = arrival.Length;
    int tim = 0;
    int[] arr = new int[arrival.Length];
    int[] dep = new int[departure.Length];
    for (i = 0; i < n; i++)
    {
      arr[i] = ss(arrival[i]);
      dep[i] = ss(departure[i]);
      Console.WriteLine("Got " + arr[i] + " " + dep[i]);
      tim += tot(arr[i], dep[i]);
    }
    return (int)(tim * (long)wage / 7200);
  }
}