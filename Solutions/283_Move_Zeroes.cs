//https://leetcode.com/problems/move-zeroes/description/

public class Move_Zeroes
{
    public void MoveZeroes(int[] nums)
    {
        var currentIndex = 0;
        var nonZeroIndex = 0;
        var stop = false;

        while (currentIndex < nums.Length)
        {
            if (nums[currentIndex] == 0)
            {
                stop = true;
                for (var pos = currentIndex; pos < nums.Length; pos++)
                {
                    if (nums[pos] != 0)
                    {
                        nonZeroIndex = pos;
                        stop = false;
                        break;
                    }
                }
                if (stop)
                {
                    return;
                }
                nums[currentIndex] = nums[nonZeroIndex];
                nums[nonZeroIndex] = 0;
            }
            else
            {
                currentIndex += 1;
            }
        }
    }
}