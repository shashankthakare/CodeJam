#include <stdio.h>
#include <limits.h>
int min(int x, int y) { return (x < y)? x: y; }

// Driver program to test above function
int main()
{
    int arr[] = {5, 6, 0, 4, 2, 4, 1, 0, 0, 4};
    int size = sizeof(arr)/sizeof(int);
    int jumps[size];
    int i, j;

      // jumps[0] will hold the result
    int min;

    // Minimum number of jumps needed to reach last element
    // from last elements itself is always 0
    jumps[size-1] = 0;


    // Start from the second element, move from right to left
    // and construct the jumps[] array where jumps[i] represents
    // minimum number of jumps needed to reach arr[m-1] from arr[i]
    for (i = size-2; i >=0; i--)
    {
        // If arr[i] is 0 then arr[n-1] can't be reached from here
        if (arr[i] == 0)
            jumps[i] = INT_MAX;

        // If we can direcly reach to the end point from here then
        // jumps[i] is 1
        else if (arr[i] >= size - i - 1)
            jumps[i] = 1;

        // Otherwise, to find out the minimum number of jumps needed
        // to reach arr[n-1], check all the points reachable from here
        // and jumps[] value for those points
        else
        {
            min = INT_MAX;  // initialize min value

            // following loop checks with all reachable points and
            // takes the minimum
            for (j = i+1; j < size && j <= arr[i] + i; j++)
            {
                if (min > jumps[j]){
                    min = jumps[j];

                }
            }

            // Handle overflow
            if (min != INT_MAX){
              jumps[i] = min + 1;
              printf("j=%d",j);
            }
            else{
              jumps[i] = min; // or INT_MAX
              printf("i2=%d",j);
            }
        }
    }
    printf("\n stepsa: %d",jumps[0]);
    return 0;
}

