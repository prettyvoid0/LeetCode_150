namespace LeetCode_150.Topics
{
    public class SingleDimensionalDP
    {
        /// <summary>
        /// Given the amount of stairs and returns an amount of distinct ways to climb to the top.
        /// </summary>
        /// <param name="n">The number of stairs.</param>
        /// <returns>Returns the amount of distinct ways to climb to the top.</returns>
        public int ClimbStairs(int n)
        {
            int result = 1;
            int temp = 1;
            for (int i = 1; i < n; i++)
            {
                result += temp;
                temp = result - temp;
            }
            return result;
        }
    }
}
