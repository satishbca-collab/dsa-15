public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i], 1);
            }
        }
        int maxCount = 0;
        for(int i = 0; i < nums.Length; i++){
            if(map.ContainsKey(nums[i])){
                int count = 1, key = nums[i];
                map.Remove(key);
                while(map.ContainsKey(key - 1)){
                    map.Remove(key - 1);
                    count++;
                    key--;
                }
                key = nums[i];
                while(map.ContainsKey(key + 1)){
                    map.Remove(key + 1);
                    count++;
                    key++;
                }

                if(count > maxCount) maxCount = count;
            }
        }

        return maxCount;
    }
}