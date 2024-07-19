namespace LeetCode_150.Topics
{
    public class TwoPointers
    {
        /// <summary>
        /// Given a string and checks if it is a palindrome.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Returns True if S is a palindrome, else returns False.</returns>
        public bool ValidPalindrome(string s)
        {
            s = String.Concat(Array.FindAll(s.ToCharArray(), Char.IsLetterOrDigit));

            s = s.ToLower();

            string invertedString = "";

            for (int i = s.Length - 1; i!=-1; i--)
            {
                invertedString += s[i];
            }

            return invertedString.Equals(s);
        }

        /// <summary>
        /// Given two strings and checks if s is a subsequence of t.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns>Returns True if S is a subsequence of T, else returns False.</returns>
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }

            if (s.Length > t.Length)
            {
                return false;
            }

            var sList = s.ToList();
            var tList = t.ToList();

            bool flag = false;
            for(int i = 0; i < tList.Count; i++)
            {
                if (sList[0] == tList[i])
                {
                    sList.RemoveAt(0);
                }

                if (sList.Count == 0)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }
    }
}
