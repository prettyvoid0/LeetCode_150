namespace LeetCode_150.Topics
{
    public class BinarySearch
    {
        /// <summary>
        /// Given a sorted array of distinct integers and a target value, return the index if the target is found.
        /// If not, return the index where it would be if it were inserted in order.
        /// </summary>
        /// <param name="nums">The array of nums.</param>
        /// <param name="target">The target which must located in the array.</param>
        /// <returns>The index of the target in the array.</returns>
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target)
                {
                    continue;
                }
                else
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
