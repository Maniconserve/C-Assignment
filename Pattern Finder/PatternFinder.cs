namespace Program1
{
    class PatternFinder
    {

        /// <summary>
        /// Prompts the user for input and validates that it is not a numeric string.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <returns>A validated string input from the user.</returns>
        public string GetValidatedInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                // Check for null or empty input
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
                else if (IsNumeric(input))
                {
                    Console.WriteLine("Input should not be a number. Please try again.");
                }

            } while (string.IsNullOrEmpty(input) || IsNumeric(input));

            return input;
        }

        /// <summary>
        /// Checks if a string consists only of digits.
        /// </summary>
        /// <param name="value">The string to check.</param>
        /// <returns>True if the string is numeric; otherwise, false.</returns>
        public bool IsNumeric(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            // parsing the input as a double (covers both integer and floating-point numbers).
            return double.TryParse(value, out _);
        }

        /// <summary>
        /// Finds all starting positions of the substring within the source string.
        /// </summary>
        /// <param name="source">The string to search within.</param>
        /// <param name="substring">The string to find in the source string.</param>
        /// <returns>An array of starting indices where the substring occurs in the source string.</returns>
        public int[] FindSubstringOccurrences(string source, string subString)
        {
            int initialCapacity = source.Length; // Initial capacity for the array
            int[] positions = new int[initialCapacity];
            int count = 0;

            // Loop through the source string to find occurrences of the substring.
            for (int i = 0; i <= source.Length - subString.Length; i++)
            {
                int matchLength = 0;
                // Check if the substring matches the part of the source starting at index i.
                while (matchLength < subString.Length && source[i + matchLength] == subString[matchLength])
                {
                    matchLength++;
                }
                // If a full match is found, add the starting index to the array.
                if (matchLength == subString.Length)
                {
                    positions[count] = i;
                    count++;
                }
            }

            // Trim the array to the exact number of occurrences found.
            Array.Resize(ref positions, count);

            return positions;
        }
    }
}
