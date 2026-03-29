public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        Helper(nums, result, new List<int>(), 0);
        return result;
    }

    private void Helper(int[] nums, IList<IList<int>> result, List<int> current, int index){
        result.Add(new List<int>(current));

        for(int i = index; i < nums.Length; i++){
            current.Add(nums[i]);
            Helper(nums, result, current, i + 1);
            current.RemoveAt(current.Count - 1);
        }
    }
}