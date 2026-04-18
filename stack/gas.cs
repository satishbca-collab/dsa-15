public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalTank = 0, currTank = 0, startStation = 0;

        for (int i = 0; i < gas.Length; i++) {
            int netGain = gas[i] - cost[i];
            totalTank += netGain;
            currTank += netGain;

            if (currTank < 0) {
                startStation = i + 1;
                currTank = 0;
            }
        }

        return totalTank >= 0 ? startStation : -1;

    }
}