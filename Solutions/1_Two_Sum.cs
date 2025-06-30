//https://leetcode.com/problems/two-sum/description/    

public class Two_Sum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var complements = new Dictionary<int, int>();

        for (var pos = 0; pos < nums.Length; pos++)
        {
            var complement = target - nums[pos];

            if (complements.ContainsKey(complement))
            {
                return new int[] { complements[complement], pos };
            }
            else
            {
                complements[nums[pos]] = pos;
            }
        }

        return Array.Empty<int>();
    }
}