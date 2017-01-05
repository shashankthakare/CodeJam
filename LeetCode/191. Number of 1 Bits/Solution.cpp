class Solution {
public:
    int hammingWeight(uint32_t n) {
        int numBits = 0;
    	while(n) {
	    	n = n&(n-1);
		    numBits++;
	    }
	    return numBits;
    }
};