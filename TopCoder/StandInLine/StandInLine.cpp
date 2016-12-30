#include <string>
#include <vector>
#include <sstream>
#include <iostream>
#include <algorithm>
#include <set>
#include <map>
#include <cmath>
#include <cstring>
#include <cstdlib>
#include <cstdio>
 
using namespace std;
 
typedef long long llong;
typedef long double ldbl;
 
#define max(a, b) ((a) > (b) ? (a) : (b))
#define min(a, b) ((a) < (b) ? (a) : (b))
#define abs(a) ((a) < 0 ? -(a) : (a))
 
class StandInLine
{
public:
  int u[30], a[30], b[30], n, ans[30], l[30], nu[30];
  void dfs( int i )
  {
    int j, k;
    if (i == n)
    {
      memset(nu, 0, sizeof(nu));
      for (j = 0; j < n; j++)
        for (k = 0; k < j; k++)
          nu[a[j]] += a[k] > a[j];
      for (j = 0; j < n; j++)
        if (nu[j] != l[j])
          return;
      memcpy(ans, a, sizeof(ans));
    }
    else
      for (j = 0; j < n; j++)
        if (!u[j])
          u[j] = 1, a[i] = j, dfs(i + 1), u[j] = 0;
  }
  vector <int> reconstruct( vector <int> ll )
  {
    int i;
    n = ll.size();
    for (i = 0; i < n; i++)
      l[i] = ll[i], u[i] = 0;
    dfs(0);
    for (i = 0; i < n; i++)
      ll[i] = ans[i] + 1;
    return ll;
  }
};