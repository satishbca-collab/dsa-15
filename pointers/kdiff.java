class Solution {
    public int findPairs(int[] nums, int k) {
        Arrays.sort(nums);
        int left = 0, right = 1, count = 0;
        int n = nums.length;

        while (left < n && right < n) {
            // System.out.println(left);
            // System.out.println(right);
            int diff = nums[right] - nums[left];

            if (diff < k || left >= right) {
                right++;
            } else if (diff > k) {
                left++;
            } else {
                count++;
                left++;
                right++;

                // skip duplicates safely
                while (left < n && nums[left] == nums[left - 1]) {
                    left++;
                }
            }
        }

        return count;
    }
}