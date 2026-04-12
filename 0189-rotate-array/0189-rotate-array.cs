public class Solution {
    public void Rotate(int[] nums, int k) {
        int cache = 0;
        k = k % nums.Length;
        if (k == 0)
            return;

        for(int i=0; i<nums.Length/2; i++){
            cache = nums[nums.Length-1-i];
            nums[nums.Length-1-i] = nums[i];
            nums[i] = cache;
        }
        for(int i=0; i<k/2; i++){
            cache = nums[k-1-i];
            nums[k-1-i] = nums[i];
            nums[i] = cache;
        }
        for(int i=0; i<(nums.Length-k)/2; i++){
            cache = nums[k+i];
            nums[k+i] = nums[nums.Length-1-i];
            nums[nums.Length-1-i] = cache;
        }
    }
}