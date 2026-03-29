public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        Helper(candidates, target, result, 0, new List<int>());
        return result;
    }

    private void Helper(int[] candidates, int target, IList<IList<int>> result, int index, List<int> current){
        if(target == 0){
            // result found
            result.Add(new List<int>(current));
            return;
        }
        if(target < 0){
            // no more results
            return;
        }

        for(int i = index; i < candidates.Length; i++){
            current.Add(candidates[i]);
            Helper(candidates, target - candidates[i], result, i+1, current);
            current.RemoveAt(current.Count-1);
            while(i < candidates.Length-1 && candidates[i] == candidates[i+1]){
                i++;
            }
        }
    }
}
//[1,1,2,5,6,7,10]