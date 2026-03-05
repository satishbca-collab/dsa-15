public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] result = new int[n][];

        for(int i = 0; i < n; i++){
            result[i] =  new int[n];
        }

        int[] dx = [0,1,0,-1];
        int[] dy = [1,0,-1,0];
        int di = 0;
        int row = 0, col = 0;
        for(int i = 1; i <= n*n; i++){
            result[row][col] = i;

            int nextRow = row + dx[di];
            int nextCol = col + dy[di];

            if(nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n || result[nextRow][nextCol] != 0){
                di = (di + 1)% 4;
                nextRow = row + dx[di];
                nextCol = col + dy[di];
            }
            row = nextRow;
            col = nextCol;
        }
        return result;
    }
}