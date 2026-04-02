/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var sortColors = function(nums) {
    let left = 0, cur = 0, right = nums.length-1;
    while(cur <= right){
        if(nums[cur] == 0){
            swap(nums, left, cur);
            left++;
            cur++;
        }
        else if( nums[cur] == 1){
            cur++;
        }
        else {
            swap(nums, cur, right);
            right--;
        }
    }
};

function swap(nums, i, j){
    let temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}