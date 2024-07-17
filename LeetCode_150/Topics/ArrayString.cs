namespace LeetCode_150.Topics
{
    public class ArrayString
    {
        /// <summary>
        /// Returns the amount of unique elements in the array.
        /// Set ununique elements after sorted list of unique elements for the array.
        /// </summary>
        /// <param name="nums">The array of nums.</param>
        /// <returns>The amount of unique elements in the array.</returns>
        public int RemoveDuplicates(int[] nums)
        {
            int[] numsDistincts = nums.Distinct().ToArray();
            int counter = 0;
            foreach (int num in numsDistincts)
            {
                nums[counter++] = num;
            }

            nums = nums[0..counter];

            return nums.Length;
        }
    }
}
