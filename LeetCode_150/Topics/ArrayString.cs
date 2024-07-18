namespace LeetCode_150.Topics
{
    public class ArrayString
    {
        /// <summary>
        /// Returns the amount of unique elements in the array.
        /// Set ununique elements after sorted list of unique elements for the array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <returns>The amount of unique elements in the array.</returns>
        public int RemoveDuplicates(int[] nums)
        {
            int[] numsDistincts = nums.Distinct().ToArray();
            var counter = 0;
            foreach (var num in numsDistincts)
            {
                nums[counter++] = num;
            }

            nums = nums[0..counter];

            return nums.Length;
        }

        /// <summary>
        /// Removes the element from the array.
        /// Set other elements from the beginning of the array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="val">The element which needs to be deleted.</param>
        /// <returns>The amount of remaining elements.</returns>
        public int RemoveElement(int[] nums, int val)
        {
            int[] numsCleared = nums.Where(x => x != val).ToArray();
            var counter = 0;
            foreach(var num in numsCleared)
            {
                nums[counter++] = num;
            }

            nums = nums[0..counter];

            return nums.Length;
        }

        /// <summary>
        /// Finds the most frequent element in the array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <returns>The most frequent element in the array.</returns>
        public int MajorityElement(int[] nums)
        {
            var detectedNums = new List<int>();
            var frequency = new List<int>();

            foreach (var num in nums)
            {
                if (detectedNums.Contains(num))
                {
                    var index = detectedNums.IndexOf(num);
                    frequency[index]++;
                }
                else
                {
                    detectedNums.Add(num);
                    frequency.Add(1);
                }
            }

            var maxFrequencyIndex = frequency.IndexOf(frequency.Max(x => x));
            return detectedNums[maxFrequencyIndex];
        }
    }
}
