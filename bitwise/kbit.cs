class Solution {
    public bool CheckKthBit(int n, int k) {
        // code here
        return ((n >> k) & 1) == 1;
    }
}

class Solution {
    public bool CheckKthBit(int n, int k) {
        // code here
        return (n & (1 << k)) != 0;
    }
}