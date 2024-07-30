namespace cognine.program2
{
    class Validations
    {
        /// <summary>
        /// Prompts the user for input and validates that it is a numeric string.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <returns>A validated numeric string input from the user.</returns>
        public string ValidateInput(string prompt)
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
                }else if (input.Length <= 3)
                {
                    Console.WriteLine("Number Should be More Than 3 digits");
                }

            } while (string.IsNullOrEmpty(input) || !IsNumeric(input) || input.Length <= 3);

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
