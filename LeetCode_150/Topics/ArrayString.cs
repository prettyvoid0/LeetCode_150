namespace LeetCode_150.Topics
{
    public class ArrayString
    {
        /// <summary>
        /// Gets the amount of unique elements in the array.
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

        /// <summary>
        /// Converts the roman numeral into the integer one.
        /// </summary>
        /// <param name="input">The roman numeral.</param>
        /// <returns>The converted to integer numeral.</returns>
        public int RomanToInt(string input)
        {
            int result = 0;
            bool flag = false;
            (char, int)[] romanIntegers =
            {('I',1),
            ('V',5),
            ('X',10),
            ('L',50),
            ('C',100),
            ('D',500),
            ('M',1000)};
            

            for (int i = 0; i < input.Length; i++)
            {
                if (flag)
                {
                    flag = false;
                    continue;
                }
                if (input[i] == 'I' && i + 1 != input.Length)
                {
                    if (input[i + 1] != 'V' && input[i + 1] != 'X')
                    {
                        result += 1;
                    }
                    else
                    {
                        flag = true;
                        result = input[i + 1] == 'V'
                        ? result += 4
                        : result += 9;
                    }
                }

                else if (input[i] == 'X' && i + 1 != input.Length)
                {
                    if (input[i + 1] != 'L' && input[i + 1] != 'C')
                    {
                        result += 10;
                    }
                    else
                    {
                        flag = true;
                        result = input[i + 1] == 'L'
                        ? result += 40
                        : result += 90;
                    }
                }

                else if (input[i] == 'C' && i + 1 != input.Length)
                {
                    if (input[i + 1] != 'D' && input[i + 1] != 'M')
                    {
                        result += 100;
                    }
                    else
                    {
                        flag = true;
                        result = input[i + 1] == 'D'
                        ? result += 400
                        : result += 900;
                    }
                }

                else
                {
                    result += romanIntegers.Where(x => x.Item1 == input[i]).First().Item2;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the number of characters in the last word in the string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The length of the last word in the string.</returns>
        public int LengthOfLastWord(string s)
        {
            int result = 0;
            int indexOfLastChar = s.Length - 1;
            while (s[indexOfLastChar] == ' ')
            {
                indexOfLastChar--;
            }
            while (s[indexOfLastChar] != ' ')
            {
                result++;
                indexOfLastChar--;
                if (indexOfLastChar < 0)
                {
                    break;
                }
            }
            return result;
        }
    }
}
