namespace cognine.program2
{
    class Validations
    {
        /// <summary>
        /// Prompts the user for input and validates that it is a numeric string with more than 3 digits.
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

                // Check for null or empty input manually
                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
                // Check if the input is numeric and has more than 3 digits manually
                else if (!IsNumeric(input))
                {
                    Console.WriteLine("Input should be a numeric. Please try again.");
                }
                else if (input.Length <= 3)
                {
                    Console.WriteLine("Number should be more than 3 digits.");
                }
                else
                {
                    break; // Exit the loop if the input is valid
                }

            } while (true); // Continue until valid input is received

            return input;
        }

        /// <summary>
        /// Checks if a string consists only of digits.
        /// </summary>
        /// <param name="value">The string to check.</param>
        /// <returns>True if the string is numeric; otherwise, false.</returns>
        public static bool IsNumeric(string value)
        {
            if (value == null || value.Length == 0)
            {
                return false;
            }

            // Check if all characters in the string are digits manually
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] < '0' || value[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
