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

        /// <summary>
        /// Given an array of digits as a completed number and add 1 to it.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns>The new number which is represented as an array of digits.</returns>
        public int[] PlusOne(int[] digits)
        {
            var list = digits.ToList();

            list[list.Count - 1]++;

            for(int i = list.Count - 1; i >= 0; i-- )
            {
                if (list[i] == 10)
                {
                    list[i] = 0;
                    if (i == 0)
                    {
                        list.Insert(0, 1);
                        break;
                    }
                    list[i - 1]++;
                }
            }

            return list.ToArray();
        }
    }
}
