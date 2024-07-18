namespace LeetCode_150.Topics
{
    public class Math
    {
        /// <summary>
        /// Given an integer x and checks if it is a palindrome.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Returns True if x is a palindrome, else returns False.</returns>
        public bool IsPalindrome(int x)
        {
            string strLeft = Convert.ToString(x);
            string strRight = "";
            for (int i = Convert.ToString(x).Length - 1; i != -1; i--)
            {
                strRight += strLeft[i];
            }
            if (strRight == strLeft)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
