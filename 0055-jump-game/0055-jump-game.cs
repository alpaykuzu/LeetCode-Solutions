public class Solution {
    public bool CanJump(int[] nums) {
        int maxIndex = 0;
        
        for (int i=0; i<nums.Length; i++){
            if ((i + nums[i]) > maxIndex){
                maxIndex = i + nums[i];
            }
            if (maxIndex >= nums.Length - 1) {
                return true;
            }
            if (i >= maxIndex){
                return false;
            }
        }
        return false;
    }
}