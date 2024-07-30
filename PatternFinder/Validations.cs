namespace cognine.program1
{
    class Validations
    {
        /// <summary>
        /// Prompts the user for input and validates that it is not a numeric string.
        /// </summary>
        /// <param name="prompt">The message displayed to the user.</param>
        /// <returns>A validated string input from the user.</returns>
        public string ValidateInput(string prompt)
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
    }
}
