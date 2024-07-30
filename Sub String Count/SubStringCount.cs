namespace cognine.program1
{
    class SubStringCount
    {
        /// <summary>
        /// Finds all starting positions of the substring within the source string.
        /// </summary>
        /// <param name="source">The string to search within.</param>
        /// <param name="substring">The string to find in the source string.</param>
        /// <returns>An array of starting indices where the substring occurs in the source string.</returns>
        public (int[],int) SubstringOccurrences(string source, string subString)
        {
            int initialCapacity = source.Length; // Initial capacity for the array
            int[] positions = new int[initialCapacity];
            int count = 0;

            // Loop through the source string to find occurrences of the substring.
            for (int index = 0; index <= source.Length - subString.Length; index++)
            {
                int matchLength = 0;
                // Check if the substring matches the part of the source starting at index i.
                while (matchLength < subString.Length && source[index + matchLength] == subString[matchLength])
                {
                    matchLength++;
                }
                // If a full match is found, add the starting index to the array.
                if (matchLength == subString.Length)
                {
                    positions[count] = index;
                    count++;
                }
            }
            return (positions,count);
        }
    }
}
