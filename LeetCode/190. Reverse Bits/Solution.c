class Solution {
public:
    uint32_t reverseBits(uint32_t n) {
        unsigned int reverse = 0;
        unsigned int mask = 1<<31;
        for(int i=0; i<32; ++i){
            if((n&1)==1){//last bit is 1
                reverse|=mask;
            }
            mask>>=1;
            n>>=1;
        }
        return reverse;
    }
};