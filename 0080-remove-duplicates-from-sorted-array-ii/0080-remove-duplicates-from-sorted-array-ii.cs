public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0; 
        int k = 1; 
        int counter = 0;

        for (int i = 1; i < nums.Length; i++) 
        {
            if (nums[i] != nums[i - 1]) 
            {
                nums[k] = nums[i];
                k++;
                counter = 0;
            }
            else
            {
                counter++;
                if(counter > 1)
                {
                    continue;
                }
                nums[k] = nums[i];
                k++;
            }  
        }
        return k;
    }
}