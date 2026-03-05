public class Solution {
    private int[][] dp;
    
    public int UniquePaths(int m, int n) {
        dp = new int[m][];
        for(int i = 0; i < m; i++){
            dp[i] = new int[n];
        }
        dp[0][0] = 1;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(i == 0 && j == 0) continue;
                int up = 0, left = 0;
                if(i > 0) up = dp[i-1][j];
                if(j > 0) left = dp[i][j-1];
                dp[i][j] = up + left;
            }
        }

        return dp[m-1][n-1];
    }
}