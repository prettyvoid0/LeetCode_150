namespace LeetCode_150.Topics
{
    public class HashMap
    {
        /// <summary>
        /// Creates the array of nums which could be used to get the target by sum.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>The array of elements such that they add up to the target.</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Given two strings and checks if the second one is an anagram for the first one.
        /// </summary>
        /// <param name="s">The first string.</param>
        /// <param name="t">The second string.</param>
        /// <returns>Returns true if second string is an anagram of the first string. Else returns false.</returns>
        public bool IsAnagram(string s, string t)
        {
            char[] a = s.ToCharArray();
            char[] b = t.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            return Enumerable.SequenceEqual(a, b);
        }
    }
}
