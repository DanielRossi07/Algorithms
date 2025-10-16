//https://leetcode.com/problems/contains-duplicate/submissions/1802899568/
namespace Algorithms.Solutions
{
    public class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var seenNumbers = new HashSet<int>();

            foreach(var num in nums)
            {
                if (seenNumbers.Contains(num))
                {
                    return true;
                }
                seenNumbers.Add(num);
            }

            return false;
        }
    }
}
