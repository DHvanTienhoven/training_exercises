using System;

namespace StringExtensionMethods
{
    public static class StringExtensions
    {
        public static int CountWords(this string input)
        {
            char[] delimiters = new char[] {' ', '\r', '\n' };
            return input.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int CountWhitespace(string input)
        {
            int result = 0;
            foreach (char character in input)
            {
                if(char.IsWhiteSpace(character))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
