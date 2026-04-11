/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    const n = s.length;
  if (n <= 1) return n;

  const set = new Set();
  let left = 0,
    max = 0;
  for (let right = 0; right < n; right++) {
    while (set.has(s[right])) {
      set.delete(s[left++]);
    }
    set.add(s[right]);
    max = Math.max(max, right - left + 1);
  }
  return max;
};