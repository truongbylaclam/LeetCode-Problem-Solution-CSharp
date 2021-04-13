public class Solution {
    public int[] Shuffle(int[] nums, int n) {
      int[] output = new int[nums.Length];
      int temp = 0;
      for (int i = 0; i < nums.Length / 2; i++)
      {
        // Increment the index as the
        output[i+temp] = nums[i];
        output[i+temp+1] = nums[i+n];
        temp++;
      }
      return output;
    }
}
