    #include<stdio.h>
    #include<math.h>
    long int mod(long int);
    int main()
    {
    int T;
    long int n,i,min;
    scanf("%d",&T);
    while(T--)
    {
    min=100000000;
    scanf("%ld",&n);
    for(i=1;i<sqrt(n)+1;i++)
    {
    if(n%i==0&&mod((n/i)-i)<min)
    min=mod((n/i)-i);
    }
    printf("%ld\n",min);
    }
    return 0;
    }
    long int mod(long int j)
    {
    if(j<0)
    return(j*(-1));
    else
    return j;
    }