/**
 * @param {number[]} height
 * @return {number}
 */
var trap = function(height) {
    const n = height.length;
    let leftMax = 0;
    let rightMax = 0;
    let count = 0;
    let left = 0, right = n - 1;
    while(left < right){
        if(height[left] < height[right]){
            if(height[left] > leftMax){
                leftMax = height[left];
            }
            else {
                count += leftMax - height[left];
            }
            left++;
        }
        else {
            if(height[right] > rightMax){
                rightMax = height[right];
            }
            else {
                count += rightMax - height[right];
            }
            right--;
        }
    }

    return count;
};