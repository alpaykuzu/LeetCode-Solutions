public class Solution {
    public int Jump(int[] nums) {
        int jumps = 0;
        int jump_end = 0;
        int top_point = 0;

        for (int i=0; i<nums.Length -1; i++){
            if(nums[i] + i >= top_point){
                top_point = nums[i] + i;
            }

            if (i == jump_end){
                jump_end = top_point;
                jumps++;
            }
        }
        return jumps;
    }
}