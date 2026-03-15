public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var visited = new bool[nums.Length];
        Helper(nums, result, new List<int>(), visited);
        return result;
    }

    private void Helper(int[] nums, IList<IList<int>> result, List<int> current, bool[] visited){
        if(current.Count == nums.Length){
            result.Add(new List<int>(current));
            return;
        }

        for(int i = 0; i < nums.Length; i++){
            if(!visited[i]){
                current.Add(nums[i]);
                visited[i] = true;
                Helper(nums, result, current, visited);
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
            }
        }
    }
}