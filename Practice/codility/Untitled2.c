#include <stdio.h>

void arrangeCoins(int coins_size, long int* coins) {
    int i,j,count;
    long int current;
    for(i = 0; i < coins_size; i++){
        j=1;count=0;
        current = *(coins+i);
        while(current>0){
            coins[i]-j;
            j++;

            if(current>0 || current==0)
                count++;
            else
                printf("%d\n",count);
        }
    }

}

int main() {
	// your code goes here
	long int balance[5] = {1000, 2, 3, 17, 50};
    long *p;

   p = balance;
	arrangeCoins(4,p);
	return 0;
}
