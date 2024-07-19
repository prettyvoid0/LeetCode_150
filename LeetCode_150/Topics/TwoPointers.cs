namespace LeetCode_150.Topics
{
    public class TwoPointers
    {
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
    }
}
