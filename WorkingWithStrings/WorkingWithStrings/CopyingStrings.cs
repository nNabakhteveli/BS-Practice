using System;

namespace WorkingWithStrings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            // TODO #8-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.CopyTo method to copy characters: https://docs.microsoft.com/en-us/dotnet/api/system.string.copyto
            char[] destArr = destination.ToCharArray();

            source.CopyTo(0, destArr, 0, 3);

            return new string(destArr);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            // TODO #8-2. Analyze unit tests for the method, and add the method implementation.
            char[] destArr = destination.ToCharArray();

            source.CopyTo(0, destArr, 4, 5);

            return new string(destArr);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            // TODO #8-3. Analyze unit tests for the method, and add the method implementation.
            char[] destArr = destination.ToCharArray();

            source.CopyTo(2, destArr, 5, 6);

            return new string(destArr);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            // TODO #8-4. Analyze unit tests for the method, and add the method implementation.
            var templateCharsArr = template.ToCharArray();

            regionCode.CopyTo(GetMiddleElementIdx(regionCode), templateCharsArr, FindInsertionIdx(templateCharsArr), CountAsterisks(templateCharsArr));
            locationCode.CopyTo(GetMiddleElementIdx(locationCode), templateCharsArr, FindInsertionIdx(templateCharsArr), CountAsterisks(templateCharsArr));
            dateCode.CopyTo(GetMiddleElementIdx(dateCode), templateCharsArr, FindInsertionIdx(templateCharsArr), CountAsterisks(templateCharsArr));
            factoryCode.CopyTo(GetMiddleElementIdx(factoryCode) - 1, templateCharsArr, FindInsertionIdx(templateCharsArr), CountAsterisks(templateCharsArr));

            var result = string.Empty;

            foreach (var i in templateCharsArr)
            {
                result += i;
            }

            return result;
        }

        // Find where to start copying from
        private static int GetMiddleElementIdx(string str) => Convert.ToInt32(Math.Floor((decimal)str.Length / 2));

        // Find index of first asterisk from remaining ones
        private static int FindInsertionIdx(char[] templateChars) => Array.IndexOf(templateChars, '*');

        private static int CountAsterisks(char[] templateChars, string alma = "asd")
        {
            int count = 0;
            int currentIdx = FindInsertionIdx(templateChars);
            while (templateChars[currentIdx] == '*')
            {
                currentIdx++;
                count++;

                if (currentIdx == templateChars.Length)
                {
                    break;
                }
            }

            return count;
        }
    }
}
