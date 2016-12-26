#include<stdio.h>
 
int main(){
 
	int test,n,c,sum,no;
 
	scanf("%d",&test);
	while(test--){
		sum=0;
		scanf("%d%d",&n,&c);
		while(n--){
			scanf("%d",&no);
			sum+=no;
		}
		if(sum>c)
			printf("No\n");
		else
			printf("Yes\n");
			
	}
	return 0;
} 