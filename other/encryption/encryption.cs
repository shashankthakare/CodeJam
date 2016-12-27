using System; 

public class TheNewHouseDivOne { 
  public double distance(int[] x, int[] y, int k) { 
        for (int i = 0; i < x.Length; ++i) 
        { 
            x[i] *= 4; 
            y[i] *= 4; 
        } 
        int[] dist = new int[x.Length]; 
        int res = int.MaxValue; 
        for (int X = -210; X <= 210; ++X) 
            for (int Y = -210; Y <= 210; ++Y) 
            { 
                for (int i = 0; i < x.Length; ++i) 
                { 
                    dist[i] = Math.Abs(x[i] - X) + Math.Abs(y[i] - Y); 
                } 
                Array.Sort(dist); 
                res = Math.Min(res, dist[k - 1]); 
            } 
        return res / 4.0; 
  } 



} 

