#include <stdio.h>
#include <limits.h>
#include <malloc.h>
//Dynamic programming approach taken
//Space complexity O(N)
//Time complexity O(N^2)

//Two arrays have been used. Flights array has the number of flights needed
//from beginning to that element. Path array indicates the last flight that
//was taken to reach the current element.
int main()
{
    int size,i;
    scanf("%d",&size);
//end program if empty input
    if (size == 0){
        printf("failure\n");
        return;
    }

    int inputArray[size];
    for(i=0;i<size;i++){
        scanf("%d",&inputArray[i]);
    }
    int flights[size];
    int path[size];
    int j;
//end program if first element is a dragon
    if (inputArray[0] == 0){
        printf("failure\n");
        return;
    }

    flights[0] = path[0] = 0;

    for (i = 1; i < size; i++)
    {
//initializing flight value for a cell initially to arbitrary INT_MAX value.
        flights[i] = 9999;
        for (j = 0; j < i; j++)
        {
//if arbit value does not match and hop from j and its value is less than value at i
            if (flights[j] != 9999 && i <= j + inputArray[j])
            {
                if(flights[i]>=(flights[j]+1)){
//assign the lesser value to flights and update the path
                 flights[i] = (flights[j] + 1);
                 path[i]=j;
                }
            }
        }
    }

//to handle corner case if some dragons(zero values) in dungeon
//such that its not possible to fly over them.
    if(flights[size-1]==9999){
        printf("failure\n");
        return;
    }

//Format output in the required format
    for(i=0;i<size;i++){
        if(path[i]!=path[i+1] || i==(size-1) )
            printf("%d, ",path[i]);
    }

    if(path[size-1]+inputArray[path[size-1]]==size-1)
        printf("%d, ",size-1);

    printf("out\n");

    return 0;
}
