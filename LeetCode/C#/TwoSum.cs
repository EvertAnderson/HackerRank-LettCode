public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            int tempTarget = target;
            tempTarget -= nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == tempTarget)
                {
                    return [i,j];
                }
            }
            if (tempTarget == 0) break;
        }

        return [0,0];
    }

    //Testing on VS
    // static void Main(string[] args)
    // {
    //     TwoSum([-1, -2, -3, -4, -5], -8);
    //     Console.ReadLine();
    // }
}