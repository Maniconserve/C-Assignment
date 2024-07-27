namespace Program2
{
    internal class MaximumProductFinder
    {
        /// <summary>
        /// Finds the maximum product of four consecutive digits in a numeric string.
        /// </summary>
        /// <param name="numericString">The numeric string to analyze.</param>
        /// <returns>The maximum product of four consecutive digits.</returns>
        public long FindMaxProductOfFourConsecutiveDigits(string numericString)
        {
            long maxProduct = 0;

            // Calculate the maximum product of four consecutive digits.
            for (int i = 0; i < numericString.Length - 3; i++)
            {
                long product = 1;
                for (int j = 0; j < 4; j++)
                {
                    product *= numericString[i + j] - '0';
                }
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }

        /// <summary>
        /// Prompts the user for input and validates that it is a numeric string.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <returns>A validated numeric string input from the user.</returns>
        public string GetValidatedNumericInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                // Check for null or empty input and whether it is numeric.
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
                else if (!IsNumeric(input))
                {
                    Console.WriteLine("Input should be a numeric string. Please try again.");
                }

            } while (string.IsNullOrEmpty(input) || !IsNumeric(input));

            return input;
        }

        /// <summary>
        /// Checks if a string consists only of digits.
        /// </summary>
        /// <param name="value">The string to check.</param>
        /// <returns>True if the string is numeric; otherwise, false.</returns>
        public static bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}