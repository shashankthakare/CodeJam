    #include<stdio.h>
    #include<stdlib.h>
    #include<math.h>
    int cmp(const void*,const void*);
    int main()
    {
    	int n1,n2,n3,i,*l4,*lf,k=0;
    	scanf("%d %d %d",&n1,&n2,&n3);
    	l4=(int*)malloc(sizeof(int)*(n1+n2+n3));
    	lf=(int*)malloc(sizeof(int)*((n1+n2+n3)-((n1<n2?n1:n2)<n3?(n1<n2?n1:n2):n3)));
    	for(i=0;i<(n1+n2+n3);i++)
    	scanf("%d",&l4[i]);
    	qsort(l4,(n1+n2+n3),sizeof(int),cmp);
    	for(i=0;i<(n1+n2+n3);i++)
    	{
    		if(l4[i]==l4[i+1]&&l4[i]==l4[i+2])
    		{
    			lf[k++]=l4[i];
    			i=i+2;
    		}
    		else if(l4[i]==l4[i+1])
    		{
    			lf[k++]=l4[i];
    			i++;
    		}
    		
    	}
    	printf("%d\n",k);
    	for(i=0;i<k;i++)
    	printf("%d\n",lf[i]);
    	free(lf);
    	free(l4);
    return 0;
    }
    int cmp(const void *a, const void *b) 
    { 
        const int *ia = (const int *)a; 
        const int *ib = (const int *)b;
        return *ia  - *ib; 
    }   