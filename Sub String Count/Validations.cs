using System;

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

                // Check for null or empty input manually
                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
                // Check if input is numeric manually
                else if (IsNumeric(input))
                {
                    Console.WriteLine("Input should not be a number. Please try again.");
                }
                else
                {
                    break; 
                }

            } while (true); // Continue until valid input is received

            return input;
        }

        /// <summary>
        /// Checks if a string consists only of digits.
        /// </summary>
        /// <param name="value">The string to check.</param>
        /// <returns>True if the string is numeric; otherwise, false.</returns>
        public bool IsNumeric(string value)
        {
            if (value == null || value.Length == 0)
            {
                return false;
            }

            // Check if all characters in the string are digits
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
