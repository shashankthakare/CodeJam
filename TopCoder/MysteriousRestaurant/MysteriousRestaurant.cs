#include <vector>
#include <list>
#include <map>
#include <set>
#include <queue>
#include <deque>
#include <stack>
#include <bitset>
#include <algorithm>
#include <functional>
#include <numeric>
#include <utility>
#include <sstream>
#include <iostream>
#include <iomanip>
#include <cstdio>
#include <cmath>
#include <cstdlib>
#include <ctime>

using namespace std;


class MysteriousRestaurant {
public:
  int maxDays(vector <string> prices, int budget) {

		vector<int> daily[prices.size()];
		for(int i=0; i<prices.size(); ++i){

			for(int j=0; j<prices[i].size(); ++j){
				int tmp = prices[i][j];
				if('0'<=tmp&&tmp<='9')
					tmp = tmp-'0';
				else if ('A'<=tmp&&tmp<='Z')
					tmp = tmp-'A'+10;
				else if ('a'<=tmp&&tmp<='z')
					tmp = tmp-'a'+36;

				if(i>=7)
					tmp += daily[i-7][j];
				daily[i].push_back(tmp);
			}

			if(i<7)
				budget -= *min_element(daily[i].begin(), daily[i].end());
			else{
				budget += *min_element(daily[i-7].begin(), daily[i-7].end());
				budget -= *min_element(daily[i].begin(), daily[i].end());
			}

			if (budget<=0)
				return i+(budget==0);
		}

		return -1;
	}
};

